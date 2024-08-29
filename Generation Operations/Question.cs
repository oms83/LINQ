using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generation_Operations
{
    public class Question
    {
        public string Title { get; set; }

        public List<Choice> Choices { get; set; } = new List<Choice>();

        public int CorrectAnswer { get; set; }

        public readonly static Question Instance = new Question()
        {
            Title = "<<<<<<<<<<<<<<< Question Title Goes Here >>>>>>>>>>>>>>>",
            Choices = new List<Choice>()
            {
                new Choice() { Order=1, Descirption="<<<<<<<< Choice #1 Goes Here >>>>>>>>"},
                new Choice() { Order=2, Descirption="<<<<<<<< Choice #1 Goes Here >>>>>>>>"},
                new Choice() { Order=3, Descirption="<<<<<<<< Choice #1 Goes Here >>>>>>>>"},
                new Choice() { Order=4, Descirption="<<<<<<<< Choice #1 Goes Here >>>>>>>>"},
                new Choice() { Order=5, Descirption="<<<<<<<< Choice #1 Goes Here >>>>>>>>"},
            },
            CorrectAnswer = 0
        };

        public override string ToString()
        {
            var choices = ""; 

            foreach (var choice in Choices)
            {
                choices += $"\n\t{choice.Order})  {choice.Descirption}";
            }

            return $"{Title}" +
                   $"{choices}";
        }
    }
}
