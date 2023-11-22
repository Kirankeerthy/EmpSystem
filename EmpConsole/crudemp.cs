using EmpDal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpConsoled
{
   
    
        public class crudemp<T> where T : Employee
    {
            static EmpDbContext dbcontext = new EmpDbContext();

       

        public static void insertemp(string pempname, bool isactive)
            {
            dbcontext.Employees.Add(new EmpDal.Employee() { empname = "Imposter Hacker", IsActive = true });

            dbcontext.SaveChanges();


            }

            public static void update(string pname, string updatedvalue)
            {
                var tobeupdated = dbcontext.Employees.ToList().Where((p) => p.empname == pname).FirstOrDefault();

                tobeupdated.empname = updatedvalue;
                dbcontext.SaveChanges();
            }
            public static List<EmpDal.Employee> get()
            {
                dbcontext.Employees
        .ToList()
        .ForEach((p) => {
            if (p.IsActive == true)
                Console.WriteLine($"{p.empname} is a {p.IsActive} parent");
            else
                Console.WriteLine($"{p.empname} is a child");
        });
                return dbcontext.Employees.ToList() as List<EmpDal.Employee>;
            }

            public static void delete(string pname)
            {
                var tobedeleted = dbcontext.Employees.ToList().Where((p) => p.empname == pname).FirstOrDefault();
                dbcontext.Employees.Remove(tobedeleted);
              dbcontext.SaveChanges();
            }

       
    }
    }



