using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;


namespace EmpDal
{
    /*   public class Person
       {
           [Required]
           public string Aadhar { get; set; }

           [MaxLength(100)]
           public string Name { get; set; }

           [Range(18, 110)]
           public int Age { get; set; }

           [EmailAddress]

           public string Email { get; set; }
       }*/

    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        
       // public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool IsActive { get; set; }
        public string empname { get; set; }
    }
    public class EmpDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    //    Database.SetInitializer<EmpDbContext>(new CreateDatabaseIfNotExists<EmpDbContext>());

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


           


        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmpDb;Trusted_Connection=true");

        }
    }
}



