using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sets_Operations
{
    public class Repository
    {
        public static List<Meeting> Meetings => new List<Meeting>()
        {
            new Meeting()
            {
                Date = new DateTime(2023, 1, 1),
                StartAt = new DateTime(2023, 1, 1, 12, 30, 0),
                EndAt = new DateTime(2023, 1, 1, 15, 30, 0),
                Title = "C++ Practices",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Omer MEMES", EmployeeNo = "oms01" },
                    new Employee() { Name = "Ali MEMES", EmployeeNo = "oms02" },
                    new Employee() { Name = "Yusuf Sultan", EmployeeNo = "oms03" },
                    new Employee() { Name = "Musa Bozkurt", EmployeeNo = "oms04" },
                    new Employee() { Name = "Murat Dogan", EmployeeNo = "oms05" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 2, 15),
                StartAt = new DateTime(2023, 2, 15, 10, 0, 0),
                EndAt = new DateTime(2023, 2, 15, 11, 0, 0),
                Title = "Project Kickoff",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Omer MEMES", EmployeeNo = "oms01" },
                    new Employee() { Name = "Ali MEMES", EmployeeNo = "oms02" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 3, 5),
                StartAt = new DateTime(2023, 3, 5, 14, 0, 0),
                EndAt = new DateTime(2023, 3, 5, 16, 0, 0),
                Title = "Design Review",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Yusuf Sultan", EmployeeNo = "oms03" },
                    new Employee() { Name = "Musa Bozkurt", EmployeeNo = "oms04" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 4, 20),
                StartAt = new DateTime(2023, 4, 20, 9, 30, 0),
                EndAt = new DateTime(2023, 4, 20, 11, 30, 0),
                Title = "Sprint Planning",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Omer MEMES", EmployeeNo = "oms01" },
                    new Employee() { Name = "Murat Dogan", EmployeeNo = "oms05" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 5, 10),
                StartAt = new DateTime(2023, 5, 10,13, 0, 0),
                EndAt = new DateTime(2023, 5, 10, 14, 30, 0),
                Title = "Team Building",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Ali MEMES", EmployeeNo = "oms02" },
                    new Employee() { Name = "Yusuf Sultan", EmployeeNo = "oms03" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 6, 25),
                StartAt = new DateTime(2023, 6, 25, 15, 0, 0),
                EndAt = new DateTime(2023, 6, 25, 17, 0, 0),
                Title = "Product Demo",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Musa Bozkurt", EmployeeNo = "oms04" },
                    new Employee() { Name = "Murat Dogan", EmployeeNo = "oms05" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 7, 30),
                StartAt = new DateTime(2023, 7, 30, 11, 0, 0),
                EndAt = new DateTime(2023, 7, 30, 12, 30, 0),
                Title = "Retrospective",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Omer MEMES", EmployeeNo = "oms01" },
                    new Employee() { Name = "Ali MEMES", EmployeeNo = "oms02" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 8, 14),
                StartAt = new DateTime(2023, 8, 14, 10, 0, 0),
                EndAt = new DateTime(2023, 8, 14, 12, 0, 0),
                Title = "Quarterly Review",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Yusuf Sultan", EmployeeNo = "oms03" },
                    new Employee() { Name = "Musa Bozkurt", EmployeeNo = "oms04" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 9, 18),
                StartAt = new DateTime(2023, 9, 18, 9, 0, 0),
                EndAt = new DateTime(2023, 9, 18, 10, 30, 0),
                Title = "Budget Planning",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Murat Dogan", EmployeeNo = "oms05" },
                    new Employee() { Name = "Omer MEMES", EmployeeNo = "oms01" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 10, 25),
                StartAt = new DateTime(2023, 10, 25, 14, 0, 0),
                EndAt = new DateTime(2023, 10, 25, 16, 0, 0),
                Title = "Client Meeting",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Ali MEMES", EmployeeNo = "oms02" },
                    new Employee() { Name = "Yusuf Sultan", EmployeeNo = "oms03" },
                },
            },
            new Meeting()
            {
                Date = new DateTime(2023, 11, 30),
                StartAt = new DateTime(2023, 11, 30, 13, 0, 0),
                EndAt = new DateTime(2023, 11, 30, 15, 0, 0),
                Title = "Year-End Review",
                Participants = new List<Employee>()
                {
                    new Employee() { Name = "Musa Bozkurt", EmployeeNo = "oms04" },
                    new Employee() { Name = "Murat Dogan", EmployeeNo = "oms05" },
                },
            }
        };

        public static Meeting Meeting1 => Meetings[0];
        public static Meeting Meeting2 => Meetings[1];
        public static Meeting Meeting3 => Meetings[2];
        public static Meeting Meeting4 => Meetings[3];
        public static Meeting Meeting5 => Meetings[4];
        public static Meeting Meeting6 => Meetings[5];
        public static Meeting Meeting7 => Meetings[6];
        public static Meeting Meeting8 => Meetings[7];
        public static Meeting Meeting9 => Meetings[8];
        public static Meeting Meeting10 => Meetings[9];
    }
}
