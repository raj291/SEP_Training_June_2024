using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Entities;

public class Employee
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? EmployeeName { get; set; }
    [Required]
    public int Age { get; set; }
    [Required(ErrorMessage = "Department Id is Required")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}