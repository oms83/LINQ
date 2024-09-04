using LINQ.Extension_Method;
using LINQ.Sets_Operations;
using System;
using System.CodeDom.Compiler;
using System.Collections;
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
            //DemoExecutionOrder();
            //DemoImmedaiteExecution();
            //DemoDefferedExecution();
            //DemoDefferedStreamedExecution();
            //DemoDefferedNotStreamedExecution();
            //DemoTake();
            //DemoFilterOrder();
            RunQuery();

        }
        private static void RunQuery()
        {
            var deck = new Deck();

            var cards = deck.GetSample();

            var query = cards      // { Jack Clubs, 9 Diamonds, 4 Hearts, 10 Spades, 3 Hearts, 6 Hearts }
            .Where(x => x.IsRed)   // {             9 Diamonds, 4 Hearts,            3 Hearts, 6 Hearts }
            .Skip(1)               // {                       , 4 Hearts,            3 Hearts, 6 Hearts }
            .OrderBy(x => x.Value) // {                       , 3 Hearts,            4 Hearts, 6 Hearts }
            .Take(2)
            .ToList(); // { 3 Hearts, 4 Hearts }

            query.PrintDeck("Order Buffer Sequence, when it's enumerated");

        }
        private static void DemoFilterOrder()
        {
            // Filter / Order (Top 10 in the Red Cards) 

            var deck = new Deck();

            var cards = deck.Shuffle();

            var query1 = cards
            .Where(x => x.IsRed)
            .OrderBy(x => x.Value)
            .Take(10);

            query1.PrintDeck("top 10 red cards");

            //  Order / Filter   (red cards in the top 10)

            var query2 = cards
            .OrderBy(x => x.Value)
            .Take(10)
            .Where(x => x.IsRed);



            query2.PrintDeck("Red Cards in the top 10");

        }
        private static void DemoTake()
        {
            // Take clause just appends a Take operation to the query;
            // it does not execute the query
            // You must put the Take operation where it needs to be. Remember, 
            // x.Take(y).Where(z) and x.Where(z).Take(y) are very different queries.
            // changing the take location change the meaning of the query
            // put it in the right place as early as possible,
            // but not so early that it changes the meaning of the query

            var deck = new Deck();

            var cards = deck.GetSample();

            var query = cards     // { Jack Clubs, 9 Diamonds, 4 Hearts, 10 Spades, 3 Hearts, 6 Hearts }
            .Where(x => x.IsRed)  // {             9 Diamonds, 4 Hearts,            3 Hearts, 6 Hearts }
            .Skip(3)              // {                                                        6 Hearts }  
            .Take(3);             // {                                                        6 Hearts }

            var list = query.ToList(); // { 6 Hearts }

            list.PrintDeck("Take more than available");

        }
        private static void DemoDefferedNotStreamedExecution()
        {
            //  Deferred Execution(Streaming) :
            //  at the time of execution they do not read all source data
            //  before the yield element
            // Where is not required to find all matching items before fetching the first matching item. 
            // Where fetches matching items "on demand"


            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 12, 9 };

            var query = numbers.Where(x =>
            {
                Console.WriteLine($"Where({x} > 5) => {x > 5}");
                return x > 5;
            }).
            OrderBy(x => x). // not streamed operation => first get all nums greate than 5
            Select(x =>
            {
                Console.WriteLine($"\tSelect({x} X {x}) => {x * x}");
                return x * x;
            }).
            Take(2);

            foreach (var item in query)
            {
                Console.WriteLine(query);
            }
        }

        private static void DemoDefferedStreamedExecution()
        {
            // Deferred Execution(Streaming):
            // at the time of execution they do not read all source data
            // before the yield element
            // Where is not required to find all matching items before fetching the first matching items 
            // Where fetches matching items "on demand"

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

        }

        private static void DemoDefferedExecution()
        {
            // Not executed when constructed, only when it's enumerated
            // Setting up a data structure that describes the query
            // queries are always up - to - date.
            // queries is more expensive that list to retrieve result
            // queries are tiny


            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 12, 9 };
            var query = numbers
                       .Where(x => x > 5)
                       .Select(x => x * x)
                       .Take(2);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        private static void DemoImmedaiteExecution()
        {
            // Immediate: the data is read and the operation is performed
            // at the point in the code where the query is declared.

            // not up to data
            // not expensive to call
            // list are big

            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 12, 9 };
            var list = numbers
                       .Where(x => x > 5)
                       .Take(2)
                       .ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

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
