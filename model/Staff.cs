using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Staff
	{
		private string ID;
		private string educationLevel;
		private string department;
		private string task;
		private string name;
		private string surname;
		private DateTime date;

		public string getID()
		{
			return ID;
		}
		public void setID(string id)
		{
			this.ID = id;
		}
		public string getName()
		{
			return name;
		}
		public void setName(string name)
		{
			this.name = name;
		}
		public string getSurname()
		{
			return surname;
		}
		public void setSurname(string surname)
		{
			this.surname = surname;
		}
		public DateTime getDate()
		{
			return date;
		}
		public void setDate(DateTime date)
		{
			this.date = date;
		}
		public string getDepartment()
		{
			return department;
		}
		public void setDepartment(string department)
		{
			this.department = department;
		}
		public string getTask()
		{
			return task;
		}
		public void setTask(string task)
		{
			this.task = task;
		}
		public string getEducationLevel()
		{
			return this.educationLevel;
		}
		public void setEducationLevel(string educationLevel)
		{
			this.educationLevel = educationLevel;
		}
	}
}
