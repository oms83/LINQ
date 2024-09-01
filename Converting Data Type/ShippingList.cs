using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Converting_Data_Type
{
    public class ShippingList<T> : List<T> where T : Shipping
    {
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("Filtering Shipping ...");
            return Enumerable.Where(this, predicate);
        }
    }
}
