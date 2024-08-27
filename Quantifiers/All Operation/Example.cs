using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Quantifiers.All_Operation
{
    public class Example
    {
        public static void run()
        {
            var emps = Repository.GetEmployeeInfo();

            // Check if all employees have value for email.

            var result1 = emps.All(emp => emp.Email is null);

            if (result1)
            {
                Console.WriteLine("There are employee(s) not have email");
            }
            else
            {
                Console.WriteLine("all employees have email");
            }

            // Check if all employees have c# skill

            var result = emps.All(emp => emp.Skills.Contains("C#"));
            var result2 = emps.All(emp => emp.Skills.Any(skll => skll == "C#"));
            if (result2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
