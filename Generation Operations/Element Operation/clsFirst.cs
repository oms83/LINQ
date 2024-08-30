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
            Example02();
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
    }
}
