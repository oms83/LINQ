using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Equality_Operations
{
    public static class QuestionBank
    {
        private static Random random = new Random();

        public static List<Question> All => new List<Question>()
        {
            new Question()
            {
                Title = "Q #1: In The Streaming stored audio/video category...",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Files are compressed and stored on the server." },
                    new Choice() { Order = 2, Descirption = "Files are stored in their original format." },
                    new Choice() { Order = 3, Descirption = "Files are streamed directly from the source." },
                    new Choice() { Order = 4, Descirption = "Files are downloaded before playback." },
                    new Choice() { Order = 5, Descirption = "Files are converted to a streamable format." },
                },
            },
            new Question()
            {
                Title = "Q #2: What is the primary function of a load balancer?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Distribute traffic across multiple servers." },
                    new Choice() { Order = 2, Descirption = "Monitor server health." },
                    new Choice() { Order = 3, Descirption = "Increase bandwidth capacity." },
                    new Choice() { Order = 4, Descirption = "Manage server storage." },
                    new Choice() { Order = 5, Descirption = "Encrypt data in transit." },
                },
            },
            new Question()
            {
                Title = "Q #3: Which of the following is a characteristic of cloud computing?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "On-demand self-service." },
                    new Choice() { Order = 2, Descirption = "Limited scalability." },
                    new Choice() { Order = 3, Descirption = "Fixed resources." },
                    new Choice() { Order = 4, Descirption = "High latency." },
                    new Choice() { Order = 5, Descirption = "No internet access needed." },
                },
            },
            new Question()
            {
                Title = "Q #4: What does HTTP stand for?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "HyperText Transfer Protocol." },
                    new Choice() { Order = 2, Descirption = "HyperText Transmission Protocol." },
                    new Choice() { Order = 3, Descirption = "HighText Transfer Protocol." },
                    new Choice() { Order = 4, Descirption = "HyperTransfer Text Protocol." },
                    new Choice() { Order = 5, Descirption = "HighText Transmission Protocol." },
                },
            },
            new Question()
            {
                Title = "Q #5: Which layer of the OSI model is responsible for routing?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Network layer." },
                    new Choice() { Order = 2, Descirption = "Transport layer." },
                    new Choice() { Order = 3, Descirption = "Application layer." },
                    new Choice() { Order = 4, Descirption = "Session layer." },
                    new Choice() { Order = 5, Descirption = "Data Link layer." },
                },
            },
            new Question()
            {
                Title = "Q #6: What is a primary key in a database?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "A unique identifier for each record." },
                    new Choice() { Order = 2, Descirption = "A foreign key reference." },
                    new Choice() { Order = 3, Descirption = "A key used to access the database." },
                    new Choice() { Order = 4, Descirption = "A secondary identifier." },
                    new Choice() { Order = 5, Descirption = "A key for indexing data." },
                },
            },
            new Question()
            {
                Title = "Q #7: Which of the following is a NoSQL database?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "MongoDB." },
                    new Choice() { Order = 2, Descirption = "MySQL." },
                    new Choice() { Order = 3, Descirption = "Oracle." },
                    new Choice() { Order = 4, Descirption = "PostgreSQL." },
                    new Choice() { Order = 5, Descirption = "SQL Server." },
                },
            },
            new Question()
            {
                Title = "Q #8: What is an API?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Application Programming Interface." },
                    new Choice() { Order = 2, Descirption = "Application Process Integration." },
                    new Choice() { Order = 3, Descirption = "Automated Programming Interface." },
                    new Choice() { Order = 4, Descirption = "Application Protocol Interface." },
                    new Choice() { Order = 5, Descirption = "Application Process Interaction." },
                },
            },
            new Question()
            {
                Title = "Q #9: Which protocol is used for sending email?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "SMTP." },
                    new Choice() { Order = 2, Descirption = "FTP." },
                    new Choice() { Order = 3, Descirption = "HTTP." },
                    new Choice() { Order = 4, Descirption = "IMAP." },
                    new Choice() { Order = 5, Descirption = "SSH." },
                },
            },
            new Question()
            {
                Title = "Q #10: What does 'DRM' stand for in the context of digital media?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Digital Rights Management." },
                    new Choice() { Order = 2, Descirption = "Data Resource Management." },
                    new Choice() { Order = 3, Descirption = "Digital Recording Method." },
                    new Choice() { Order = 4, Descirption = "Data Rights Method." },
                    new Choice() { Order = 5, Descirption = "Digital Resource Management." },
                },
            },
            new Question()
            {
                Title = "Q #11: In The Streaming stored audio/video category...",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Files are compressed and stored on the server." },
                    new Choice() { Order = 2, Descirption = "Files are stored in their original format." },
                    new Choice() { Order = 3, Descirption = "Files are streamed directly from the source." },
                    new Choice() { Order = 4, Descirption = "Files are downloaded before playback." },
                    new Choice() { Order = 5, Descirption = "Files are converted to a streamable format." },
                },
            },
            new Question()
            {
                Title = "Q #12: What is the primary function of a load balancer?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Distribute traffic across multiple servers." },
                    new Choice() { Order = 2, Descirption = "Monitor server health." },
                    new Choice() { Order = 3, Descirption = "Increase bandwidth capacity." },
                    new Choice() { Order = 4, Descirption = "Manage server storage." },
                    new Choice() { Order = 5, Descirption = "Encrypt data in transit." },
                },
            },
            new Question()
            {
                Title = "Q #13: Which of the following is a characteristic of cloud computing?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "On-demand self-service." },
                    new Choice() { Order = 2, Descirption = "Limited scalability." },
                    new Choice() { Order = 3, Descirption = "Fixed resources." },
                    new Choice() { Order = 4, Descirption = "High latency." },
                    new Choice() { Order = 5, Descirption = "No internet access needed." },
                },
            },
            new Question()
            {
                Title = "Q #14: What does HTTP stand for?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "HyperText Transfer Protocol." },
                    new Choice() { Order = 2, Descirption = "HyperText Transmission Protocol." },
                    new Choice() { Order = 3, Descirption = "HighText Transfer Protocol." },
                    new Choice() { Order = 4, Descirption = "HyperTransfer Text Protocol." },
                    new Choice() { Order = 5, Descirption = "HighText Transmission Protocol." },
                },
            },
            new Question()
            {
                Title = "Q #15: Which layer of the OSI model is responsible for routing?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Network layer." },
                    new Choice() { Order = 2, Descirption = "Transport layer." },
                    new Choice() { Order = 3, Descirption = "Application layer." },
                    new Choice() { Order = 4, Descirption = "Session layer." },
                    new Choice() { Order = 5, Descirption = "Data Link layer." },
                },
            },
            new Question()
            {
                Title = "Q #16: What is a primary key in a database?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "A unique identifier for each record." },
                    new Choice() { Order = 2, Descirption = "A foreign key reference." },
                    new Choice() { Order = 3, Descirption = "A key used to access the database." },
                    new Choice() { Order = 4, Descirption = "A secondary identifier." },
                    new Choice() { Order = 5, Descirption = "A key for indexing data." },
                },
            },
            new Question()
            {
                Title = "Q #17: Which of the following is a NoSQL database?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "MongoDB." },
                    new Choice() { Order = 2, Descirption = "MySQL." },
                    new Choice() { Order = 3, Descirption = "Oracle." },
                    new Choice() { Order = 4, Descirption = "PostgreSQL." },
                    new Choice() { Order = 5, Descirption = "SQL Server." },
                },
            },
            new Question()
            {
                Title = "Q #18: What is an API?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Application Programming Interface." },
                    new Choice() { Order = 2, Descirption = "Application Process Integration." },
                    new Choice() { Order = 3, Descirption = "Automated Programming Interface." },
                    new Choice() { Order = 4, Descirption = "Application Protocol Interface." },
                    new Choice() { Order = 5, Descirption = "Application Process Interaction." },
                },
            },
            new Question()
            {
                Title = "Q #20: Which protocol is used for sending email?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "SMTP." },
                    new Choice() { Order = 2, Descirption = "FTP." },
                    new Choice() { Order = 3, Descirption = "HTTP." },
                    new Choice() { Order = 4, Descirption = "IMAP." },
                    new Choice() { Order = 5, Descirption = "SSH." },
                },
            },
            new Question()
            {
                Title = "Q #20: What does 'DRM' stand for in the context of digital media?",
                Choices = new List<Choice>()
                {
                    new Choice() { Order = 1, Descirption = "Digital Rights Management." },
                    new Choice() { Order = 2, Descirption = "Data Resource Management." },
                    new Choice() { Order = 3, Descirption = "Digital Recording Method." },
                    new Choice() { Order = 4, Descirption = "Data Rights Method." },
                    new Choice() { Order = 5, Descirption = "Digital Resource Management." },
                },
            },
            // Repeat similarly for the remaining 20 questions...
        };

        public static IEnumerable<Question> Radomize(int count)
        {
            if (All.Count < count)
            {
                return AllShuffled;
            }
            return AllShuffled.Take(count);
        }
        public static Question PickOne()
        {
            return All[random.Next(0, All.Count)];
        }

        public static List<Question> AllShuffled =>
            All.OrderBy(x => random.Next()).ToList();

        public static void ToQuiz(this IEnumerable<Question> questions)
        {
            foreach (var item in questions)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        public static List<Question> GetQuestionRange(IEnumerable<int> range)
        {
            if (range.Count() >= All.Count)
            {
                return All;
            }

            return range.Select(i => All[i]).ToList();
        }

    }
}
