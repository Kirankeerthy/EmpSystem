using System.ComponentModel.DataAnnotations;

namespace EmpWebApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        //  public DateTime DOJ { get; set; }
        //   public bool IsActive { get; set; }

        public string empname { get; set; }



    }
    public class EmployeeOperations
    {
        private static List<Employee> _employee = new List<Employee>();
        public static List<Employee> GetEmployee()
        {
            if (_employee.Count == 0)
            {
                _employee.Add(new Employee() { EmpId = 16609, Designation = "Tester", Salary = 25000, empname = "Jack" });
                _employee.Add(new Employee() { EmpId = 16610, Designation = "BackendDeveloper", Salary = 35000, empname = "Jill" });
                _employee.Add(new Employee() { EmpId = 16611, Designation = "FrontEndDeveloper", Salary = 45000, empname = "Nick" });
            }
            return _employee;
        }

        public static Employee Search(int eEmpId)
        {
            return GetEmployee().Where(e => e.EmpId == eEmpId).FirstOrDefault();
        }
       internal static void CreateNew(Employee e)
        {
            GetEmployee();
            _employee.Add(e);
        }

       
    }
}







