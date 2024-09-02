using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Custom_LINQ_Extension_Method
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasPensionPlan { get; set; }

        public override string ToString()
        {
            return $"" +
                $"{Id}\t\t" +
                $"{FirstName} {LastName}\t\t" +
                $"{Gender}\t\t" +
                $"{Department}\t\t" +
                $"{HireDate.ToString("yyyy:MM:dd")}\t\t" +
                $"{Salary}\t" +
                $"{HasHealthInsurance}\t\t" +
                $"{HasPensionPlan}\t";
        }
    }
}
