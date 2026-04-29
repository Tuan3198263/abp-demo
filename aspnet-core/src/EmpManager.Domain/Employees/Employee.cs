using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace EmpManager.Employees;

public class Employee : FullAuditedAggregateRoot<Guid>
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Code { get; set; }
    [Required]
    public string Sex { get; set; }
    [Required]
    public decimal Salary { get; set; }
    [Required]
    public string Department { get; set; }
    [Required]
    public DateTime BirthDay { get; set; }
    // Constructor mặc định cho ORM
    private Employee() { }

    public Employee(Guid id, string name, string code, decimal salary, string sex, string department, DateTime birthDay) : base(id)
    {
        Name = name;
        Code = code;
        Sex = sex;
        Salary = salary;
        Department = department;
        BirthDay = birthDay;
    }
}