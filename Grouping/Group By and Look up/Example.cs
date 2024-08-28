using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Grouping.Group_By
{
    public class Example
    {
        /*
            GroupBy
            - Uses deferred execution
            - each iterate => group again IEnumerable<IGrouping<TKey, TSource>>

            ToLookup
            - Uses immediate execution
            - buffer the result in memory (multiple process) ILookup<TKey, TSource>




            Return Type:

            GroupBy: Returns IEnumerable<IGrouping<TKey, TElement>>, which is a sequence of groups, 
                     and each group is an IGrouping that contains a key and a collection of elements.

            ToLookup: Returns ILookup<TKey, TElement>, which is similar to a dictionary where each key maps to a collection of elements.



            Deferred Execution:

            GroupBy: Executes lazily, meaning the grouping is done when you iterate over the result.

            ToLookup: Executes immediately, meaning the grouping is done right away.




            Immutability:

            GroupBy: The result can be modified or further queried.
            ToLookup: The result is immutable and cannot be modified after creation.

         */
        public static void run()
        {
            //GroupByExample();
            ToLookUpExample();
        }

        static void GroupByExample()
        {
            var emps = Repository.GetEmployeesInfo();

            //var groups = emps.GroupBy(emp => emp.Department);
            IEnumerable<IGrouping<string, Employee>> groups = emps.GroupBy(emp => emp.Department);


            foreach (var group in groups)
            {
                Console.WriteLine($"\n\n{group.Key}\n");

                foreach (var employee in group)
                {
                    Console.WriteLine($" - {employee}");
                }
            }

            // query sytax
            var groupsQ = from emp in emps
                          group emp by emp.Department;

            foreach (var group in groupsQ)
            {
                Console.WriteLine($"\n\n{group.Key}\n");

                foreach (var employee in group)
                {
                    Console.WriteLine($" - {employee}");
                }
            }
        }

        static void ToLookUpExample()
        {
            var emps = Repository.GetEmployeesInfo();

            ILookup<string, Employee> groups = emps.ToLookup(emp => emp.Department);


            foreach (var group in groups)
            {
                Console.WriteLine($"\n\n{group.Key}\n");

                foreach (var employee in group)
                {
                    Console.WriteLine($" - {employee}");
                }
            }

        }
    }
}