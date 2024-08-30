using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Concatenation
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Question)) return false;

            Question other = obj as Question;

            return other.CorrectAnswer == CorrectAnswer
                && other.Title.Equals(this.Title)
                && Choices.SequenceEqual(other.Choices);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + Title.GetHashCode();
                hash = hash * 23 + Choices.GetHashCode();
                hash = hash * 23 + CorrectAnswer.GetHashCode();

                return hash;
            }
        }
    }
}
