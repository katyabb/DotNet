namespace Employees.Entities.Models;
public class JobTitle : BaseEntity {
    
    public string JobTitleName {get; set;}
    public virtual ICollection<Experience> Experiences {get; set;}
}