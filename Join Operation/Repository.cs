using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Join_Operation
{
    public class Repository
    {
        public static IEnumerable<Department> GetDepartmentInfo()
        {
            return new List<Department>()
            {
                new Department() { Id = 1, Name = "Software Engineering" },
                new Department() { Id = 2, Name = "Human Resources" },
                new Department() { Id = 3, Name = "Sales" },
                new Department() { Id = 4, Name = "Marketing" }
            };
        }

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
                    DepartmentID = 1,
                    Salary = 24000m,
                    HireDate = new DateTime(2020, 8, 3),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Fatma",
                    LastName = "KAYA",
                    Gender = "Female",
                    DepartmentID = 2,
                    Salary = 20000m,
                    HireDate = new DateTime(2019, 5, 10),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Ahmet",
                    LastName = "YILMAZ",
                    Gender = "Male",
                    DepartmentID = 1,
                    Salary = 25000m,
                    HireDate = new DateTime(2018, 3, 15),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Ayse",
                    LastName = "DEMIR",
                    Gender = "Female",
                    DepartmentID = 3,
                    Salary = 23000m,
                    HireDate = new DateTime(2020, 6, 20),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 5,
                    FirstName = "Ali",
                    LastName = "CAN",
                    Gender = "Male",
                    DepartmentID = 4,
                    Salary = 22000m,
                    HireDate = new DateTime(2021, 7, 25),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 6,
                    FirstName = "Merve",
                    LastName = "GUL",
                    Gender = "Female",
                    DepartmentID = 1,
                    Salary = 24000m,
                    HireDate = new DateTime(2019, 1, 12),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 7,
                    FirstName = "Hakan",
                    LastName = "OZTURK",
                    Gender = "Male",
                    DepartmentID = 3,
                    Salary = 21000m,
                    HireDate = new DateTime(2020, 11, 5),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 8,
                    FirstName = "Zeynep",
                    LastName = "KARACA",
                    Gender = "Female",
                    DepartmentID = 2,
                    Salary = 20000m,
                    HireDate = new DateTime(2021, 4, 17),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 9,
                    FirstName = "Burak",
                    LastName = "YAVUZ",
                    Gender = "Male",
                    DepartmentID = 4,
                    Salary = 22000m,
                    HireDate = new DateTime(2018, 9, 23),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 10,
                    FirstName = "Deniz",
                    LastName = "AKIN",
                    Gender = "Female",
                    DepartmentID = 1,
                    Salary = 26000m,
                    HireDate = new DateTime(2017, 8, 8),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 11,
                    FirstName = "Bora",
                    LastName = "EROL",
                    Gender = "Male",
                    DepartmentID = 3,
                    Salary = 24000m,
                    HireDate = new DateTime(2019, 3, 3),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 12,
                    FirstName = "Ece",
                    LastName = "DEMIR",
                    Gender = "Female",
                    DepartmentID = 2,
                    Salary = 21000m,
                    HireDate = new DateTime(2020, 12, 1),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 13,
                    FirstName = "Okan",
                    LastName = "KAYA",
                    Gender = "Male",
                    DepartmentID = 4,
                    Salary = 23000m,
                    HireDate = new DateTime(2017, 5, 15),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 14,
                    FirstName = "Aylin",
                    LastName = "KARA",
                    Gender = "Female",
                    DepartmentID = 1,
                    Salary = 25000m,
                    HireDate = new DateTime(2020, 2, 22),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 15,
                    FirstName = "Cem",
                    LastName = "YILMAZ",
                    Gender = "Male",
                    DepartmentID = 3,
                    Salary = 22000m,
                    HireDate = new DateTime(2019, 7, 11),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 16,
                    FirstName = "Asli",
                    LastName = "KOC",
                    Gender = "Female",
                    DepartmentID = 4,
                    Salary = 23000m,
                    HireDate = new DateTime(2018, 10, 30),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 17,
                    FirstName = "Selim",
                    LastName = "CAN",
                    Gender = "Male",
                    DepartmentID = 2,
                    Salary = 21000m,
                    HireDate = new DateTime(2021, 1, 4),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                },
                new Employee()
                {
                    Id = 18,
                    FirstName = "Banu",
                    LastName = "AKSOY",
                    Gender = "Female",
                    DepartmentID = 1,
                    Salary = 24000m,
                    HireDate = new DateTime(2017, 6, 6),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 19,
                    FirstName = "Tugce",
                    LastName = "GUL",
                    Gender = "Female",
                    DepartmentID = 3,
                    Salary = 22000m,
                    HireDate = new DateTime(2018, 4, 12),
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                },
                new Employee()
                {
                    Id = 20,
                    FirstName = "Kerem",
                    LastName = "KURT",
                    Gender = "Male",
                    DepartmentID = 4,
                    Salary = 25000m,
                    HireDate = new DateTime(2021, 7, 19),
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                }
            };
        }

    }
}
