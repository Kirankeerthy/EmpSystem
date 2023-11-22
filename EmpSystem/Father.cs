using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Father:Talents
    {
        //permitting different logic in derived
        public virtual string Settle()
        {
            return "Get a govenment job,Retire by 60yrs and settle in native";
        }
        public string GetMarried()
        {
            return "Match horoscope , marry person from same religion ,caste , settle in joint family";
        }
        public override string Drawing()
        {
            return "drawing";
        }
        public override string WhatIsDating()
        {
            return "dating";
        }



    }
public abstract  class Talents
    {
        public abstract string WhatIsDating();
        public abstract string Drawing();
    }
    public class Child:Father
    {
        public override string Settle()
        {
            string howtolive = "get a fast salary job at fortune 500 companies";
            howtolive = $"{howtolive} and later follow this :{ base.Settle()}";
            return howtolive;   

        }
        //function hiding
        new public string GetMarried()
        {
            return "register marriage,surprise parents";
        }
    }
}


