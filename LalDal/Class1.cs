using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LabDal
{
    
        public class OneStudent
        {

            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class ManyCourse
        {
            [Key]
            public int Id { get; set; }
      

            public List<OneStudent> OneStudents { get; set; }

        }
        public class OneCourse
        {

            [Key]
            public int Id { get; set; }
           
        }
    public class ToManyStudent
    {
        [Key]
        public int Id { get; set; }

        public List<OneCourse> oneCourses { get; set; }

    }
        public class ToOneCompany
        {
            [Key]
            public int Id { get; set; }
            public OneStudent RelatedToOneStudent { get; set; }
        }



        public class TestDb1Context : DbContext
        {

            public DbSet<OneStudent> OneStudents { get; set; }
        public DbSet<ManyCourse> ManyCourses{ get; set; }
        public DbSet<OneCourse> OneCourses { get; set; }
            public DbSet<ToManyStudent> ToManyStudents { get; set; }
            public DbSet<ToOneCompany> ToOneCompanies { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb1;Trusted_Connection=true");

            }
       
           

    }
    }

