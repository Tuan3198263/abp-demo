using System;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.Employees;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EmpManager.Employees;

[Authorize]
public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, Guid, GetEmployeeInput>, IEmployeeAppService
{
    public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository)
    { }

    protected override async Task<IQueryable<Employee>> CreateFilteredQueryAsync(GetEmployeeInput input)
    {
        var query = await base.CreateFilteredQueryAsync(input);
        return query.WhereIf(!input.Filter.IsNullOrWhiteSpace(),
            x => x.Name.Contains(input.Filter!) || x.Code.Contains(input.Filter!));
    }
}