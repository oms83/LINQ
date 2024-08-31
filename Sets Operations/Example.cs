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
            Example02();
        }

        //private static void Example02() 
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
