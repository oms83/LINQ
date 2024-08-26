using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sorting
{
    public class OderBy
    {
        public static void run()
        {
            //Example01();
            Example02();
        }

        static void Example02()
        {
            //****************************************

            string[] fruits = { "banana", "mango", "strawberry",
                            "grape", "apple", "orange", "apricot" };

            var orderedFruits = fruits.OrderBy(x => x.Length);
            Console.WriteLine(string.Join(", ", orderedFruits)); // asc

            var orderedFruitsQ = from x in fruits
                                 orderby x.Length
                                 select x; // asc

            Console.WriteLine(string.Join(", ", orderedFruitsQ));

            //****************************************

            var orderedFruitsDesc = fruits.OrderByDescending(x => x.Length);
            Console.WriteLine(string.Join(", ", orderedFruitsDesc)); // desc

            var orderedFruitsQDesc = from x in fruits
                                     orderby x.Length descending
                                     select x; // desc

            Console.WriteLine(string.Join(", ", orderedFruitsQDesc));

            //****************************************
        }
        static void Example01()
        {
            //****************************************

            string[] fruits = { "banana", "mango", "strawberry",
                            "grape", "apple", "orange", "apricot" };

            var orderedFruits = fruits.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", orderedFruits)); // asc

            var orderedFruitsQ = from x in fruits
                                 orderby x
                                 select x; // asc

            Console.WriteLine(string.Join(", ", orderedFruitsQ));

            //****************************************

            var orderedFruitsDesc = fruits.OrderByDescending(x => x);
            Console.WriteLine(string.Join(", ", orderedFruitsDesc)); // desc

            var orderedFruitsQDesc = from x in fruits
                                 orderby x descending
                                 select x; // desc

            Console.WriteLine(string.Join(", ", orderedFruitsQDesc));
            
            //****************************************

        }
    }
}
