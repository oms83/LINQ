using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data_Partitioning
{
    public class Employee
    {
        public int Index { get; set; } // New Index field
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            return
                $"{Index, -1}\t" +
                $"{EmployeeNo.PadRight(13, ' ')}\t" +
                $"{Name.PadRight(20, ' ')}\t" +
                $"{Email.PadRight(23, ' ')} \t" +
                $"{String.Format("{0:C0}", Salary)}   " +
                $"[{String.Join(", ", Skills)}]";
        }
    }

}
