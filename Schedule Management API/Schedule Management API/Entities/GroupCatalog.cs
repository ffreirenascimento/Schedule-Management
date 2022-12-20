using System;
namespace Schedule_Management_API.Entities
{
	public class GroupCatalog
	{
		public List<Group> groups = new();

		public GroupCatalog()
		{
		}

		public void createGroup()
		{
			groups.Add(new Group());
		}
	}
}

