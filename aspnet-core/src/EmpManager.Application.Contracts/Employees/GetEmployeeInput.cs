using Volo.Abp.Application.Dtos;


namespace EmpManager.Employees;

public class GetEmployeeInput : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Sex { get; set; }
    public decimal? Salary { get; set; }
    public string? Department { get; set; }
}