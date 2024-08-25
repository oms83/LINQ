using LINQ.Extension_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class EmpsExample1
    {
        public static void run()
        {
            var employees = clsRepository.LoadEmployeesInfo();

            var empMale = employees.Where(emp => emp.Gender == "male");

            empMale.Print("Male Employees");


            //-----------------------------------------------------------------------

            var empFamle = from emp in employees
                           where emp.Gender == "female"
                           select emp;

            empMale.Print("Female Employees");


            //-----------------------------------------------------------------------
            
            var empSalaryGreateThan300300 = from emp in employees
                                            where emp.Salary >= 30_00
                                            select emp;
            empSalaryGreateThan300300.Print("Salary Greate Than 3000");

            //-----------------------------------------------------------------------


            var empMaleSalaryFilter = from emp in employees
                                      where emp.Gender == "male" 
                                      && emp.Salary >= 30_000
                                      select emp;
            empMaleSalaryFilter.Print("employees");

            
            //-----------------------------------------------------------------------

            var empMaleSalaryFilter2 = from emp in empMale
                                       where emp.Salary >= 30_000
                                       select emp;
            empMaleSalaryFilter.Print("employees");


        }
    }
}
