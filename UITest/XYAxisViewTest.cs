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
    public partial class XYAxisViewTest : Form
    {
        public XYAxisViewTest()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i==100)
            {
                i = 0;
            }
            xyAxisView1.setValue = new PointF(i, i);
            i++;
        }
    }
}
