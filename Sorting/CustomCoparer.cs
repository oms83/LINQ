using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sorting
{
    public class CustomCoparer
    {
        public static void run()
        {
            //Example01();
            Example02();
        }

        static void Example02()
        {
            IEnumerable<Employee> employees = Repository.GetEmployeeInfo();
            IOrderedEnumerable<Employee> sortedEmps = employees.OrderBy(emp => emp, new EmployeeComparer());

            foreach (Employee emp in sortedEmps)
            {
                Console.WriteLine(emp);
            }
            /*
                2020-FI-1111    Omer MEMES              oms@gmail.com                   $4,000   [C, C++, C#]
                2020-FI-1112    Omer MEMES              ahmet.yilmaz@example.com        $4,200   [Java, Spring, Hibernate]
                2020-FI-1113    Ayse KAYA               ayse.kaya@example.com           $3,900   [Python, Django, Flask]
                2020-FI-1114    Mehmet DEMIR            mehmet.demir@example.com        $4,500   [JavaScript, React, Node.js]
                2020-FI-1115    Fatma OZKAN             fatma.ozkan@example.com         $4,100   [PHP, Laravel, MySQL]
                2020-FI-1116    Ali CELIK               ali.celik@example.com           $4,300   [Ruby, Rails, PostgreSQL]
                2020-FI-1117    Merve KURT              merve.kurt@example.com          $4,000   [Swift, iOS, Objective-C]
                2022-FI-1118    Hakan YAVUZ             hakan.yavuz@example.com         $4,200   [Kotlin, Android, Java]
                2020-FI-1119    Elif AKIN               elif.akin@example.com           $3,900   [C#, .NET, SQL Server]
                2020-FI-1120    Burak GUL               burak.gul@example.com           $4,500   [Go, Kubernetes, Docker]
                2022-FI-1121    Deniz SARAC             deniz.sarac@example.com         $4,100   [Java, Spring Boot, Microservices]
                2022-FI-1122    Bora CAN                bora.can@example.com            $4,000   [C, Embedded Systems, RTOS]
                2019-FI-1123    Ece AYDIN               ece.aydin@example.com           $3,900   [JavaScript, Angular, TypeScript]
                2020-FI-1124    Selim KAYA              selim.kaya@example.com          $4,500   [Python, Machine Learning, TensorFlow]
                2020-FI-1125    Banu YILDIRIM           banu.yildirim@example.com       $4,200   [JavaScript, Vue.js, Node.js]
                2021-FI-1126    Emre DURAN              emre.duran@example.com          $4,100   [C++, Qt, Cross-platform]
                2021-FI-1127    Zeynep AKSOY            zeynep.aksoy@example.com        $3,900   [Java, Spring, Hibernate]
                2019-FI-1128    Okan EROL               okan.erol@example.com           $4,300   [C#, .NET Core, Entity Framework]
                2019-FI-1129    Aylin KARACA            aylin.karaca@example.com        $4,000   [Ruby, Rails, PostgreSQL]
                2019-FI-1130    Cem OZTURK              cem.ozturk@example.com          $4,200   [JavaScript, React, Redux]
 
            */
        }
        static void Example01()
        {
            IEnumerable<Employee> employees = Repository.GetEmployeeInfo();
            IOrderedEnumerable<Employee> sortedEmps = employees.OrderBy(emp => emp.EmployeeNo);

            foreach (Employee emp in sortedEmps)
            {
                Console.WriteLine(emp);
            }

            /*
             
                2019-FI-1123    Ece AYDIN               ece.aydin@example.com           $3,900   [JavaScript, Angular, TypeScript]
                2019-FI-1128    Okan EROL               okan.erol@example.com           $4,300   [C#, .NET Core, Entity Framework]
                2019-FI-1129    Aylin KARACA            aylin.karaca@example.com        $4,000   [Ruby, Rails, PostgreSQL]
                2019-FI-1130    Cem OZTURK              cem.ozturk@example.com          $4,200   [JavaScript, React, Redux]
                2020-FI-1111    Omer MEMES              oms@gmail.com                   $4,000   [C, C++, C#]
                2020-FI-1112    Omer MEMES              ahmet.yilmaz@example.com        $4,200   [Java, Spring, Hibernate]
                2020-FI-1113    Ayse KAYA               ayse.kaya@example.com           $3,900   [Python, Django, Flask]
                2020-FI-1114    Mehmet DEMIR            mehmet.demir@example.com        $4,500   [JavaScript, React, Node.js]
                2020-FI-1115    Fatma OZKAN             fatma.ozkan@example.com         $4,100   [PHP, Laravel, MySQL]
                2020-FI-1116    Ali CELIK               ali.celik@example.com           $4,300   [Ruby, Rails, PostgreSQL]
                2020-FI-1117    Merve KURT              merve.kurt@example.com          $4,000   [Swift, iOS, Objective-C]
                2020-FI-1119    Elif AKIN               elif.akin@example.com           $3,900   [C#, .NET, SQL Server]
                2020-FI-1120    Burak GUL               burak.gul@example.com           $4,500   [Go, Kubernetes, Docker]
                2020-FI-1124    Selim KAYA              selim.kaya@example.com          $4,500   [Python, Machine Learning, TensorFlow]
                2020-FI-1125    Banu YILDIRIM           banu.yildirim@example.com       $4,200   [JavaScript, Vue.js, Node.js]
                2021-FI-1126    Emre DURAN              emre.duran@example.com          $4,100   [C++, Qt, Cross-platform]
                2021-FI-1127    Zeynep AKSOY            zeynep.aksoy@example.com        $3,900   [Java, Spring, Hibernate]
                2022-FI-1118    Hakan YAVUZ             hakan.yavuz@example.com         $4,200   [Kotlin, Android, Java]
                2022-FI-1121    Deniz SARAC             deniz.sarac@example.com         $4,100   [Java, Spring Boot, Microservices]
                2022-FI-1122    Bora CAN                bora.can@example.com            $4,000   [C, Embedded Systems, RTOS]
             
             */
        }
    }
}
