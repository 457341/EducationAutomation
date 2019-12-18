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
    public partial class EditStaff : Form
    {
        bool check1, check2, check3 = false;
        string oncekiKimlikNo;
        public EditStaff()
        {
            InitializeComponent();
        }
        private void EditStaff_Load(object sender, EventArgs e)
        {
            outputStaffList.DataSource = DAO.personelListele(new Personel()).Tables[0];
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            if (inputID.Text.Length != 11)
            {
                geriDonus.Text = "TC Kimlik Numarası 11 karakter uzunluğunda olmak zorundadır.";
                timer1.Start();
            }
            else if (textInputEducation.Text == "" || textInputDepartment.Text== "" || textInputTask.Text == "")
            {
                geriDonus.Text = "Departman, Eğitim Seviyesi ve Görevi Boş Bırakmayınız. ";
                timer1.Start();
            }
            else
            {
                personel.setKimlikNo(inputID.Text);
                personel.setPersonelAd(inputName.Text);
                personel.setPersonelSoyad(inputSurname.Text);
                personel.setEgitimAd(textInputEducation.Text);
                personel.setBolumAd(textInputDepartment.Text);
                personel.setGorevAd(textInputTask.Text);
                personel.setBaslamaTarih(dateTimePicker1.Value.Date);
            }
            if (DAO.personelEkle(personel))
            {
                geriDonus.Text = "Ekleme işlemi başarılı.Tablo Yenilendi";
                geriDonus.Visible = true;
                timer1.Start();
            }
            else
            {
                geriDonus.Text = "İşlem başarısız.Girdiginiz bilgileri kontrol ediniz.";
                geriDonus.Visible = true;
                timer1.Start();
            }
            outputStaffList.DataSource = DAO.personelListele(new Personel()).Tables[0];
        }
        private void sifirla()
        {
            inputID.Text = "";
            inputName.Text = "";
            inputSurname.Text = "";
            textInputDepartment.Text = "";
            textInputTask.Text = "";
            textInputEducation.Text = "";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            sifirla();  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            if (inputID.Text.Length != 11)
            {
                geriDonus.Text = "TC Kimlik Numarası 11 karakter uzunluğunda olmak zorundadır.";
                geriDonus.Visible = true;
                timer1.Start();
            }
            else
            {
                personel.setKimlikNo(inputID.Text);
                DAO.personelEkle(personel);
            }
            outputStaffList.DataSource = DAO.personelListele(new Personel()).Tables[0];
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void outputStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inputID.Text = outputStaffList.CurrentRow.Cells[0].Value.ToString();
            oncekiKimlikNo = outputStaffList.CurrentRow.Cells[0].Value.ToString();
            inputName.Text = outputStaffList.CurrentRow.Cells[1].Value.ToString();
            inputSurname.Text = outputStaffList.CurrentRow.Cells[2].Value.ToString();
            textInputDepartment.Text = outputStaffList.CurrentRow.Cells[4].Value.ToString();
            textInputEducation.Text = outputStaffList.CurrentRow.Cells[6].Value.ToString();
            textInputTask.Text = outputStaffList.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = outputStaffList.CurrentRow.Cells[3].Value.ToString();
        }
        //CheckBox işlemleri
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!check1)
            {
                comboBoxDepartment.Visible = false;
                textInputDepartment.Visible = true;
                check1 = true;
            }
            else
            {
                comboBoxDepartment.Visible = true;
                textInputDepartment.Visible = false;
                check1 = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!check2)
            {
                comboBoxTask.Visible = false;
                textInputEducation.Visible = true;
                check2 = true;
            }
            else
            {

                comboBoxTask.Visible = true;
                textInputEducation.Visible = false;
                check2 = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geriDonus.Visible = false;
            timer1.Stop();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {/*
            if (!check3)
            {
                comboBoxEducation.Visible = false;
                textInputTask.Visible = true;
                check3 = true;
            }
            else
            {

                comboBoxEducation.Visible = true;
                textInputTask.Visible = false;
                check3 = false;
            }*/
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.UtcNow;
        }
    }
}
