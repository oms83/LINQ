namespace LINQTut04.SELECT
{
    public class EmployeeDto
    {
        public string Name { get; set; }

        public int TotalSkills { get; set; }

        public override string ToString()
        {
            return $"{Name.PadRight(15)} - {TotalSkills.ToString().PadLeft(4)}";
        }
    }
}
