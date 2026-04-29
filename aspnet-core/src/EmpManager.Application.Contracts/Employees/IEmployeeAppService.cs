using System;
using System.Collections.Generic; // Chứa List<>
using System.Threading.Tasks; // Chứa Task
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace EmpManager.Employees;


public interface IEmployeeAppService :
    ICrudAppService<
        EmployeeDto,    // DTO hiển thị
        Guid,           // Khóa chính
        GetEmployeeInput, CreateUpdateEmployeeDto> // DTO truy vấn/phân trang
{
    // Bạn có thể định nghĩa thêm các phương thức custom ở đây nếu cần
    // Thêm nhiều nhân viên
    Task CreateManyAsync(List<CreateUpdateEmployeeDto> input);
    Task DeleteManyAsync(List<Guid> ids);
}