using LINQ.Extension_Method;
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
            //Example01();
            //Example02();
            //Example03();
            Example04();
        }
        public static void Example04()
        {
            var employees = Repository.GetEmployeesInfo();

            Console.WriteLine(employees.Random(emp => emp.HasHealthInsurance, 1, 7)); ;

        }
        public static void Example03()
        {
            var employees = Repository.GetEmployeesInfo();

            employees.WhereWithPaginate(emp => emp.HasHealthInsurance, 1, 7).Print("");

        }
        public static void Example02()
        {
            var employees = Repository.GetEmployeesInfo();

            employees.Paginate().Print("Page #1");
            employees.Paginate(null, 7).Print("Page #1");
            employees.Paginate(2, null).Print("Page #1");
            employees.Paginate(null, null).Print("Page #1");

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
