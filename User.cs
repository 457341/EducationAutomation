using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class User
    {
        private string idNo;
        private string password;

        public void setIdNo(string idNo)
        {
            this.idNo = idNo;
        }
        public string getIdNo()
        {
            return this.idNo;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
