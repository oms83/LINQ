using LINQTut04.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sorting
{
    public class Repository
    {
        public static IEnumerable<Employee> GetEmployeeInfo()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeNo = "2020-FI-1111",
                    Name = "Omer MEMES",
                    Email = "oms@gmail.com",
                    Salary = 4000m,
                    Skills = new List<string>(){"C", "C++", "C#"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1112",
                    Name = "Omer MEMES",
                    Email = "ahmet.yilmaz@example.com",
                    Salary = 4200m,
                    Skills = new List<string>(){"Java", "Spring", "Hibernate"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1113",
                    Name = "Ayse KAYA",
                    Email = "ayse.kaya@example.com",
                    Salary = 3900m,
                    Skills = new List<string>(){"Python", "Django", "Flask"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1114",
                    Name = "Mehmet DEMIR",
                    Email = "mehmet.demir@example.com",
                    Salary = 4500m,
                    Skills = new List<string>(){"JavaScript", "React", "Node.js"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1115",
                    Name = "Fatma OZKAN",
                    Email = "fatma.ozkan@example.com",
                    Salary = 4100m,
                    Skills = new List<string>(){"PHP", "Laravel", "MySQL"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1116",
                    Name = "Ali CELIK",
                    Email = "ali.celik@example.com",
                    Salary = 4300m,
                    Skills = new List<string>(){"Ruby", "Rails", "PostgreSQL"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1117",
                    Name = "Merve KURT",
                    Email = "merve.kurt@example.com",
                    Salary = 4000m,
                    Skills = new List<string>(){"Swift", "iOS", "Objective-C"},
                },
                new Employee
                {
                    EmployeeNo = "2022-FI-1118",
                    Name = "Hakan YAVUZ",
                    Email = "hakan.yavuz@example.com",
                    Salary = 4200m,
                    Skills = new List<string>(){"Kotlin", "Android", "Java"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1119",
                    Name = "Elif AKIN",
                    Email = "elif.akin@example.com",
                    Salary = 3900m,
                    Skills = new List<string>(){"C#", ".NET", "SQL Server"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1120",
                    Name = "Burak GUL",
                    Email = "burak.gul@example.com",
                    Salary = 4500m,
                    Skills = new List<string>(){"Go", "Kubernetes", "Docker"},
                },
                new Employee
                {
                    EmployeeNo = "2022-FI-1121",
                    Name = "Deniz SARAC",
                    Email = "deniz.sarac@example.com",
                    Salary = 4100m,
                    Skills = new List<string>(){"Java", "Spring Boot", "Microservices"},
                },
                new Employee
                {
                    EmployeeNo = "2022-FI-1122",
                    Name = "Bora CAN",
                    Email = "bora.can@example.com",
                    Salary = 4000m,
                    Skills = new List<string>(){"C", "Embedded Systems", "RTOS"},
                },
                new Employee
                {
                    EmployeeNo = "2019-FI-1123",
                    Name = "Ece AYDIN",
                    Email = "ece.aydin@example.com",
                    Salary = 3900m,
                    Skills = new List<string>(){"JavaScript", "Angular", "TypeScript"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1124",
                    Name = "Selim KAYA",
                    Email = "selim.kaya@example.com",
                    Salary = 4500m,
                    Skills = new List<string>(){"Python", "Machine Learning", "TensorFlow"},
                },
                new Employee
                {
                    EmployeeNo = "2020-FI-1125",
                    Name = "Banu YILDIRIM",
                    Email = "banu.yildirim@example.com",
                    Salary = 4200m,
                    Skills = new List<string>(){"JavaScript", "Vue.js", "Node.js"},
                },
                new Employee
                {
                    EmployeeNo = "2021-FI-1126",
                    Name = "Emre DURAN",
                    Email = "emre.duran@example.com",
                    Salary = 4100m,
                    Skills = new List<string>(){"C++", "Qt", "Cross-platform"},
                },
                new Employee
                {
                    EmployeeNo = "2021-FI-1127",
                    Name = "Zeynep AKSOY",
                    Email = "zeynep.aksoy@example.com",
                    Salary = 3900m,
                    Skills = new List<string>(){"Java", "Spring", "Hibernate"},
                },
                new Employee
                {
                    EmployeeNo = "2019-FI-1128",
                    Name = "Okan EROL",
                    Email = "okan.erol@example.com",
                    Salary = 4300m,
                    Skills = new List<string>(){"C#", ".NET Core", "Entity Framework"},
                },
                new Employee
                {
                    EmployeeNo = "2019-FI-1129",
                    Name = "Aylin KARACA",
                    Email = "aylin.karaca@example.com",
                    Salary = 4000m,
                    Skills = new List<string>(){"Ruby", "Rails", "PostgreSQL"},
                },
                new Employee
                {
                    EmployeeNo = "2019-FI-1130",
                    Name = "Cem OZTURK",
                    Email = "cem.ozturk@example.com",
                    Salary = 4200m,
                    Skills = new List<string>(){"JavaScript", "React", "Redux"},
                }
            };
        }

    }
}
