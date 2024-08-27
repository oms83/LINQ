using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data_Partitioning.Pagination
{
    public class Example
    {
        public static void run()
        {
            int page = 1;
            int size = 10;

            Console.WriteLine("result per page: ");
            if (int.TryParse(Console.ReadLine(), out int resultPerPage))
            {
                size = resultPerPage;
            }

            Console.WriteLine("page number: ");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }

            var emps = Repository.GetEmployeeInfo();

            var result = emps.Paginate(page, size);



            var _firstRecord = result.First();

            var _lastRecord = result.Last();
            
            var count = result.Count();
            
            var first = (page -  1) * size  + 1;

            var last = count < size ? first + count - 1
                                    //: (page - 1) * size + size;
                                    : (first - 1) + size;

            result.Print($"{first} - {last}");

            /*
            0
            1
            2
            3
            4

            5
            6
            7
            8
            9

             
            */
        }
    }
}
