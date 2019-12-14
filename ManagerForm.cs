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
            bool isOpen = false;
            if (!isOpen)
            {
                panelStaff.Height += 5;

                if (panelStaff.Width > 199)
                {
                    isOpen = true;
                    timer1.Stop();
                }
            }
            else
            {
                panelStaff.Height -= 5;

                if (panelStaff.Width < 81)
                {
                    isOpen = false;
                    timer1.Stop();
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
