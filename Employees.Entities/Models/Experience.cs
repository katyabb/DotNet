namespace Employees.Entities.Models;
public class Experience : BaseEntity {
    
    public int ExperienceTime { get; set; }
    public Guid JobTitleID { get; set;}
    public virtual JobTitle JobTitle {get; set;}
    public Guid EmployeerID { get; set;}
    public virtual Employeer Employeer {get; set;}

    
    
}