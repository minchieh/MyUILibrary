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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_ColorArrowTest_Click(object sender, EventArgs e)
        {
            ColorArrowButtonTest obj = new ColorArrowButtonTest();
            obj.Show();
        }

        private void btn_ColorProgressBarTest_Click(object sender, EventArgs e)
        {
            ColorProgressBarTest obj = new ColorProgressBarTest();
            obj.Show();
        }
    }
}
