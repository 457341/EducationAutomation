using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EducationAutomation
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();/*
            user.setIdNo(inputUsername.Text);
            user.setPassword(inputPassword.Text);*/
            kullanici.setKimlikNo("11111111111");
            kullanici.setSifre("abcd");
            int result = DAO.giris(kullanici);

            if (result == 1)
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
            }
            else if (result ==2)
            {

            }
            else if (result == -1)
            {
                outputResult.Text = "Hatalı Giriş Yaptınız.\nLütfen Tekrar Deneyiniz.";
                outputResult.Visible = true ;
            }

        }
    }
}
