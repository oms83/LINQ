using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Custom_LINQ_Extension_Method
{
    public class Example
    {
        public static void run()
        {
            Example01();
        }

        public static void Example01()
        {
            var employees = Repository.GetEmployeesInfo();


            var page = 1;
            var pageSize = 10;

            employees.Skip((page - 1) * pageSize).Take(pageSize).Print("Page #1");

            //employees.Print("All Employees");

            Console.WriteLine("----------------------------");


            employees.Paginate(page, pageSize).Print("Page #1");

        }
    }
}
