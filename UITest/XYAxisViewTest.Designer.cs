namespace UITest
{
    partial class XYAxisViewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XYAxisViewTest));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xyAxisView1 = new MyUILibrary.XYAxisView();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xyAxisView1
            // 
            this.xyAxisView1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xyAxisView1.Location = new System.Drawing.Point(5, 15);
            this.xyAxisView1.Margin = new System.Windows.Forms.Padding(6);
            this.xyAxisView1.Name = "xyAxisView1";
            this.xyAxisView1.setValue = ((System.Drawing.PointF)(resources.GetObject("xyAxisView1.setValue")));
            this.xyAxisView1.Size = new System.Drawing.Size(540, 267);
            this.xyAxisView1.TabIndex = 0;
            // 
            // XYAxisViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 282);
            this.Controls.Add(this.xyAxisView1);
            this.Name = "XYAxisViewTest";
            this.Text = "XYAxisViewTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUILibrary.XYAxisView xyAxisView1;
        private System.Windows.Forms.Timer timer1;
    }
}