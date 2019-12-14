using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Staff
	{
		private int departmentID;
		private int taskID;
		private string ID;
		private string name;
		private string surname;
		private string date;
		private string educationLevel;

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
		public string getDate()
		{
			return date;
		}
		public void setDate(string date)
		{
			this.date = date;
		}
		public int getDepartmentID()
		{
			return departmentID;
		}
		public void setDepartmentID(int departmentID)
		{
			this.departmentID = departmentID;
		}
		public int getTaskID()
		{
			return taskID;
		}
		public void setTaskID(int taskId)
		{
			this.taskID = taskId;
		}
		public string getIdentificationId()
		{
			return ID;
		}
		public void setIdentificationId(string ID)
		{
			this.ID = ID;
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
