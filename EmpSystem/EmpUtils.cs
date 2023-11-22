using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//utility class basically contain static functions so,
//hence the class need not to be instantiated
namespace EmpLib
{
   
    public class EmpUtils
    {
        public static List<Employee> EmpDb { get; set; } = new List<Employee>();
        public static int EmpCount { get; set; }

        public static void Log<T>(T[] pValues)
        {
            string result = "";
            foreach (var item in pValues)
            {
                result = $"{result} {item}";
            }

            var finalResult = $"[ {DateTime.Now.ToString()} ] : {result}";
            //Console Logging
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------");
            Console.WriteLine(finalResult);

            //Output Window
            Debug.WriteLine("----- LOG ------");
            Debug.WriteLine(finalResult);

        

    }
    }
}
