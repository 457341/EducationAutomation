using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomation
{
    class SpecialPanel : Panel
    {
        public bool isOpen = false;
        public SpecialPanel()
        {
        }
        public void open(Timer timer)
        {
            if (!isOpen)
            {
                this.Height = this.Height + 5;
                if (this.Height == 180)
                {
                    isOpen = true;
                    timer.Stop();
                }
            }
        }
        public void close(Timer timer)
        {
            if (isOpen)
            {

                this.Height = this.Height - 5;
                if (this.Height == 60)
                {
                    isOpen = false;
                    timer.Stop();

                }
            }
        }
    }
}
