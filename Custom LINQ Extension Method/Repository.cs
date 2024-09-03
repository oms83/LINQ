using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Custom_LINQ_Extension_Method
{
    public static class Repository
    {
        public static IEnumerable<Employee> GetEmployeesInfo()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Omer",
                    LastName = "MEMES",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2020, 8, 3),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Ahmet",
                    LastName = "YILMAZ",
                    Gender = "Male",
                    Department = "Data Scientist",
                    Salary = 26000m,
                    HireDate = new DateTime(2019, 5, 15),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Fatma",
                    LastName = "KAYA",
                    Gender = "Female",
                    Department = "Product Manager",
                    Salary = 28000m,
                    HireDate = new DateTime(2018, 2, 10),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Mehmet",
                    LastName = "DEMIR",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 25000m,
                    HireDate = new DateTime(2021, 1, 20),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 5,
                    FirstName = "Ayse",
                    LastName = "OZKAN",
                    Gender = "Female",
                    Department = "QA Engineer",
                    Salary = 23000m,
                    HireDate = new DateTime(2020, 6, 11),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 6,
                    FirstName = "Ali",
                    LastName = "CELIK",
                    Gender = "Male",
                    Department = "HR Manager",
                    Salary = 24000m,
                    HireDate = new DateTime(2017, 9, 5),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 7,
                    FirstName = "Merve",
                    LastName = "KURT",
                    Gender = "Female",
                    Department = "Marketing Specialist",
                    Salary = 22000m,
                    HireDate = new DateTime(2019, 11, 18),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 8,
                    FirstName = "Hakan",
                    LastName = "YAVUZ",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2018, 4, 12),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 9,
                    FirstName = "Zeynep",
                    LastName = "KARACA",
                    Gender = "Female",
                    Department = "Sales Manager",
                    Salary = 26000m,
                    HireDate = new DateTime(2017, 3, 25),
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 10,
                    FirstName = "Burak",
                    LastName = "GUL",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 25000m,
                    HireDate = new DateTime(2020, 7, 9),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 11,
                    FirstName = "Deniz",
                    LastName = "SARAC",
                    Gender = "Female",
                    Department = "Software Engineer",
                    Salary = 27000m,
                    HireDate = new DateTime(2019, 1, 30),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 12,
                    FirstName = "Bora",
                    LastName = "CAN",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2021, 5, 7),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 13,
                    FirstName = "Ece",
                    LastName = "AYDIN",
                    Gender = "Female",
                    Department = "Software Engineer",
                    Salary = 28000m,
                    HireDate = new DateTime(2018, 6, 20),
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 14,
                    FirstName = "Okan",
                    LastName = "EROL",
                    Gender = "Male",
                    Department = "Data Engineer",
                    Salary = 25000m,
                    HireDate = new DateTime(2017, 12, 3),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 15,
                    FirstName = "Aylin",
                    LastName = "KARACA",
                    Gender = "Female",
                    Department = "Content Writer",
                    Salary = 22000m,
                    HireDate = new DateTime(2020, 3, 22),
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 16,
                    FirstName = "Cem",
                    LastName = "OZTURK",
                    Gender = "Male",
                    Department = "Software Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2019, 8, 15),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 17,
                    FirstName = "Asli",
                    LastName = "YILMAZ",
                    Gender = "Female",
                    Department = "Content Writer",
                    Salary = 23000m,
                    HireDate = new DateTime(2021, 2, 17),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 18,
                    FirstName = "Selim",
                    LastName = "KAYA",
                    Gender = "Male",
                    Department = "Content Writer",
                    Salary = 24000m,
                    HireDate = new DateTime(2018, 10, 25),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 19,
                    FirstName = "Banu",
                    LastName = "CAN",
                    Gender = "Female",
                    Department = "Customer Support",
                    Salary = 22000m,
                    HireDate = new DateTime(2017, 5, 13),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 20,
                    FirstName = "Tugce",
                    LastName = "YILDIRIM",
                    Gender = "Female",
                    Department = "Customer Support",
                    Salary = 24000m,
                    HireDate = new DateTime(2019, 6, 29),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 21,
                    FirstName = "Kerem",
                    LastName = "DEMIR",
                    Gender = "Male",
                    Department = "Mobile Developer",
                    Salary = 26000m,
                    HireDate = new DateTime(2020, 8, 7),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 22,
                    FirstName = "Emre",
                    LastName = "AKSOY",
                    Gender = "Male",
                    Department = "Mobile Developer",
                    Salary = 27000m,
                    HireDate = new DateTime(2018, 1, 12),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 23,
                    FirstName = "Pelin",
                    LastName = "OZTURK",
                    Gender = "Female",
                    Department = "Mobile Developer",
                    Salary = 25000m,
                    HireDate = new DateTime(2019, 4, 14),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 24,
                    FirstName = "Volkan",
                    LastName = "GULER",
                    Gender = "Male",
                    Department = "Network Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2020, 11, 6),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 24,
                    FirstName = "Volkan",
                    LastName = "GULER",
                    Gender = "Male",
                    Department = "Network Engineer",
                    Salary = 24000m,
                    HireDate = new DateTime(2020, 11, 6),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 25,
                    FirstName = "Asya",
                    LastName = "BAYRAK",
                    Gender = "Female",
                    Department = "Product Designer",
                    Salary = 25000m,
                    HireDate = new DateTime(2018, 12, 15),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 26,
                    FirstName = "Deniz",
                    LastName = "KOC",
                    Gender = "Female",
                    Department = "Product Designer",
                    Salary = 27000m,
                    HireDate = new DateTime(2021, 1, 25),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 27,
                    FirstName = "Onur",
                    LastName = "TAN",
                    Gender = "Male",
                    Department = "Product Designer",
                    Salary = 30000m,
                    HireDate = new DateTime(2017, 7, 17),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 28,
                    FirstName = "Derya",
                    LastName = "AKIN",
                    Gender = "Female",
                    Department = "HR Specialist",
                    Salary = 23000m,
                    HireDate = new DateTime(2019, 3, 4),
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 29,
                    FirstName = "Murat",
                    LastName = "KAYA",
                    Gender = "Male",
                    Department = "Software Architect",
                    Salary = 32000m,
                    HireDate = new DateTime(2016, 10, 22),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 30,
                    FirstName = "Yasemin",
                    LastName = "DEMIR",
                    Gender = "Female",
                    Department = "Product Designer",
                    Salary = 28000m,
                    HireDate = new DateTime(2020, 9, 1),
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                },
            };
        }

    }
}
