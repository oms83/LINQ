using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Concatenation
{
    public class Choice
    {
        public int Order { get; set; }
        public string Descirption { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = obj as Choice;

            return other.Order == Order && other.Descirption.Equals(this.Descirption);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Order.GetHashCode();
            hash = hash * 23 + Descirption.GetHashCode();
            return hash;
        }
    }
}
