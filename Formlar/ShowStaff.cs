using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomation
{
    public partial class ShowStaff : Form
    {
        Personel personel = new Personel();

        public ShowStaff()
        {
            InitializeComponent();
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'egitimVeriTabaniDataSet.tBolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumTableAdapter.Fill(this.egitimVeriTabaniDataSet.tBolum);
            outputStaffList.DataSource = DAO.personelListele(new Personel()).Tables[0];
            //comboBox1.DataSource = DAO.bolumListele();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            personel.setGorevNo(0);
            personel.setEgitimNo(0);
            personel.setBolumNo(0);
            outputStaffList.DataSource = DAO.personelListele(personel).Tables[0];
        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {
            personel.setKimlikNo(inputID.Text);
            outputStaffList.DataSource = DAO.personelListele(personel).Tables[0];
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            personel.setPersonelAd(inputName.Text);
            outputStaffList.DataSource = DAO.personelListele(personel).Tables[0];
        }

        private void inputSurname_TextChanged(object sender, EventArgs e)
        {
            personel.setPersonelSoyad(inputSurname.Text);
            outputStaffList.DataSource = DAO.personelListele(personel).Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
