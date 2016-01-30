using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UITest
{
    public partial class AxisViewTest : Form
    {
        public AxisViewTest()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axisView1.setValue + 1 >= axisView1.setMaxValue)
            {
                axisView1.setValue = axisView1.setMinValue;
                axisView2.setValue = axisView2.setMinValue;
                axisView3.setValue = axisView3.setMinValue;
                axisView4.setValue = axisView4.setMinValue;
            }
            else
            {
                axisView1.setValue++;
                axisView2.setValue++;
                axisView3.setValue++;
                axisView4.setValue++;
            }
        }
    }
}
