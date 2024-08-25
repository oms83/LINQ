using LINQTut04.SELECT;
using LINQTut04.Shared;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ.SelectOperation
{
    internal class SelectOperation
    {
        public static void run()
        {
            //RunExample01();
            //RunExample02();
            RunExample03();
        }
        static void RunExample01()
        {
            // we can apply linq on the array
            //string[] words01 = { "i", "love", "asp.net", "core" };

            List<string> words02 = new List<string>() { "i", "love", "asp.net", "core" };

            //var result = words02.Select(x => { return x.ToUpper(); });

            var result = words02.Select(x => x.ToUpper());

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            var result2 = from word in words02
                          select word.ToUpper();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

        }


        static void RunExample02()
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //var result = words02.Select(x => { return x.ToUpper(); });

            var result = numbers.Select(x => x * x);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            var result2 = from number in numbers
                          select number * number;

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

        }

        static void RunExample03()
        {
            var employees = Repository.GetEmployeesInfo();

            var result = employees.Select(emp =>
            {
                return new EmployeeDto()
                {
                    Name = emp.FullName,
                    TotalSkills = emp.Skills.Count(),

                };
            }).ToList();

            result.ForEach(x => Console.WriteLine(x));
        }
    }
}
