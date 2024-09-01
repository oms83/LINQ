using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Converting_Data_Type
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            //Example03();
            //Example04();
            Example05();
            Example06();
        }
        private static void Example06()
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShipping = shippings.OfType<GroundShipping>();

            groundShipping.Process("ground shippings (of type)");
        }
        private static void Example05()
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShipping = shippings.Where(s=> s.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();

            groundShipping.Process("ground shippings (cast) ");
        }
        private static void Example04()
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;


            // Enumerable<T> Where 
            var TodayShipping = shippings.AsQueryable().Where(s => s.ShippingDate == DateTime.Today.AddDays(1));

            TodayShipping.Process("Today Shipping");

            Console.WriteLine(TodayShipping.Expression);
        }
        private static void Example03()
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;


            // Enumerable<T> Where 
            var TodayShipping = shippings.AsEnumerable().Where(s => s.ShippingDate == DateTime.Today.AddDays(1));

            TodayShipping.Process("Today Shipping");
        }

        private static void Example02()
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            // Custom Where Method
            var shipping = shippings.Where(s => s.ShippingDate == DateTime.Today.AddDays(1));

            shipping.Process("Today Shipping");
        }

        private static void Example01()
        {
            var shippings = ShippingRepository.AllAsList;
            shippings.Process("All Shippings");
            //shippings.Process("All Shippings");
        }
    }

    public static class Implementation
    {
        private static IEnumerable<T> ImplementOfOfType<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                // safe cast
                if (item is T)
                {
                    yield return (T)item;
                }
            }
        }
        private static IEnumerable<T> ImplementOfCast<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                yield return (T)item;
            }
        }
    }
}
