using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Bolum
    {
		private int bolumNo;
		private string bolumAd;
		public int getBolumNo()
		{
			return bolumNo;
		}
		public void setBolumNo(int bolumNo)
		{
			this.bolumNo = bolumNo;
		}
		public string getBolumAd()
		{
			return bolumAd;
		}
		public void setBolumAd(string bolumAd)
		{
			this.bolumAd = bolumAd;
		}
	}
}
