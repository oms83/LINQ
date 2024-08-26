using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data_Partitioning.Skip_Operation
{
    internal class clsSkip
    {
        public static void run()
        {
            //RunSkipMethod();
            RunSkipWhile();
        }

        static void RunSkipLastMethod()
        {
            var emps = Repository.GetEmployeeInfo();

            //var items = emps.SkipLast(10);

            //items.Print("Skip First 10 Employees");

            /*
                11      2022-FI-1121    Deniz SARAC             deniz.sarac@example.com         $4,100   [Java, Spring Boot, Microservices]
                12      2022-FI-1122    Bora CAN                bora.can@example.com            $4,000   [C, Embedded Systems, RTOS]
                13      2019-FI-1123    Ece AYDIN               ece.aydin@example.com           $3,900   [JavaScript, Angular, TypeScript]
                14      2020-FI-1124    Selim KAYA              selim.kaya@example.com          $4,500   [Python, Machine Learning, TensorFlow]
                15      2020-FI-1125    Banu YILDIRIM           banu.yildirim@example.com       $4,200   [JavaScript, Vue.js, Node.js]
                16      2021-FI-1126    Emre DURAN              emre.duran@example.com          $4,100   [C++, Qt, Cross-platform]
                17      2021-FI-1127    Zeynep AKSOY            zeynep.aksoy@example.com        $3,900   [Java, Spring, Hibernate]
                18      2019-FI-1128    Okan EROL               okan.erol@example.com           $4,300   [C#, .NET Core, Entity Framework]
                19      2019-FI-1129    Aylin KARACA            aylin.karaca@example.com        $4,000   [Ruby, Rails, PostgreSQL]
                20      2019-FI-1130    Cem OZTURK              cem.ozturk@example.com          $4,200   [JavaScript, React, Redux] 
            */
        }

        static void RunSkipWhile()
        {
            var emps = Repository.GetEmployeeInfo();

            var items = emps.SkipWhile(emp => emp.Salary == 4000m);

            items.Print("Skip employees whose salary is less than 4000");

            /*
                2       2020-FI-1112    Ahmet YILMAZ            ahmet.yilmaz@example.com        $4,200   [Java, Spring, Hibernate]
                3       2020-FI-1113    Ayse KAYA               ayse.kaya@example.com           $3,900   [Python, Django, Flask]
                4       2020-FI-1114    Mehmet DEMIR            mehmet.demir@example.com        $4,500   [JavaScript, React, Node.js]
                5       2020-FI-1115    Fatma OZKAN             fatma.ozkan@example.com         $4,100   [PHP, Laravel, MySQL]
                6       2020-FI-1116    Ali CELIK               ali.celik@example.com           $4,300   [Ruby, Rails, PostgreSQL]
                7       2020-FI-1117    Merve KURT              merve.kurt@example.com          $4,000   [Swift, iOS, Objective-C]
                8       2022-FI-1118    Hakan YAVUZ             hakan.yavuz@example.com         $4,200   [Kotlin, Android, Java]
                9       2020-FI-1119    Elif AKIN               elif.akin@example.com           $3,900   [C#, .NET, SQL Server]
                10      2020-FI-1120    Burak GUL               burak.gul@example.com           $4,500   [Go, Kubernetes, Docker]
                11      2022-FI-1121    Deniz SARAC             deniz.sarac@example.com         $4,100   [Java, Spring Boot, Microservices]
                12      2022-FI-1122    Bora CAN                bora.can@example.com            $4,000   [C, Embedded Systems, RTOS]
                13      2019-FI-1123    Ece AYDIN               ece.aydin@example.com           $3,900   [JavaScript, Angular, TypeScript]
                14      2020-FI-1124    Selim KAYA              selim.kaya@example.com          $4,500   [Python, Machine Learning, TensorFlow]
                15      2020-FI-1125    Banu YILDIRIM           banu.yildirim@example.com       $4,200   [JavaScript, Vue.js, Node.js]
                16      2021-FI-1126    Emre DURAN              emre.duran@example.com          $4,100   [C++, Qt, Cross-platform]
                17      2021-FI-1127    Zeynep AKSOY            zeynep.aksoy@example.com        $3,900   [Java, Spring, Hibernate]
                18      2019-FI-1128    Okan EROL               okan.erol@example.com           $4,300   [C#, .NET Core, Entity Framework]
                19      2019-FI-1129    Aylin KARACA            aylin.karaca@example.com        $4,000   [Ruby, Rails, PostgreSQL]
                20      2019-FI-1130    Cem OZTURK              cem.ozturk@example.com          $4,200   [JavaScript, React, Redux]

 
            */
        }
        static void RunSkipMethod()
        {
            var emps = Repository.GetEmployeeInfo();

            var items= emps.Skip(10);

            items.Print("Skip First 10 Employees");

            /*
                11      2022-FI-1121    Deniz SARAC             deniz.sarac@example.com         $4,100   [Java, Spring Boot, Microservices]
                12      2022-FI-1122    Bora CAN                bora.can@example.com            $4,000   [C, Embedded Systems, RTOS]
                13      2019-FI-1123    Ece AYDIN               ece.aydin@example.com           $3,900   [JavaScript, Angular, TypeScript]
                14      2020-FI-1124    Selim KAYA              selim.kaya@example.com          $4,500   [Python, Machine Learning, TensorFlow]
                15      2020-FI-1125    Banu YILDIRIM           banu.yildirim@example.com       $4,200   [JavaScript, Vue.js, Node.js]
                16      2021-FI-1126    Emre DURAN              emre.duran@example.com          $4,100   [C++, Qt, Cross-platform]
                17      2021-FI-1127    Zeynep AKSOY            zeynep.aksoy@example.com        $3,900   [Java, Spring, Hibernate]
                18      2019-FI-1128    Okan EROL               okan.erol@example.com           $4,300   [C#, .NET Core, Entity Framework]
                19      2019-FI-1129    Aylin KARACA            aylin.karaca@example.com        $4,000   [Ruby, Rails, PostgreSQL]
                20      2019-FI-1130    Cem OZTURK              cem.ozturk@example.com          $4,200   [JavaScript, React, Redux] 
            */
        }
    }
}
