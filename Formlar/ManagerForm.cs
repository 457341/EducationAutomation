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
    public partial class ManagerForm : Form
    {

        public ManagerForm()
        {
            InitializeComponent();
        }
        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff();
            showStaff.MdiParent = this;
            showStaff.Show();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            editStaff.MdiParent = this;
            editStaff.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        //Animasyon Kısmı
        private void btnStaffOperation_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!panelStaff.isOpen)
            {
                specialPanel1.SetBounds(specialPanel1.Location.X, specialPanel1.Location.Y + 5, specialPanel1.Width, specialPanel1.Height);
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y + 5, specialPanel2.Width, specialPanel2.Height);
                panelStaff.open(145, this.timer1);
            }

            if (panelStaff.isOpen)
            {
                specialPanel1.SetBounds(specialPanel1.Location.X, specialPanel1.Location.Y - 5, specialPanel1.Width, specialPanel1.Height);
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y - 5, specialPanel2.Width, specialPanel2.Height);
                panelStaff.close(this.timer1);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            if (!specialPanel1.isOpen)
            {
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y + 5, specialPanel2.Width, specialPanel2.Height);
                specialPanel1.open(184, this.timer2);
            }

            if (specialPanel1.isOpen)
            {
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y - 5, specialPanel2.Width, specialPanel2.Height);
                specialPanel1.close(this.timer2);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!specialPanel2.isOpen)
            {
                specialPanel2.open(184, this.timer3);
            }

            if (specialPanel2.isOpen)
            {
                specialPanel2.close(this.timer3);
            }
        }
    }
}
