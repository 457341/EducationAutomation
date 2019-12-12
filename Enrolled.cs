using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Enrolled
    {
		private int courseID;
		private int performance;
		private string idNo;
		private string openDate;

		public string getIdNo()
		{
			return idNo;
		}
		public void setIdNo(string idNo)
		{
			this.idNo = idNo;
		}
		public int getCourseID()
		{
			return courseID;
		}
		public void setCourseID(int courseID)
		{
			this.courseID = courseID;
		}
		public string getOpenDate()
		{
			return openDate;
		}
		public void setOpenDate(string openDate)
		{
			this.openDate = openDate;
		}
		public int getPerformance()
		{
			return performance;
		}
		public void setPerformance(int performance)
		{
			this.performance = performance;
		}

	}
}
