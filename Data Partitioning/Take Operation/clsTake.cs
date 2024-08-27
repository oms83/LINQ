using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data_Partitioning.Take_Operation
{
    public class clsTake
    {
        public static void run()
        {
            //RunTakeMethod();
            RunTakeWhile();
        }
        static void RunTakeWhile()
        {
            var emps = Repository.GetEmployeeInfo();

            var items = emps.TakeWhile(emp => emp.Salary == 4000m);
            
            items.Print("Take employees whose salary is less than 4000");

       
        }
        static void RunTakeMethod()
        {
            var emps = Repository.GetEmployeeInfo();

            var items = emps.Take(10);

            items.Print("Take First 10 Employees");

            //1       2020 - FI - 1111    Omer MEMES              oms @gmail.com                   $4,000[C, C++, C#]
        }
    }
}
