using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Deffered_vs_Immediate
{
    internal class Example
    {

        public static void run()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            var evenNums1 = list.Where(n => n % 2 == 0);

            var evenNums2 = Enumerable.Where(list, n => n % 2 == 0);

            var evenNums3 = from n in evenNums1
                            where n % 2 == 0
                            select n;

        }
        public static void run3()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };


            // When we execute this linq query, a new array will not be created in memory,
            // but the numbers resulting from the query will be referenced.
            // So when we make changes to the source set after executing the query,
            // the changes will be taken into account in the result set.

            IEnumerable<int> evenNumbers = list.Where(n => n % 2 == 0);

            list.Add(200);
            list.Add(150);
            list.Remove(2);


            // لما بكون انموريشن كل التعديل على الكوللكشن الاصلية بأثر على الكوللكشن الانومورييشن

            foreach (var item in evenNumbers)
            {
                Console.Write($"{item}, ");  // 4, 6, 8, 10, 12, 14, 200, 150,
            }
        }


        public static void run2()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            List<int> evenNumbers = list.Where(n => n % 2 == 0).ToList();

            list.Add(200);
            list.Add(150);
            list.Remove(2);

            evenNumbers.ForEach(n=>Console.Write($"{n}, ")); // 2, 4, 6, 8, 10, 12, 14,
        }
        public static void run1()
        {
            //public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable,
            //                       IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = list.Where(n => n % 2 == 0);
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }


            //public class ArrayList : IList, ICollection, IEnumerable, ICloneable    

            ArrayList arrayList = new ArrayList() { 1, true, DateTime.Now };
            //arrayList.Where(n => n % 2 == 0);


        }
    }
}
