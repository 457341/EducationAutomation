using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Task
    {
        private int taskID;
        private string taskName;

        public int getTaskID()
        {
            return taskID;
        }
        public void setTaskID(int taskID)
        {
            this.taskID = taskID;
        }
        public void setTaskName(string tName)
        {
            taskName = tName;
        }
        public string getTaskName()
        {
            return taskName;
        }
    }
}
