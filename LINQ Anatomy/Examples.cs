using LINQ.Extension_Method;
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
            //DemoFluentAPI();
            DemoIEnumerableIQueryable();
        }
        private static void DemoIEnumerableIQueryable()
        {
            // LINQ to Objects
            // which mostly just does literally what it is told;
            // if you sort then pages, then it sorts then pages;
            // if you page then sort, then it pages then sorts;

            var deck = new Deck();

            var queryIEnumerable = deck.Shuffle()
                .Where(x => x.Value < 5).Skip(5).OrderBy(x => x.Value)
                .ThenByDescending(x => x.Suite).Take(5).AsEnumerable();

         

            // i.e LINQ to SQL
            // Query is begin composed (Experssion Tree).
            // When Execute Provider inspect your query tree.
            // build the most suitable implementation possoble. 

            var queryIQueryable = deck.Shuffle()
               .Where(x => x.Value < 5).Skip(5).OrderBy(x => x.Value)
               .ThenByDescending(x => x.Suite).Take(5).AsQueryable();


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
