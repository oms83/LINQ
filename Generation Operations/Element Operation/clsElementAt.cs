using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generation_Operations.Element_Operation
{
    public class clsElementAt
    {
        public static void run()
        {
            Example01();
        }
        static void Example01()
        {
            var questions = QuestionBank.All;
            var questionAt1 = questions.ElementAt(10); // -> 11. question
            Console.WriteLine(questionAt1);

            //var questionAt2 = questions.ElementAt(QuestionBank.All.Count + 1); // argument out of range exception 

            var questionAt3 = questions.ElementAtOrDefault(QuestionBank.All.Count + 1);

            if (questionAt3 == null)
            {
                questionAt3 = Question.Default;
                Console.WriteLine("NULL");
                Console.WriteLine(questionAt3);
            }
            else
            {
                Console.WriteLine(questionAt3);
            }

        }
    }
}
