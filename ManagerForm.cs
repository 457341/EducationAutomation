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
                panelStaff.open(this.timer1);
            }
            
            if(panelStaff.isOpen)
            {
                panelStaff.close(this.timer1);
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
        }

        private void btnStaffOperation_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
