using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Join_Operation
{
    public class Example
    {
        public static void run()
        {
            //runJoin();

            runJoinQuerySyntax();
        }
        static void runJoinQuerySyntax()
        {
            var employees = Repository.GetEmployeesInfo();
            var departments = Repository.GetDepartmentInfo();

            var result = from employee in employees
                         join department in departments
                         on employee.DepartmentID equals department.Id
                         select new EmployeeDto()
                         {
                             FullName = employee.FirstName + " " + employee.LastName,
                             Depatment = department.Name,
                         };


            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.FullName,-15} {employee.Depatment}");
            }

        }
        static void runJoin()
        {
            var employees = Repository.GetEmployeesInfo();
            var departments = Repository.GetDepartmentInfo();

            var result = employees.Join(
                departments,
                emp => emp.DepartmentID,
                dept => dept.Id,
                (emp, dept) => new EmployeeDto()
                {
                    FullName = emp.FirstName + " " + emp.LastName,
                    Depatment = dept.Name,
                });

            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.FullName, -15} {employee.Depatment}");
            }

            /*
             
                Omer MEMES      Software Engineering
                Fatma KAYA      Human Resources
                Ahmet YILMAZ    Software Engineering
                Ayse DEMIR      Sales
                Ali CAN         Marketing
                Merve GUL       Software Engineering
                Hakan OZTURK    Sales
                Zeynep KARACA   Human Resources
                Burak YAVUZ     Marketing
                Deniz AKIN      Software Engineering
                Bora EROL       Sales
                Ece DEMIR       Human Resources
                Okan KAYA       Marketing
                Aylin KARA      Software Engineering
                Cem YILMAZ      Sales
                Asli KOC        Marketing
                Selim CAN       Human Resources
                Banu AKSOY      Software Engineering
                Tugce GUL       Sales
                Kerem KURT      Marketing
 
            */
        }
    }
}
