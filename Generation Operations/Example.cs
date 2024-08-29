using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generation_Operations
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            Example03();
        }
        static void Example03()
        {
            // repeat operation

            var question = QuestionBank.PickOne();
            Console.WriteLine(question);

            var questions = Enumerable.Repeat(question, 10);
            questions.ToQuiz();

        }
        static void Example02()
        {
            // range operation

            var range = Enumerable.Range(0, 10);


            var questions = QuestionBank.GetQuestionRange(range);

            questions.ToQuiz();
        }
        static void Example01()
        {
            //var questions = new List<Question>();    // empty list

            // 1
            // ....
            // 1000


            /*
                Deferred Execution:
                Definition: The query is not executed when it is defined, but rather when it is iterated over 
                (e.g., using foreach or .ToList()).
                Example: Methods like Select, Where, and GroupBy.
                Benefit: Allows for building complex queries and efficient use of resources since the data is only processed when needed.


                Immediate Execution:
                Definition: The query is executed at the point it is defined.
                Example: Methods like ToList(), Count(), and First().
                Benefit: Useful when you need to execute a query and store the result immediately. 
            */

            var questions = Enumerable.Empty<Question>();

            var questions2 = questions.DefaultIfEmpty(Question.Default);

            questions2.ToQuiz();
        }

    }
}
