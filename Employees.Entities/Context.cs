using Microsoft.EntityFrameworkCore;
using Employees.Entities.Models;

namespace Employees.Entities;

public class Context : DbContext
{
    public DbSet<Employeer> Employees { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
    
    public Context(DbContextOptions<Context> options) : base(options) { }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        #region Employees
        builder.Entity<Employeer>().ToTable("employees");
        builder.Entity<Employeer>().HasKey(x => x.Id);
        #endregion

        #region Educations
        builder.Entity<Education>().ToTable("educations");
        builder.Entity<Education>().HasKey(x => x.Id);
        builder.Entity<Education>().HasOne(x => x.Employeer)
                                .WithMany(x => x.Educations)
                                .HasForeignKey(x => x.EmployeerID)
                                ?.OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region Experiences
        builder.Entity<Experience>().ToTable("experiences");
        builder.Entity<Experience>().HasKey(x => x.Id);
        builder.Entity<Experience>().HasOne(x => x.Employeer)
                                    .WithMany(x => x.Experiences)
                                    .HasForeignKey(x => x.EmployeerID)
                                    .OnDelete(DeleteBehavior.Cascade);
        builder.Entity<Experience>().HasOne(x => x.JobTitle)
                                    .WithMany(x => x.Experiences)
                                    .HasForeignKey(x => x.JobTitleID)
                                    .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region Salaries
        builder.Entity<Salary>().ToTable("salaries");
        builder.Entity<Salary>().HasKey(x => x.Id);
        builder.Entity<Salary>().HasOne(x => x.Employeer)
                                .WithMany(x => x.Salaries)
                                .HasForeignKey(x => x.EmployeerID)
                                ?.OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region JobTitles
        builder.Entity<JobTitle>().ToTable("jobtitles");
        builder.Entity<JobTitle>().HasKey(x => x.Id);
        #endregion

        

        
    }
}
