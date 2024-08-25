using System;
using System.Collections.Generic;


namespace LINQTut04.Shared
{
    public class Repository
    {
        public static IEnumerable<Employee> GetEmployeesInfo()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Omer",
                    LastName = "MEMES",
                    Email = "oms@gmail.com",
                    Skills = new List<string>(){"C", "C++", "C#", "HTML5", "CSS3"}
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Ahmet",
                    LastName = "YILMAZ",
                    Email = "ahmet.yilmaz@example.com",
                    Skills = new List<string>(){"Java", "Spring", "JavaScript", "React"}
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Ayla",
                    LastName = "KARA",
                    Email = "ayla.kara@example.com",
                    Skills = new List<string>(){"Python", "Django", "HTML5", "CSS3"}
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Mehmet",
                    LastName = "DEMIR",
                    Email = "mehmet.demir@example.com",
                    Skills = new List<string>(){"PHP", "Laravel", "MySQL", "JavaScript"}
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Zeynep",
                    LastName = "OZTURK",
                    Email = "zeynep.ozturk@example.com",
                    Skills = new List<string>(){"Ruby", "Rails", "JavaScript", "React"}
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Fatih",
                    LastName = "SAHIN",
                    Email = "fatih.sahin@example.com",
                    Skills = new List<string>(){"Go", "Kubernetes", "Docker", "Python"}
                },
                new Employee
                {
                    Id = 7,
                    FirstName = "Esra",
                    LastName = "AKSOY",
                    Email = "esra.aksoy@example.com",
                    Skills = new List<string>(){"JavaScript", "Node.js", "React", "HTML5"}
                },
                new Employee
                {
                    Id = 8,
                    FirstName = "Ali",
                    LastName = "CETIN",
                    Email = "ali.cetin@example.com",
                    Skills = new List<string>(){"Swift", "iOS", "Objective-C", "Xcode"}
                },
                new Employee
                {
                    Id = 9,
                    FirstName = "Merve",
                    LastName = "KURT",
                    Email = "merve.kurt@example.com",
                    Skills = new List<string>(){"Kotlin", "Android", "Java", "XML"}
                },
                new Employee
                {
                    Id = 10,
                    FirstName = "Hakan",
                    LastName = "KAYA",
                    Email = "hakan.kaya@example.com",
                    Skills = new List<string>(){"C#", ".NET", "ASP.NET", "SQL Server"}
                },
                new Employee
                {
                    Id = 11,
                    FirstName = "Ayse",
                    LastName = "YAVUZ",
                    Email = "ayse.yavuz@example.com",
                    Skills = new List<string>(){"JavaScript", "Vue.js", "Node.js", "MongoDB"}
                },
                new Employee
                {
                    Id = 12,
                    FirstName = "Berk",
                    LastName = "ERDOGAN",
                    Email = "berk.erdogan@example.com",
                    Skills = new List<string>(){"C", "Embedded Systems", "RTOS", "C++"}
                },
                new Employee
                {
                    Id = 13,
                    FirstName = "Melis",
                    LastName = "OZCAN",
                    Email = "melis.ozcan@example.com",
                    Skills = new List<string>(){"Python", "Flask", "Machine Learning", "TensorFlow"}
                },
                new Employee
                {
                    Id = 14,
                    FirstName = "Okan",
                    LastName = "AKBAS",
                    Email = "okan.akbas@example.com",
                    Skills = new List<string>(){"JavaScript", "Angular", "TypeScript", "HTML5"}
                },
                new Employee
                {
                    Id = 15,
                    FirstName = "Ece",
                    LastName = "AYDIN",
                    Email = "ece.aydin@example.com",
                    Skills = new List<string>(){"C#", ".NET Core", "ASP.NET", "Entity Framework"}
                },
                new Employee
                {
                    Id = 16,
                    FirstName = "Yusuf",
                    LastName = "CIFTCI",
                    Email = "yusuf.ciftci@example.com",
                    Skills = new List<string>(){"Scala", "Akka", "Java", "Play Framework"}
                },
                new Employee
                {
                    Id = 17,
                    FirstName = "Pelin",
                    LastName = "KOCA",
                    Email = "pelin.koca@example.com",
                    Skills = new List<string>(){"Python", "Pandas", "Numpy", "Data Science"}
                },
                new Employee
                {
                    Id = 18,
                    FirstName = "Ege",
                    LastName = "DURAN",
                    Email = "ege.duran@example.com",
                    Skills = new List<string>(){"Rust", "WebAssembly", "C++", "Systems Programming"}
                },
                new Employee
                {
                    Id = 19,
                    FirstName = "Duygu",
                    LastName = "POLAT",
                    Email = "duygu.polat@example.com",
                    Skills = new List<string>(){"Java", "Spring Boot", "Microservices", "Kubernetes"}
                },
                new Employee
                {
                    Id = 20,
                    FirstName = "Murat",
                    LastName = "SEZER",
                    Email = "murat.sezer@example.com",
                    Skills = new List<string>(){"C++", "Qt", "Cross-platform", "Embedded Systems"}
                },
                new Employee
                {
                    Id = 21,
                    FirstName = "Nazli",
                    LastName = "KARADENIZ",
                    Email = "nazli.karadeniz@example.com",
                    Skills = new List<string>(){"Python", "Django", "REST APIs", "SQL"}
                },
                new Employee
                {
                    Id = 22,
                    FirstName = "Cem",
                    LastName = "GULER",
                    Email = "cem.guler@example.com",
                    Skills = new List<string>(){"JavaScript", "React", "Redux", "HTML5"}
                },
                new Employee
                {
                    Id = 23,
                    FirstName = "Burcu",
                    LastName = "YALCIN",
                    Email = "burcu.yalcin@example.com",
                    Skills = new List<string>(){"Java", "Spring MVC", "Hibernate", "JPA"}
                },
                new Employee
                {
                    Id = 24,
                    FirstName = "Kerem",
                    LastName = "TAS",
                    Email = "kerem.tas@example.com",
                    Skills = new List<string>(){"C#", "WPF", "XAML", "MVVM"}
                },
                new Employee
                {
                    Id = 25,
                    FirstName = "Elif",
                    LastName = "KOC",
                    Email = "elif.koc@example.com",
                    Skills = new List<string>(){"JavaScript", "Node.js", "Express", "MongoDB"}
                },
                new Employee
                {
                    Id = 26,
                    FirstName = "Arda",
                    LastName = "BAKIR",
                    Email = "arda.bakir@example.com",
                    Skills = new List<string>(){"Python", "Machine Learning", "AI", "TensorFlow"}
                },
                new Employee
                {
                    Id = 27,
                    FirstName = "Asli",
                    LastName = "AKINCI",
                    Email = "asli.akinci@example.com",
                    Skills = new List<string>(){"Ruby", "Rails", "JavaScript", "React"}
                },
                new Employee
                {
                    Id = 28,
                    FirstName = "Selim",
                    LastName = "OZGUR",
                    Email = "selim.ozgur@example.com",
                    Skills = new List<string>(){"Go", "Microservices", "Docker", "Kubernetes"}
                },
                new Employee
                {
                    Id = 29,
                    FirstName = "Banu",
                    LastName = "CAN",
                    Email = "banu.can@example.com",
                    Skills = new List<string>(){"JavaScript", "Angular", "TypeScript", "RxJS"}
                },
                new Employee
                {
                    Id = 30,
                    FirstName = "Tugce",
                    LastName = "YILDIRIM",
                    Email = "tugce.yildirim@example.com",
                    Skills = new List<string>(){"Python", "Flask", "PostgreSQL", "Data Science"}
                }
            };
        }

    }
}
