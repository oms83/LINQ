using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Quantifiers.Any_Operation
{
    public class Example
    {
        public static void run()
        {
            var emps = Repository.GetEmployeeInfo();

            var result1 = emps.Any(emp => emp.Name.StartsWith("om", StringComparison.OrdinalIgnoreCase));
            if (result1)
            {
                Console.WriteLine("there are employees their name starts with \"om\"");
            }
            else
            {
                Console.WriteLine("there are not employees their name starts with \"om\"");
            }

            var result2 = emps.Any(emp => emp.Salary > 5_000);
            if (result2)
            {
                Console.WriteLine("there are employees their salary greate 5000");
            }
            else
            {
                Console.WriteLine("there are not employees their salary greate 5000");
            }

        }

    }
}
