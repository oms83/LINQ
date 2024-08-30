using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Equality_Operations
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

            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4));
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4)); 

            var equal = quiz1.SequenceEqual(quiz2); // true

            Console.WriteLine(equal);

            Console.WriteLine(quiz1 == quiz2); // false 

        }
        static void Example02()
        {
            var  randomQuestion = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4));

            var quiz1 = randomQuestion;
            var quiz2 = randomQuestion;

            var equal = quiz1.SequenceEqual(quiz2); // true

            Console.WriteLine(equal);

            Console.WriteLine(quiz1 == quiz2); // true 

        }
        static void Example01()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var quiz1 = new List<Question>(new Question[] { q1, q2, q3 });
            var quiz2 = new List<Question>(new Question[] { q1, q2, q3 });

            var equal = quiz1.SequenceEqual(quiz2); // true

            Console.WriteLine(equal);

            Console.WriteLine(quiz1 == quiz2); // false 

        }


    }
}
