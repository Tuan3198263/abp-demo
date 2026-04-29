using AutoMapper;
using EmpManager.Employees; // PHẢI CÓ DÒNG NÀY

namespace EmpManager;

public class EmpManagerApplicationAutoMapperProfile : Profile
{
    public EmpManagerApplicationAutoMapperProfile()
    {
        // 1. Ánh xạ từ Entity sang DTO
        CreateMap<Employee, EmployeeDto>();

        // 2. Ánh xạ từ DTO sang Entity
        CreateMap<EmployeeDto, Employee>();
    }
}