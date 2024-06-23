using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class clsMain2
    {
        public static void run()
        {
            RunExtensionProcedural();

            Console.ReadKey();
        }

        private static void RunExtensionProcedural()
        {
            var source = clsRepository.LoadEmployeesInfo();

            var q1 = clsExtensionProcedural2.Filter(source, e => e.FirstName.ToLowerInvariant().StartsWith("a"));
            clsExtensionProcedural2.Print(q1, "Employees With First Name Starts With \'a\':");

            var q2 = clsExtensionProcedural2.Filter(source, e => e.FirstName.ToLowerInvariant().EndsWith("a"));
            clsExtensionProcedural2.Print(q2, "Employees With First Name Ends With \'a\':");

            var q3 = clsExtensionProcedural2.Filter(source, e => e.LastName.ToLowerInvariant().StartsWith("h"));
            clsExtensionProcedural2.Print(q3, "Employees With Last Name Starts With \'h\':");

            var q4 = clsExtensionProcedural2.Filter(source, e => e.LastName.ToLowerInvariant().EndsWith("e"));
            clsExtensionProcedural2.Print(q4, "Employees With Last Name Ends With \'e\':");

            var q5 = clsExtensionProcedural2.Filter(source, e => e.HireDate.Year.ToString() == "2020");
            clsExtensionProcedural2.Print(q5, "Employees Hired In Year \'2020\':");

            var q6 = clsExtensionProcedural2.Filter(source, e => e.Gender == "male");
            clsExtensionProcedural2.Print(q6, "Employees With Gender\'male\':");

            var q7 = clsExtensionProcedural2.Filter(source, e => e.Gender == "female");
            clsExtensionProcedural2.Print(q7, "Employees With Gender\'female\':");

            var q8 = clsExtensionProcedural2.Filter(source, e => e.HasPensionPlan == true);
            clsExtensionProcedural2.Print(q8, "Employees With Has Pension Plan Equals To:");

            var q9 = clsExtensionProcedural2.Filter(source, e => e.HasPensionPlan == true);
            clsExtensionProcedural2.Print(q9, "Employees With Has Pension Plan Equals To:");

            var q10 = clsExtensionProcedural2.Filter(source, e => e.HasHealthInsurance == true);
            clsExtensionProcedural2.Print(q10, "Employees With Health Insurance Equals To:");

            var q11 = clsExtensionProcedural2.Filter(source, e => e.HasHealthInsurance == false);
            clsExtensionProcedural2.Print(q11, "Employees With Health Insurance Equals To:");

        }
    }
}
