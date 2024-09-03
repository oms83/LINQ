using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ_Anatomy
{
    public class Examples
    {
        public static void run()
        {
            DemoFluentAPI();
        }

        private static void DemoFluentAPI()
        {
            var deck = new Deck();
            var cards = deck.Shuffle();

            // ### Fluent API ###
            // 1. Method Chaining and Extension Method to make  statment look like a sentence.
            // 2. is code that reads as a sentence.
            //

            var query = cards.OrderBy(c => c.Value)
                            .Skip(10)
                            .Take(10)
                            .OrderBy(c => c.Suite)
                            .ThenBy(c => c.Value)
                            .ToList();

            query.ForEach(c=>Console.WriteLine(c.Name));
        }
    }
}
