using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Department
    {
        private int depID;
        private string depName;
        public void setDepName(string str)
        {
            depName = str;
        }


        public string getDepName()
        {
            return depName;
        }

        public void setDepID(int i)
        {
            depID = i;
        }

        public int getDepID()
        {
            return depID;
        }
    }
}
