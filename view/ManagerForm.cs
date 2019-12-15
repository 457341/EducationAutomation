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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!panelStaff.isOpen)
            {
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y + 5, specialPanel2.Width, specialPanel2.Height);
                panelStaff.open(this.timer1);
            }
            
            if(panelStaff.isOpen)
            {
                specialPanel2.SetBounds(specialPanel2.Location.X, specialPanel2.Location.Y - 5, specialPanel2.Width, specialPanel2.Height);
                panelStaff.close(this.timer1);
            }
        }
        private void btnStaffOperation_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
    }
}
