using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using EmpManager.Employees;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EmpManager.Employees;

[Authorize]
public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, Guid, GetEmployeeInput, CreateUpdateEmployeeDto>, IEmployeeAppService
{
    public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository)
    { }

    protected override async Task<IQueryable<Employee>> CreateFilteredQueryAsync(GetEmployeeInput input)
    {
        var query = await base.CreateFilteredQueryAsync(input);
        // 2. Lọc theo ô tìm kiếm chung (Filter) - Tìm trong Name hoặc Code
        query = query.WhereIf(!input.Filter.IsNullOrWhiteSpace(),
            x => x.Name.Contains(input.Filter!) || x.Code.Contains(input.Filter!));

        // 3. Lọc riêng biệt theo từng trường (Nếu có truyền vào)

        // Tìm chính xác Mã nhân viên
        query = query.WhereIf(!input.Code.IsNullOrWhiteSpace(), x => x.Code == input.Code);

        // Tìm tên (Dùng Contains để tìm họ hoặc tên đều được)
        query = query.WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name!));

        // Tìm chính xác Bộ phận
        query = query.WhereIf(!input.Department.IsNullOrWhiteSpace(), x => x.Department == input.Department);

        // Tìm chính xác Giới tính
        query = query.WhereIf(!input.Sex.IsNullOrWhiteSpace(), x => x.Sex == input.Sex);

        // Tìm chính xác mức Lương
        query = query.WhereIf(input.Salary.HasValue, x => x.Salary == input.Salary);

        return query;
    }

    // API THÊM NHIỀU
    public async Task CreateManyAsync(List<CreateUpdateEmployeeDto> input)
    {
        foreach (var item in input)
        {
            // 1. Kiểm tra mã nhân viên đã tồn tại trong DB chưa
            var existing = await Repository.FirstOrDefaultAsync(x => x.Code == item.Code);
            if (existing != null)
            {
                // Nếu trùng, ném lỗi ra cho Client biết ông nào bị trùng
                throw new UserFriendlyException($"Mã nhân viên {item.Code} đã tồn tại trong hệ thống!");
            }

            // 2. Nếu không trùng thì tiến hành Map và Insert
            var employee = ObjectMapper.Map<CreateUpdateEmployeeDto, Employee>(item);
            await Repository.InsertAsync(employee);
        }
    }

    // API XÓA NHIỀU
    public async Task DeleteManyAsync(List<Guid> ids)
    {
        // Xóa tất cả những nhân viên có ID nằm trong danh sách truyền vào
        await Repository.DeleteManyAsync(ids);
    }
}