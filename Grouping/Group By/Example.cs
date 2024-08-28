using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Grouping.Group_By
{
    public class Example
    {
        public static void run()
        {
            GroupByExample();
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
    }
}
