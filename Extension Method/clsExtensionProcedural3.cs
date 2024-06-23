using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Extension_Method
{
    public static class clsExtensionProcedural3
    {
        // Extension method must be defined in a non-generic static class
        public static IEnumerable<clsEmployee> Filter(this IEnumerable<clsEmployee> source, Predicate<clsEmployee> predicate)
        {
            //External Dependency
            //var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }
        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("\t\t\t______________________________________________________________");
            Console.WriteLine($"{title.PadLeft(75, ' ')}");
            Console.WriteLine("\t\t\t______________________________________________________________");

            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
