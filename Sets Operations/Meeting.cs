using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Sets_Operations
{
    public class Meeting
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public List<Employee> Participants { get; set; }

        public override string ToString()
        {
            var participantsList = "";

            var length = Participants.Count;
            for (var i = 0; i < length; i++)
            {
                var branchSymbol = i < length - 1 ? "├─" : "└─";
                participantsList += $"\n\t\t{branchSymbol}{Participants[i]}";
            }

            return $"\n\t├─ {Date.ToString("yyyy.MM.dd")} [{StartAt.ToString("hh:mm")} - {EndAt.ToString("hh:mm")}] {Title} ({length})"
                + $"\n\t └─-----|"
                + $"{participantsList}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != this.GetType()) return false;
            if (ReferenceEquals(this, obj)) return true;

            Meeting other = obj as Meeting;

            return other.Title.Equals(Title) && other.Date.Equals(Date)
                && other.StartAt.Equals(StartAt)
                && other.EndAt.Equals(EndAt)
                && Participants.SequenceEqual(Participants);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + Title.GetHashCode();
                hash = hash * 23 + Date.GetHashCode();
                hash = hash * 23 + StartAt.GetHashCode();
                hash = hash * 23 + EndAt.GetHashCode();
                hash = hash * 23 + Participants.GetHashCode();

                return hash;
            }
        }
    }
}
