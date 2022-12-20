namespace Schedule_Management_API.Entities
{
    public class Professor
    {
        public Guid Number { get; set; }
        public string Name { get; set; } = "";
        public List<Class> classes = new();

        public Professor(Guid number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}