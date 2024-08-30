using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Equality_Operations
{
    public class Question
    {
        public string Title { get; set; }

        public List<Choice> Choices { get; set; } = new List<Choice>();

        public int CorrectAnswer { get; set; }

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
