using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Custom_LINQ_Extension_Method
{
    public static class Extensions
    {
        private static Random _random = new Random();
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

        public static IEnumerable<TSource> Paginate<TSource>(this IEnumerable<TSource> source, int? page, int? pageSize)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (!page.HasValue)
            {
                page = 1; 
            }

            if (!pageSize.HasValue)
            {
                page = 10; 
            }

            if (!source.Any())
            {
                return Enumerable.Empty<TSource>();
            }

            return source.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
        }

        public static IEnumerable<TSource> WhereWithPaginate<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate,
            int? page, int? pageSize)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (predicate == null)
            {
                throw new ArgumentException($"{nameof(predicate)}");
            }

            if (!source.Any())
            {
                return Enumerable.Empty<TSource>();
            }

            var result = Enumerable.Where(source, predicate);

            return Paginate(result, page, pageSize);
        }

        public static TSource Random<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate,
            int? page, int? pageSize)
        {
            if (source == null)
            {
                throw new ArgumentException($"{nameof(source)}");
            }

            if (predicate == null)
            {
                throw new ArgumentException($"{nameof(predicate)}");
            }

            if (!source.Any())
            {
                // Tsource: Because it is not clear what will be returned
                return default;
            }

            var result = Enumerable.Where(source, predicate);

            return result.ElementAt(_random.Next(0, result.Count()));
        }
    }
}
