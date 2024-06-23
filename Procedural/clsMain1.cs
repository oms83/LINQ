using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class clsMain1
    {
        public static void run()
        {
            RunExtensionProcedural();

            Console.ReadKey();
        }

        private static void RunExtensionProcedural()
        {
            var q1 = clsExtensionProcedural.GetEmployeesWithFirstNameStartsWith("a");
            clsExtensionProcedural.Print(q1, "Employees With First Name Starts With \'a\':");

            var q2 = clsExtensionProcedural.GetEmployeesWithFirstNameEndsWith("a");
            clsExtensionProcedural.Print(q2, "Employees With First Name Ends With \'a\':");

            var q3 = clsExtensionProcedural.GetEmployeesWithLastNameStartsWith("h");
            clsExtensionProcedural.Print(q3, "Employees With Last Name Starts With \'h\':");

            var q4 = clsExtensionProcedural.GetEmployeesWithLastNameEndsWith("e");
            clsExtensionProcedural.Print(q4, "Employees With Last Name Ends With \'e\':");

            var q5 = clsExtensionProcedural.GetEmployeesHiredInYear("2020");
            clsExtensionProcedural.Print(q5, "Employees Hired In Year \'2020\':");

            var q6 = clsExtensionProcedural.GetEmployeesWithGender("male");
            clsExtensionProcedural.Print(q6, "Employees With Gender\'male\':");

            var q7 = clsExtensionProcedural.GetEmployeesWithGender("female");
            clsExtensionProcedural.Print(q7, "Employees With Gender\'female\':");

            var q8 = clsExtensionProcedural.GetEmployeesWithHasPensionPlanEqualsTo(true);
            clsExtensionProcedural.Print(q8, "Employees With Has Pension Plan Equals To:");

            var q9 = clsExtensionProcedural.GetEmployeesWithHasPensionPlanEqualsTo(false);
            clsExtensionProcedural.Print(q9, "Employees With Has Pension Plan Equals To:");

            var q10 = clsExtensionProcedural.GetEmployeesWithHealthInsuranceEqualsTo(false);
            clsExtensionProcedural.Print(q10, "Employees With Health Insurance Equals To:");

            var q11 = clsExtensionProcedural.GetEmployeesWithHealthInsuranceEqualsTo(true);
            clsExtensionProcedural.Print(q11, "Employees With Health Insurance Equals To:");

        }
    }
}
