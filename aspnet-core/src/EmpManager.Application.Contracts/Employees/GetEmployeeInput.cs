using Volo.Abp.Application.Dtos;


namespace EmpManager.Employees;

public class GetEmployeeInput : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }

}