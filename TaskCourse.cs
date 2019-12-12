using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class TaskCourse
    {
        private int courseID;
        private int taskID;
        public void setCourseID(int i)
        {
            courseID = i;
        }

        public int getCourseID()
        {
            return courseID;
        }

        public void setTaskID(int i)
        {
            taskID = i;
        }

        public int getTaskID()
        {
            return taskID;
        }
    }
}
