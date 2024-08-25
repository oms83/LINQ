using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Zip_Operation
{
    internal class Example
    {
        public static void run2()
        {
            //var employees = LINQTut04.Shared.Repository.GetEmployeesInfo().ToArray();
            //var firstThreeEmps = employees[..3];
            //var lastThreeEmps = employees[^..3];
            //var teams = firstThreeEmps.Zip(lastThreeEmps, 
            //                               (first, last) 
            //                               => $"{first} with {last}");

            //foreach (var t in teams)
            //{
            //    Console.WriteLine(t);
            //}
        }
        public static void run1()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHex = { "FF0000", "00FF00", "0000FF" };

            /*
             IEnumerable<string> IEnumerable<string>.Zip<string, string, string> 
            (IEnumerable<string> second, 
             Func<string, string, string> resultSelector)
             */

            var colors = colorName.Zip(colorHex, (name, hex) => $"{name} - {hex}");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            /*
                Red - FF0000
                Green - 00FF00
                Blue - 0000FF 
            */
        }
    }
}
