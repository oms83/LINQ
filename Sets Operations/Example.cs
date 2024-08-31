using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sets_Operations
{
    public class Example
    {
        public static void run()
        {
            //Example01();
            //Example02();
            //Example03();
            //Example04();
            Example05();
        }

        // Union
        private static void Example05()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting3.Participants;

            set1.Print($"=========== Meeting 1 Participants ({set1.Count()})");
            set2.Print($"=========== Meeting 2 Participants ({set2.Count()})");

            var set3 = set1.Union(set2);

            set3.Print("Set1 Union Set2");
        }

        // intersection
        private static void Example04()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting3.Participants;

            set1.Print($"=========== Meeting 1 Participants ({set1.Count()})");
            set2.Print($"=========== Meeting 2 Participants ({set2.Count()})");

            var set3 = set1.Intersect(set2);

            set3.Print("Set1 Intersect Set2");
        }

        // exception
        private static void Example03()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting3.Participants;

            set1.Print($"=========== Meeting 1 Participants ({set1.Count()})");
            set2.Print($"=========== Meeting 2 Participants ({set2.Count()})");

            var set3 = set1.Except(set2);

            set3.Print("Set1 Except Set2");
        }
        private static void Example02()
        {
            var meetings = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);
            //meetings.Print("Employee");
            /*
             [oms01] Omer MEMES
             [oms02] Ali MEMES
             [oms03] Yusuf Sultan
             [oms04] Musa Bozkurt
             [oms05] Murat Dogan
             [oms01] Omer MEMES
             [oms02] Ali MEMES
             */

            var meetings2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants).Distinct();
            meetings2.Print("Employee");
            /*
                [oms01] Omer MEMES
                [oms02] Ali MEMES
                [oms03] Yusuf Sultan
                [oms04] Musa Bozkurt
                [oms05] Murat Dogan
            */

            /*
                if we donnot implement the Equals and GetHashCode methods the same object in value will be repeat 
                we can solve this problem using the DistinctBy method bu is not supported in c# V5
            */
        }
        private static void Example01()
        {
            Repository.Meetings.Print("All Meetings");
        }
    }
}
