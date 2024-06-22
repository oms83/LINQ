using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class clsExtensionProcedural
    {
        public static IEnumerable<clsEmployee> GetEmployeesWithFirstNameStartsWith(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<clsEmployee> GetEmployeesWithFirstNameEndsWith(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.FirstName.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<clsEmployee> GetEmployeesWithLastNameStartsWith(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.LastName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<clsEmployee> GetEmployeesWithLastNameEndsWith(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.LastName.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<clsEmployee> GetEmployeesHiredInYear(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.HireDate.Year.ToString() == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<clsEmployee> GetEmployeesWithDepartmentEqualTo(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.Department == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<clsEmployee> GetEmployeesWithGender(string value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.Gender == value)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<clsEmployee> GetEmployeesWithHealthInsuranceEqualsTo(bool value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.HasHealthInsurance == value)
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<clsEmployee> GetEmployeesWithHasPensionPlanEqualsTo(bool value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.HasPensionPlan == value)
                {
                    yield return employee;
                }
            }
        }

        [ObsoleteAttribute("This old way of return data")]
        public static IEnumerable<clsEmployee> GetEmployeesWithHasPensionPlanEqualsTo2(bool value)
        {
            var employees = clsRepository.LoadEmployeesInfo();

            foreach (var employee in employees)
            {
                if (employee.HasPensionPlan == value)
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("\t\t\t______________________________________________________________");
            Console.WriteLine($"{title.PadLeft(75, ' ')}");
            Console.WriteLine("\t\t\t______________________________________________________________");

            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
