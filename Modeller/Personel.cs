using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomation
{
    class Personel
	{
		private string kimlikNo;
		private string personelAd;
		private string personelSoyad;
		private int egitimNo;
		private int bolumNo;
		private int gorevNo;
		private DateTime baslamaTarih;

		private string egitimAd;
		private string bolumAd;
		private string gorevAd;

		public string getKimlikNo()
		{
			return kimlikNo;
		}
		public void setKimlikNo(string iD)
		{
			kimlikNo = iD;
		}
		public int getEgitimNo()
		{
			return egitimNo;
		}
		public void setEgitimNo(int egitimNo)
		{
			this.egitimNo = egitimNo;
		}
		public int getBolumNo()
		{
			return bolumNo;
		}
		public void setBolumNo(int bolumNo)
		{
			this.bolumNo = bolumNo;
		}
		public int getGorevNo()
		{
			return gorevNo;
		}
		public void setGorevNo(int gorevNo)
		{
			this.gorevNo = gorevNo;
		}
		public string getPersonelAd()
		{
			return personelAd;
		}
		public void setPersonelAd(string personelAd)
		{
			this.personelAd = personelAd;
		}
		public string getPersonelSoyad()
		{
			return personelSoyad;
		}
		public void setPersonelSoyad(string personelSoyad)
		{
			this.personelSoyad = personelSoyad;
		}
		public DateTime getBaslamaTarih()
		{
			return baslamaTarih;
		}
		public void setBaslamaTarih(DateTime baslamaTarih)
		{
			this.baslamaTarih = baslamaTarih;
		}

		//
		public string getEgitimAd()
		{
			return egitimAd;
		}
		public void setEgitimAd(string egitimAd)
		{
			this.egitimAd = egitimAd;
		}
		public string getBolumAd()
		{
			return bolumAd;
		}
		public void setBolumAd(string bolumAd)
		{
			this.bolumAd = bolumAd;
		}
		public string getGorevAd()
		{
			return gorevAd;
		}
		public void setGorevAd(string gorevAd)
		{
			this.gorevAd = gorevAd;
		}
	}
}
