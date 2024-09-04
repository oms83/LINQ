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
            //DemoIEnumerableIQueryable();
            DemoExecutionOrder();
        }

        private static void DemoExecutionOrder()
        {
            // Left to Right (All Expression in C# are executed Left to Right


            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 12, 9 };

            var query = numbers.Where(x =>
            {
                Console.WriteLine($"Where({x} > 5) => {x > 5}");
                return x > 5;
            }).
            Select(x =>
            {
                Console.WriteLine($"\tSelect({x} X {x}) => {x * x}");
                return x * x;
            }).
            Where(x =>
            {
                var result = x % 6 == 0;
                Console.WriteLine($"\t\tWhere({x} % 6) == 0 => {result}");
                if (result)
                {
                    Console.WriteLine($"\t\t\tTake: {x}");
                }

                return x % 6 == 0;
            }).
            Take(2);

            foreach (var item in query)
            {
                Console.WriteLine(query);
            }

            /*
                Where(8 > 5) => True
                        Select(8 X 8) => 64
                                Where(64 % 6) == 0 => False
                Where(2 > 5) => False
                Where(3 > 5) => False
                Where(4 > 5) => False
                Where(1 > 5) => False
                Where(6 > 5) => True
                        Select(6 X 6) => 36
                                Where(36 % 6) == 0 => True
                                        Take: 36
                System.Linq.Enumerable+<TakeIterator>d__25`1[System.Int32]
                Where(5 > 5) => False
                Where(12 > 5) => True
                        Select(12 X 12) => 144
                                Where(144 % 6) == 0 => True
                                        Take: 144
             */
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
