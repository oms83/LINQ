using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Quantifiers.Contains_Operation
{
    public class Example
    {
        public static void run()
        {

            var emps = Repository.GetEmployeeInfo();

            // instance method
            var result = emps.Any(emp => emp.Name.ToLowerInvariant().Contains("om"));

            Console.WriteLine($"Check if any employee has \"om\" in their names: {result}");

            
            var e = new Employee()
            {
                Name = "Ali MEMES",
                Email = "oms@gmail.com", // there is employee with same email but the reference of object is deferent
                Skills = new List<string>()
                {
                    "C", "C#", "C++", "Sql Server"
                },
                EmployeeNo = "1212-IT-1212",
                Salary = 5000m
            };

            // extension method 
            var result2 = emps.Contains(e);

            Console.WriteLine($"Check if any employee object with same email is exist: {result2}");


        }
    }
}
