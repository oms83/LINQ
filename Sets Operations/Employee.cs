namespace LINQ.Sets_Operations
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeNo { get; set; }

        public override string ToString()
        {
            return $"[{EmployeeNo}] {Name}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = obj as Employee;

            return other.EmployeeNo.Equals(EmployeeNo) && other.Name.Equals(Name);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + EmployeeNo.GetHashCode();
                hash = hash * 23 + Name.GetHashCode();
                return hash;
            }
        }
    }
}
