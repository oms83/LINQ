using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generation_Operations.Element_Operation
{
    public class clsFirst
    {
        public static void run()
        {
            //Example01();
            //Example02();
            Example03();
        }

        static void Example01()
        {
            var questions = QuestionBank.All;

            var question1 = questions.First();

            Console.WriteLine(question1);

            //var question2 = questions.First(q => q.Title.Length == 0); // Invalid Operation Exception
            var question3 = questions.FirstOrDefault(q => q.Title.Length == 0);
            Console.WriteLine(question3);

        }
        static void Example02()
        {
            var questions = QuestionBank.All;

            var question1 = questions.Last();

            Console.WriteLine(question1);

            //var question2 = questions.Last(q => q.Title.Length == 0); // Invalid Operation Exception
            var question3 = questions.LastOrDefault(q => q.Title.Length == 0);
            Console.WriteLine(question3);
        }

        static void Example03()
        {
            var questions = QuestionBank.All;

            // with single operation the result should not repeat
            
            //var question1 = questions.Single(q => q.Title.Contains("Q #20")); // Invalid Operation Exception 
            //var question2 = questions.SingleOrDefault(q => q.Title.Contains("Q #20")); // Invalid Operation Exception

            //var question3 = questions.Single(q => q.Title.Contains("Q #200")); // Invalid Operation Exception
            var question4 = questions.SingleOrDefault(q => q.Title.Contains("Q #200"));
            Console.WriteLine(question4 == null ? Question.Default : question4);

            /*
                <<<<<<<<<<<<<<< Question Title Goes Here >>>>>>>>>>>>>>>
                        1)  <<<<<<<< Choice #1 Goes Here >>>>>>>>
                        2)  <<<<<<<< Choice #1 Goes Here >>>>>>>>
                        3)  <<<<<<<< Choice #1 Goes Here >>>>>>>>
                        4)  <<<<<<<< Choice #1 Goes Here >>>>>>>>
                        5)  <<<<<<<< Choice #1 Goes Here >>>>>>>> 
            */
        }
    }
}
