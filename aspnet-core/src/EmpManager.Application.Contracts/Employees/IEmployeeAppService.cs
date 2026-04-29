using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EmpManager.Employees;

public interface IEmployeeAppService :
    ICrudAppService<
        EmployeeDto,    // DTO hiển thị
        Guid,           // Khóa chính
        GetEmployeeInput> // DTO truy vấn/phân trang
{
    // Bạn có thể định nghĩa thêm các phương thức custom ở đây nếu cần
}