namespace Employees.Entities.Models;
public class Employeer : BaseEntity
{

    public string FullName { get; set; }
    public int PassportSerial { get; set; }
    public int PassportNumber { get; set; }
    public DateTime Birthdate { get; set; }
    public string Snils { get; set; }
    public string Address { get; set; }
    public string Role {get; set;}
    public string Email {get; set;}
    public string Login {get; set;}
    public string PasswordHash {get; set;}

    public virtual ICollection<Education> Educations {get; set;}
    public virtual ICollection<Salary> Salaries {get; set;}
    public virtual ICollection<Experience> Experiences {get; set;}
    
}