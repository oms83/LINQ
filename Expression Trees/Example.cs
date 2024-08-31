using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Expression_Trees
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            Example03();
        }
        private static void Example03()
        {
            // (num)=>num%2==0


            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression zeroParam = Expression.Constant(0);
            ConstantExpression twoParam = Expression.Constant(2);
            BinaryExpression moduloBinaryExperssion = BinaryExpression.Modulo(numParam, twoParam);
            BinaryExpression isEventExpression = BinaryExpression.Equal(moduloBinaryExperssion, zeroParam);

            Expression<Func<int, bool>> IsEvenExpression = Expression.Lambda<Func<int, bool>>
                                                            (isEventExpression, 
                                                             new ParameterExpression[] { numParam});
            Func<int, bool> IsEven = IsEvenExpression.Compile();

            Console.WriteLine(IsEven(43));

        }
        private static void Example02()
        {
            Expression<Func<int, bool>> isNegativeExpression = (num) => num < 0;

            ParameterExpression numParam = isNegativeExpression.Parameters[0];
            BinaryExpression operation = (BinaryExpression)isNegativeExpression.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            //num => num LessThan 0
            Console.WriteLine($"{numParam.Name} => {left.Name} {operation.NodeType} {right.Value}");
        }
        private static void Example01()
        {
            Func<int, bool> IsEven = n => n % 2 == 0;

            Console.WriteLine(IsEven(23));
            Console.WriteLine(IsEven.Invoke(23));

            Expression<Func<int, bool>> expressionIsEven = n => n % 2 == 0;

            Func<int, bool> _IsEven = expressionIsEven.Compile();

            Console.WriteLine(_IsEven(44));
        }
    }
}
