using System;
using System.Windows.Forms;

namespace UITest
{
    public partial class ColorProgressBarTest : Form
    {
        public ColorProgressBarTest()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (colorProgressBar1.setValue == 100)
            {
                colorProgressBar1.setValue = 0;
                colorProgressBar3.setValue = 0;
            }
            else
            {
                colorProgressBar1.setValue++;
                colorProgressBar3.setValue++;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (colorProgressBar2.setValue == 100)
            {
                colorProgressBar2.setValue = 0;
                colorProgressBar4.setValue = 0;
            }
            else
            {
                colorProgressBar2.setValue++;
                colorProgressBar4.setValue++;
            }
        }
    }
}
