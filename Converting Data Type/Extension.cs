using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Converting_Data_Type
{
    public static class Extension
    {
        public static void Process<T>(this IEnumerable<T> source, string Title) where T : Shipping
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"|{Title.PadLeft(32,' ')}  \t\t        |");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var item in source)
            {
                (item as Shipping)?.Start();
            }
        }
    }
}
