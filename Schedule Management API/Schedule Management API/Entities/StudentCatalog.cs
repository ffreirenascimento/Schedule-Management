using System;
namespace Schedule_Management_API.Entities
{
	public class StudentCatalog
	{

		List<Student> students { get; set; } = new();

		public StudentCatalog()
		{
		}

		public void createStudent(string name)
		{
			students.Add(new Student(new Guid(), name));
		} 
	}
}

