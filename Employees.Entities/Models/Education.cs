namespace Employees.Entities.Models;

public class Education : BaseEntity {
    public string NameOfOrganization { get; set; }
    public int YearOfEnding { get; set; }
    public string LevelOfEducation { get; set; }
    public string AcademicDegree { get; set; }
    public Guid EmployeerID { get; set;}
    public virtual Employeer Employeer {get; set;}
}