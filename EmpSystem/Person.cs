using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    //private - no sharing outside class
    //public - can share everything outside the class,project
    //protected - acces available
    public class Person
    {

        public Person()
        {
                
        }

        public Person(String pAadhar)
        {
            this.Aadhar = pAadhar;
            
        }
        //calling the one constructor from another
        public Person(String pAadhar, String pMobile) : this(pAadhar)
        {
            this.MobileNumber =pMobile;

        }

        public string Name { get; set; }
        public string Aadhar { get; set; }
        public string Email { get; set; }
        public Gender PersonGender { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

        public string Eat()
        {
            return $"{this.Name} Eats BF,Lunch,Dinner";
        }
        public string Sleep()
        {
            return $"{this.Name}sleeps 8hrs a day";
        }
        public virtual string Work()
        {
            return $"{this.Name} works for 4hrs,relax for 8hrs";
        }
        protected string TaxDetails { get; set; }


    }
    public enum Gender
    {
        Male, Female
    }
}






