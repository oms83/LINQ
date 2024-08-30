using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Concatenation
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            Example03();
        }
        static void Example04()
        {
            var quiz1 = QuestionBank.Radomize(3);
            var quiz2 = QuestionBank.Radomize(2);

            /*
                ERROR
                var quiz3 = new[] { quiz1, quiz2 };

                quiz3.ToQuiz(); 
            */

            // SelectMany method used here to merge two array
            var quiz3 = new[] { quiz1, quiz2 }.SelectMany(q=>q);

            quiz3.ToQuiz();
        }
        static void Example03()
        {

            var questionsTitle = QuestionBank.Radomize(2).Select(q => q.Title)
                                .Concat(QuestionBank.Radomize(3).Select(q => q.Title))
                                .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(5, 13)).Select(q => q.Title));

            foreach (var item in questionsTitle)
            {
                Console.WriteLine(item);
            }
        }
        static void Example02()
        {
            var quiz1 = QuestionBank.Radomize(3);
            var quiz2 = QuestionBank.Radomize(2);

            var quiz3 = quiz1.Concat(quiz2);

            quiz3.ToQuiz();
        }
        static void Example01()
        {
            var quiz1 = QuestionBank.Radomize(3);
            var quiz2 = QuestionBank.Radomize(2);
            var quiz3 = QuestionBank.Radomize(4);

            var questionsTitle = quiz1.Select(q => q.Title)
                                .Concat(quiz2.Select(q => q.Title))
                                .Concat(quiz3.Select(q => q.Title));

            foreach (var item in questionsTitle)
            {
                Console.WriteLine(item);
            }
        }
    }
}
