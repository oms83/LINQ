using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data_Partitioning.Pagination
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page, int size) where T : class
        {
            if (page <= 0)
            {
                page = 1;
            }

            if (size <= 0)
            {
                size = 10;
            }
            
            var totalPages = source.Count();

            var pages = (int) Math.Ceiling((decimal)totalPages/size);

            var result = source.Skip((page-1)*size).Take(size);

            return result;
        }
    }
}
