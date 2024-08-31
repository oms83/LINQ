using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Aggregate_Operations
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            //Example03();
            //Example04();
            //Example05();
            Example06();
        }

        private static void Example06()
        {
            var questions = Concatenation.QuestionBank.All;
            
            var x = questions.SelectMany(q => q.Choices)
                             .Where(c => c.Order == 1)
                             .Max(c => c.Descirption.Length);

            
            Console.WriteLine(x);
        }

        private static void Example05()
        {
            var questions = Concatenation.QuestionBank.All;

            Console.WriteLine($"questions count: {questions.Count}");
            Console.WriteLine($"questions count: {questions.Count()}");
            Console.WriteLine($"questions count: {questions.Count(q => q.Title.Length > 40)}");
            Console.WriteLine($"questions count: {questions.Where(q => q.Title.Length > 40).Count()}");
        }

        private static void Example04()
        {
            var questions = Concatenation.QuestionBank.All;

            var longestQuestionTitle = questions[0];

            var title = questions
                            .Aggregate(
                            longestQuestionTitle, // seed
                            (longest, next) => longest.Title.Length < next.Title.Length ? next : longest, // logic
                            x => x // select result and return its
                            );

            Console.WriteLine(title);
        }

        private static void Example03()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };

            var result = nums.Aggregate(0, (sum, i) => sum + i);
            Console.WriteLine(result); // 15

            var result2 = nums.Aggregate(2, (sum, i) =>
            {
                Console.WriteLine(sum);
                sum += i;
                return sum;
            });

            Console.WriteLine(result2); // 17 seed starts from 2
        }

        private static void Example02()
        {
            var names = new[] { "omer", "ali", "osman", "yusuf", "musa" };

            //********************************
            var _result = string.Empty;

            foreach (var iter in names)
            {
                _result += iter + ", ";
            }
            //********************************

            var output = names.Aggregate((result, iter) => result += iter + ", ");

            Console.WriteLine(output);
        }

        private static void Example01()
        {
            var names = new[] { "omer", "ali", "osman", "yusuf", "musa" };

            var namesWithSeperater = string.Join(", ", names);
            Console.WriteLine(namesWithSeperater);
        }
    }
}
