namespace Schedule_Management_API.Entities
{
    public class Student
    {
        public Guid Number { get; set; }
        public string Name { get; set; } = "";

        public Student(Guid number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}