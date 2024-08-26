using LINQ.Extension_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sorting.Reverse_Operation
{
    public static class Example
    {
        public static void run()
        {
            string[] fruits = { "banana", "mango", "strawberry",
                            "grape", "apple", "orange", "apricot" };

            var reverseOrdered = fruits.Reverse();

            reverseOrdered.Print();
        }

        static void Print(this IEnumerable<string> fruits) 
        {
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
