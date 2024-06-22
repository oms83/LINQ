using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class clsRepository
    {
        public static IEnumerable<clsEmployee> LoadEmployeesInfo()
        {
            return new List<clsEmployee>
            {
                new clsEmployee { Id = 1001, FirstName = "John", LastName = "Doe", HireDate = new DateTime(2016, 8, 17), Gender = "male", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 60000m },
                new clsEmployee { Id = 1002, FirstName = "Jane", LastName = "Smith", HireDate = new DateTime(2017, 6, 12), Gender = "female", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 75000m },
                new clsEmployee { Id = 1003, FirstName = "Sam", LastName = "Brown", HireDate = new DateTime(2018, 1, 25), Gender = "male", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 55000m },
                new clsEmployee { Id = 1004, FirstName = "Hester", LastName = "Evans", HireDate = new DateTime(2016, 8, 17), Gender = "male", Department = "FIMAMCE", HasHealthInsurance = true, HasPensionPlan = true, Salary = 155500m },
                new clsEmployee { Id = 1005, FirstName = "Emily", LastName = "Clark", HireDate = new DateTime(2019, 3, 14), Gender = "female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 67000m },
                new clsEmployee { Id = 1006, FirstName = "Michael", LastName = "Johnson", HireDate = new DateTime(2015, 11, 30), Gender = "male", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 72000m },
                new clsEmployee { Id = 1007, FirstName = "Sarah", LastName = "Lee", HireDate = new DateTime(2020, 7, 19), Gender = "female", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 58000m },
                new clsEmployee { Id = 1008, FirstName = "James", LastName = "White", HireDate = new DateTime(2018, 9, 8), Gender = "male", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 80000m },
                new clsEmployee { Id = 1009, FirstName = "Anna", LastName = "Walker", HireDate = new DateTime(2016, 12, 4), Gender = "female", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 59000m },
                new clsEmployee { Id = 1010, FirstName = "David", LastName = "Harris", HireDate = new DateTime(2017, 2, 20), Gender = "male", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 68000m },
                new clsEmployee { Id = 1011, FirstName = "Olivia", LastName = "Adams", HireDate = new DateTime(2018, 4, 5), Gender = "female", Department = "Sales", HasHealthInsurance = false, HasPensionPlan = false, Salary = 71000m },
                new clsEmployee { Id = 1012, FirstName = "Benjamin", LastName = "Nelson", HireDate = new DateTime(2016, 6, 23), Gender = "male", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 60500m },
                new clsEmployee { Id = 1013, FirstName = "Sophia", LastName = "Carter", HireDate = new DateTime(2019, 8, 10), Gender = "female", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 78000m },
                new clsEmployee { Id = 1014, FirstName = "Matthew", LastName = "Mitchell", HireDate = new DateTime(2020, 5, 14), Gender = "male", Department = "HR", HasHealthInsurance = true, HasPensionPlan = false, Salary = 56000m },
                new clsEmployee { Id = 1015, FirstName = "Isabella", LastName = "Perez", HireDate = new DateTime(2015, 3, 22), Gender = "female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 67000m },
                new clsEmployee { Id = 1016, FirstName = "Alexander", LastName = "Roberts", HireDate = new DateTime(2016, 10, 3), Gender = "male", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 72000m },
                new clsEmployee { Id = 1017, FirstName = "Charlotte", LastName = "Turner", HireDate = new DateTime(2017, 11, 17), Gender = "female", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 58500m },
                new clsEmployee { Id = 1018, FirstName = "Daniel", LastName = "Phillips", HireDate = new DateTime(2018, 12, 6), Gender = "male", Department = "IT", HasHealthInsurance = false, HasPensionPlan = false, Salary = 81000m },
                new clsEmployee { Id = 1019, FirstName = "Mia", LastName = "Campbell", HireDate = new DateTime(2019, 1, 27), Gender = "female", Department = "HR", HasHealthInsurance = false, HasPensionPlan = true, Salary = 57500m },
                new clsEmployee { Id = 1020, FirstName = "Henry", LastName = "Parker", HireDate = new DateTime(2020, 2, 18), Gender = "male", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 69000m },
                new clsEmployee { Id = 1021, FirstName = "Amelia", LastName = "Evans", HireDate = new DateTime(2021, 5, 9), Gender = "female", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 72000m },
                new clsEmployee { Id = 1022, FirstName = "Ethan", LastName = "Collins", HireDate = new DateTime(2022, 8, 29), Gender = "male", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 61500m },
                new clsEmployee { Id = 1023, FirstName = "Lily", LastName = "Stewart", HireDate = new DateTime(2015, 9, 14), Gender = "female", Department = "IT", HasHealthInsurance = false, HasPensionPlan = true, Salary = 79000m },
                new clsEmployee { Id = 1024, FirstName = "Jack", LastName = "Sanchez", HireDate = new DateTime(2016, 11, 2), Gender = "male", Department = "HR", HasHealthInsurance = false, HasPensionPlan = false, Salary = 57000m },
                new clsEmployee { Id = 1025, FirstName = "Grace", LastName = "Morris", HireDate = new DateTime(2017, 4, 19), Gender = "female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 68000m },
                new clsEmployee { Id = 1026, FirstName = "Lucas", LastName = "Rogers", HireDate = new DateTime(2018, 6, 30), Gender = "male", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 73000m },
                new clsEmployee { Id = 1027, FirstName = "Chloe", LastName = "Reed", HireDate = new DateTime(2019, 10, 11), Gender = "female", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 59500m },
                new clsEmployee { Id = 1028, FirstName = "Mason", LastName = "Cook", HireDate = new DateTime(2020, 11, 23), Gender = "male", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 82000m },
                new clsEmployee { Id = 1029, FirstName = "Zoe", LastName = "Morgan", HireDate = new DateTime(2021, 1, 15), Gender = "female", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 58000m },
                new clsEmployee { Id = 1030, FirstName = "Aiden", LastName = "Bell", HireDate = new DateTime(2022, 3, 7), Gender = "male", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = false, Salary = 70000m },
                new clsEmployee { Id = 1031, FirstName = "Natalie", LastName = "Murphy", HireDate = new DateTime(2015, 5, 22), Gender = "female", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 73000m },
                new clsEmployee { Id = 1032, FirstName = "Elijah", LastName = "Bailey", HireDate = new DateTime(2016, 6, 16), Gender = "male", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 62500m },
                new clsEmployee { Id = 1033, FirstName = "Ella", LastName = "Rivera", HireDate = new DateTime(2017, 8, 8), Gender = "female", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 80000m },
                new clsEmployee { Id = 1034, FirstName = "Oliver", LastName = "Cooper", HireDate = new DateTime(2018, 12, 29), Gender = "male", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 57000m },
                new clsEmployee { Id = 1035, FirstName = "Ava", LastName = "Richardson", HireDate = new DateTime(2019, 4, 11), Gender = "female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 69000m },
                new clsEmployee { Id = 1036, FirstName = "William", LastName = "Cox", HireDate = new DateTime(2020, 7, 2), Gender = "male", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = false, Salary = 74000m },
                new clsEmployee { Id = 1037, FirstName = "Madison", LastName = "Howard", HireDate = new DateTime(2021, 9, 22), Gender = "female", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 60500m },
                new clsEmployee { Id = 1038, FirstName = "Noah", LastName = "Ward", HireDate = new DateTime(2022, 11, 18), Gender = "male", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 83000m },
                new clsEmployee { Id = 1039, FirstName = "Lily", LastName = "Torres", HireDate = new DateTime(2015, 2, 27), Gender = "female", Department = "HR", HasHealthInsurance = false, HasPensionPlan = false, Salary = 58000m },
                new clsEmployee { Id = 1040, FirstName = "Jackson", LastName = "Peterson", HireDate = new DateTime(2016, 5, 6), Gender = "male", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 71000m },
                new clsEmployee { Id = 1041, FirstName = "Mila", LastName = "Gray", HireDate = new DateTime(2017, 6, 25), Gender = "female", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 75000m },
                new clsEmployee { Id = 1042, FirstName = "Carter", LastName = "Ramirez", HireDate = new DateTime(2018, 8, 19), Gender = "male", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 61500m },
                new clsEmployee { Id = 1043, FirstName = "Scarlett", LastName = "James", HireDate = new DateTime(2019, 9, 14), Gender = "female", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 79000m },
                new clsEmployee { Id = 1044, FirstName = "Ryan", LastName = "Hughes", HireDate = new DateTime(2020, 10, 5), Gender = "male", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 58000m },
                new clsEmployee { Id = 1045, FirstName = "Leah", LastName = "Bennett", HireDate = new DateTime(2021, 12, 30), Gender = "female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 70000m },
                new clsEmployee { Id = 1046, FirstName = "Dylan", LastName = "Foster", HireDate = new DateTime(2015, 1, 10), Gender = "male", Department = "Sales", HasHealthInsurance = true, HasPensionPlan = true, Salary = 73000m },
                new clsEmployee { Id = 1047, FirstName = "Evelyn", LastName = "Perry", HireDate = new DateTime(2016, 3, 1), Gender = "female", Department = "Finance", HasHealthInsurance = true, HasPensionPlan = true, Salary = 62500m },
                new clsEmployee { Id = 1048, FirstName = "Isaac", LastName = "Long", HireDate = new DateTime(2017, 8, 20), Gender = "male", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 81000m },
                new clsEmployee { Id = 1049, FirstName = "Sofia", LastName = "Russell", HireDate = new DateTime(2018, 12, 9), Gender = "female", Department = "HR", HasHealthInsurance = true, HasPensionPlan = true, Salary = 59000m },
                new clsEmployee { Id = 1050, FirstName = "Nathan", LastName = "Hamilton", HireDate = new DateTime(2019, 4, 13), Gender = "male", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 69000m }
            };

        }
    }
}
