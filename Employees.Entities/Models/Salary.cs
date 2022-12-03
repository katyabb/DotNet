namespace Employees.Entities.Models;

public class Salary : BaseEntity {
    public int BasicSalary { get; set; }
    public int Premium { get; set; }
    public DateTime Month { get; set; }
    public int WorkDays { get; set; }

    public Guid EmployeerID { get; set;}
    public virtual Employeer Employeer {get; set;}


}