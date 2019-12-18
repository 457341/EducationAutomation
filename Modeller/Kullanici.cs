using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Kullanici
    {
        private string kimlikNo;
        private string sifre;

        public void setKimlikNo(string idNo)
        {
            this.kimlikNo = idNo;
        }
        public string getKimlikNo()
        {
            return this.kimlikNo;
        }
        public void setSifre(string password)
        {
            this.sifre = password;
        }
        public string getSifte()
        {
            return this.sifre;
        }
    }
}
