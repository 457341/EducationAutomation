using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Course
    {
        private int courseID;
        private string ID;
        private string openDate;

        public void setID(string INo)
        {
            ID = INo;
        }
        public string getID()
        {
            return ID;
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
    }
}
