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
        public void setcourseName(string kName)
        {
            courseName = kName;
        }
        public string getCourseName()
        {
            return courseName;
        }
        public void setPeriod(int t)
        {
            period = t;
        }
        public int getPeriod()
        {
            return period;
        }
    }
}
