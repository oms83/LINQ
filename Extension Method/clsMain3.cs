using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Extension_Method
{
    public class clsMain3
    {
        public static void run()
        {
            RunExtensionProcedural();

            Console.ReadKey();
        }

        private static void RunExtensionProcedural()
        {
            var source = clsRepository.LoadEmployeesInfo();

            var q1 = source.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("a"));
            clsExtensionProcedural3.Print(q1, "Employees With First Name Starts With \'a\':");

            var q2 = source.Filter(e => e.FirstName.ToLowerInvariant().EndsWith("a"));
            clsExtensionProcedural3.Print(q2, "Employees With First Name Ends With \'a\':");

            var q3 = source.Filter(e => e.LastName.ToLowerInvariant().StartsWith("h"));
            clsExtensionProcedural3.Print(q3, "Employees With Last Name Starts With \'h\':");

            var q4 = source.Filter(e => e.LastName.ToLowerInvariant().EndsWith("e"));
            clsExtensionProcedural3.Print(q4, "Employees With Last Name Ends With \'e\':");

            var q5 = source.Filter(e => e.HireDate.Year.ToString() == "2020");
            clsExtensionProcedural3.Print(q5, "Employees Hired In Year \'2020\':");

            var q6 = source.Filter(e => e.Gender == "male");
            clsExtensionProcedural3.Print(q6, "Employees With Gender\'male\':");

            var q7 = source.Filter(e => e.Gender == "female");
            clsExtensionProcedural3.Print(q7, "Employees With Gender\'female\':");

            var q8 = source.Filter(e => e.HasPensionPlan == true);
            clsExtensionProcedural3.Print(q8, "Employees With Has Pension Plan Equals To:");

            var q9 = source.Filter(e => e.HasPensionPlan == true);
            clsExtensionProcedural3.Print(q9, "Employees With Has Pension Plan Equals To:");

            var q10 = source.Filter(e => e.HasHealthInsurance == true);
            clsExtensionProcedural3.Print(q10, "Employees With Health Insurance Equals To:");

            var q11 = source.Filter(e => e.HasHealthInsurance == false);
            clsExtensionProcedural3.Print(q11, "Employees With Health Insurance Equals To:");

        }
    }
}
