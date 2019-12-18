using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class CourseInfo
    {
		private int courseID;
		private int period;
		private string courseName;
		public int getCourseID()
		{
			return courseID;
		}
		public void setCourseID(int courseID)
		{
			this.courseID = courseID;
		}
		public int getPeriod()
		{
			return period;
		}
		public void setPeriod(int period)
		{
			this.period = period;
		}
		public string getCourseName()
		{
			return courseName;
		}
		public void setCourseName(string courseName)
		{
			this.courseName = courseName;
		}
	}
}
