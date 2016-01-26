﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            }
            else
            {
                colorProgressBar1.setValue++;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (colorProgressBar2.setValue == 100)
            {
                colorProgressBar2.setValue = 0;
            }
            else
            {
                colorProgressBar2.setValue++;
            }
        }
    }
}
