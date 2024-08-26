using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sorting.ThenBySorting
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            Example02();
        }

        static void Example01()
        {
            var emps = Sorting.Repository.GetEmployeeInfo();

            var empsOrdered = emps.OrderBy(e => e.Name).ThenBy(e => e.Salary);

            foreach (var item in empsOrdered)
            {
                Console.WriteLine(item);
            }
        }
        static void Example02()
        {
            var emps = Sorting.Repository.GetEmployeeInfo();

            var empsOrdered = emps.OrderByDescending(e => e.Name).ThenBy(e => e.Salary);

            foreach (var item in empsOrdered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
