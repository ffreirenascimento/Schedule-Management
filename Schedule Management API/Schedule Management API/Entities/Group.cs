namespace Schedule_Management_API.Entities
{
    public class Group
    {
        public Guid Number { get; set; }
        public List<Student> students = new();

        public Group()
        {
            Number = new Guid();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }
 
    }
}