using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Grouping
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
                $"{Id}\t" +
                $"{FirstName} {LastName}\t" +
                $"{Gender}\t" +
                $"{Department}\t" +
                $"{HireDate.ToString("yyyy:MM:dd")}\t" +
                $"{Salary}\t" +
                $"{HasHealthInsurance}\t" +
                $"{HasPensionPlan}\t";
        }
    }
}
