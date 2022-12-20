using System;
namespace Schedule_Management_API.Entities
{
	public class ProfessorsCatalog
	{
        List<Professor> professors { get; set; } = new();

        public ProfessorsCatalog()
        {
        }

        public void createProfessor(string name)
        {
            professors.Add(new Professor(new Guid(), name));
        }
    }
}

