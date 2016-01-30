namespace UITest
{
    partial class AxisViewTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axisView3 = new MyUILibrary.AxisView();
            this.axisView2 = new MyUILibrary.AxisView();
            this.axisView1 = new MyUILibrary.AxisView();
            this.axisView4 = new MyUILibrary.AxisView();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axisView3
            // 
            this.axisView3.Location = new System.Drawing.Point(588, 12);
            this.axisView3.Name = "axisView3";
            this.axisView3.setAxisBackgroundColor = System.Drawing.Color.Gray;
            this.axisView3.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView3.setDirection = MyUILibrary.AxisView.DirectionEnum.Up;
            this.axisView3.setMaxValue = 100F;
            this.axisView3.setMinValue = 0F;
            this.axisView3.setPointColor = System.Drawing.Color.LightCoral;
            this.axisView3.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Right;
            this.axisView3.setTextColor = System.Drawing.Color.Black;
            this.axisView3.setTextDisplay = true;
            this.axisView3.setValue = 50F;
            this.axisView3.Size = new System.Drawing.Size(62, 390);
            this.axisView3.TabIndex = 0;
            // 
            // axisView2
            // 
            this.axisView2.Location = new System.Drawing.Point(12, 75);
            this.axisView2.Name = "axisView2";
            this.axisView2.setAxisBackgroundColor = System.Drawing.Color.Gray;
            this.axisView2.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView2.setDirection = MyUILibrary.AxisView.DirectionEnum.Left;
            this.axisView2.setMaxValue = 100F;
            this.axisView2.setMinValue = 0F;
            this.axisView2.setPointColor = System.Drawing.Color.LightCoral;
            this.axisView2.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Down;
            this.axisView2.setTextColor = System.Drawing.Color.Black;
            this.axisView2.setTextDisplay = true;
            this.axisView2.setValue = 50F;
            this.axisView2.Size = new System.Drawing.Size(453, 57);
            this.axisView2.TabIndex = 0;
            // 
            // axisView1
            // 
            this.axisView1.Location = new System.Drawing.Point(12, 12);
            this.axisView1.Name = "axisView1";
            this.axisView1.setAxisBackgroundColor = System.Drawing.Color.Gray;
            this.axisView1.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView1.setDirection = MyUILibrary.AxisView.DirectionEnum.Right;
            this.axisView1.setMaxValue = 100F;
            this.axisView1.setMinValue = 0F;
            this.axisView1.setPointColor = System.Drawing.Color.LightCoral;
            this.axisView1.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Up;
            this.axisView1.setTextColor = System.Drawing.Color.Black;
            this.axisView1.setTextDisplay = true;
            this.axisView1.setValue = 50F;
            this.axisView1.Size = new System.Drawing.Size(453, 57);
            this.axisView1.TabIndex = 0;
            // 
            // axisView4
            // 
            this.axisView4.Location = new System.Drawing.Point(498, 12);
            this.axisView4.Name = "axisView4";
            this.axisView4.setAxisBackgroundColor = System.Drawing.Color.Gray;
            this.axisView4.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView4.setDirection = MyUILibrary.AxisView.DirectionEnum.Down;
            this.axisView4.setMaxValue = 100F;
            this.axisView4.setMinValue = 0F;
            this.axisView4.setPointColor = System.Drawing.Color.LightCoral;
            this.axisView4.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Left;
            this.axisView4.setTextColor = System.Drawing.Color.Black;
            this.axisView4.setTextDisplay = true;
            this.axisView4.setValue = 50F;
            this.axisView4.Size = new System.Drawing.Size(62, 390);
            this.axisView4.TabIndex = 0;
            // 
            // AxisViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 414);
            this.Controls.Add(this.axisView4);
            this.Controls.Add(this.axisView3);
            this.Controls.Add(this.axisView2);
            this.Controls.Add(this.axisView1);
            this.Name = "AxisViewTest";
            this.Text = "AxisViewTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUILibrary.AxisView axisView1;
        private System.Windows.Forms.Timer timer1;
        private MyUILibrary.AxisView axisView2;
        private MyUILibrary.AxisView axisView3;
        private MyUILibrary.AxisView axisView4;
    }
}