using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Deffered_vs_Immediate
{
    public class Example2
    {
        /*
            Deferred Execution
                Deferred execution means that the query is not executed at the point of its definition but 
                is delayed until the query results are actually accessed (e.g., through iteration or materialization).

                LINQ queries are not executed when they are defined, but when they are enumerated 
                (e.g., using a foreach loop or calling methods like .ToList() or .ToArray()).
                This allows for modifying the query later or adding more operations before it's executed. 

            Characteristics of Deferred Execution:
                Query evaluation happens only when the query is accessed.
                You can change the source collection before the query is executed.
                It improves performance by postponing the execution until needed.




            Immediate Execution
                Immediate execution means that the query is executed immediately and the result is stored in memory.

                In LINQ, some methods trigger immediate execution, such as:
                .ToList()
                .ToArray()
                .Count(), .First(), .Single(), .Max(), .Min(), etc.

                These methods force the query to be executed and the results to be materialized immediately.

            Characteristics of Immediate Execution:
                The query is executed right away, and the results are stored in memory.
                The data is fixed at the point of execution and will not reflect any future changes to the source.
                Useful when you need to store or reuse the result multiple times.


            
                Execution Type	                 When It Happens	                                                 Examples
                Deferred Execution	    When the query is enumerated (e.g., foreach)	            .Where(), .Select(), .OrderBy()
                Immediate Execution     When the query is materialized or evaluated immediately     .ToList(), .ToArray(), .Count()



        */

        public static void DeferredExecution()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // LINQ query is defined but not executed yet.
            var query = numbers.Where(n => n > 2);

            // At this point, the query has not been executed.
            // The query is executed when we enumerate it (e.g., using foreach or .ToList()).
            foreach (var num in query)
            {
                Console.WriteLine(num); // Output: 3, 4, 5
            }

        }

        public static void ImmediateExecution()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // LINQ query is executed immediately due to the .ToList() method.
            var result = numbers.Where(n => n > 2).ToList();

            // At this point, the query has been executed and the result is stored in 'result'.
            foreach (var num in result)
            {
                Console.WriteLine(num); // Output: 3, 4, 5
            }

        }
    }
}
