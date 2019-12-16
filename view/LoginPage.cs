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
            User user = new User();/*
            user.setIdNo(inputUsername.Text);
            user.setPassword(inputPassword.Text);*/
            user.setIdNo("11111111111");
            user.setPassword("abcd");
            string result = DAO.login(user);

            if (result == "mudur" || result == "ceo")
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
            }
            else if (result == "mudur yardımcısı")
            {

            }
            else if (result == "error")
            {
                outputResult.Text = "Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz";
            }

        }
    }
}
