using LINQTut04.Shared;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ.Select_Many
{
    internal class Example
    {
        public static void run()
        {
            //runExample01();
            //runExample02();
            runExample03();
        }
        static void runExample03()
        {
            var employees = LINQTut04.Shared.Repository.GetEmployeesInfo();

            var result = (from e in employees
                         from skill in e.Skills
                         select skill).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        static void runExample02()
        {
            var employees = LINQTut04.Shared.Repository.GetEmployeesInfo();

            var result = employees.SelectMany(emp => emp.Skills).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void runExample01()
        {
            string[] sentences =
            {
                "I love asp.net core",
                "I like sql server also.",
                "In general i love programming",
            };

            var result = sentences.SelectMany(s => s.Split(' '));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            /*
                I
                love
                asp.net
                core
                I
                like
                sql
                server
                also.
                In
                general
                i
                love
                programming 
            */
        }
    }
}
