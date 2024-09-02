using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Custom_LINQ_Extension_Method
{
    public static class Extensions
    {
        public static void Print(this IEnumerable<Employee> employees, string Message)
        {
            Console.WriteLine($"\n\t\t\t\t\t\t\t{Message}\n");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public static IEnumerable<TSource> Paginate<TSource>(this IEnumerable<TSource> source, int page = 1, int pageSize = 10)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (page <= 0)
            {
                //page = 1; reset the value
                throw new AggregateException($"{nameof(page)}");
            }


            if (pageSize <= 0)
            {
                //page = 10; reset the value
                throw new AggregateException($"{nameof(page)}");
            }

            if (!source.Any())
            {
                return Enumerable.Empty<TSource>();
            }

            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }   
    }
}
