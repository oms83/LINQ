using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Quantifiers
{
    public class Employee
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();

        public override string ToString()
        {
            return
                $"{EmployeeNo.PadRight(13, ' ')}\t" +
                $"{Name.PadRight(20, ' ')}\t" +
                $"{Email.PadRight(23, ' ')} \t" +
                $"{String.Format("{0:C0}", Salary)}   " +
                $"[{String.Join(", ", Skills)}]";
        }
    }
}
