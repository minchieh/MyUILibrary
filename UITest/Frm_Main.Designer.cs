namespace UITest
{
    partial class Frm_Main
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
            this.btn_ColorArrowTest = new System.Windows.Forms.Button();
            this.btn_ColorProgressBarTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ColorArrowTest
            // 
            this.btn_ColorArrowTest.Location = new System.Drawing.Point(12, 12);
            this.btn_ColorArrowTest.Name = "btn_ColorArrowTest";
            this.btn_ColorArrowTest.Size = new System.Drawing.Size(97, 23);
            this.btn_ColorArrowTest.TabIndex = 0;
            this.btn_ColorArrowTest.Text = "ColorArrowTest";
            this.btn_ColorArrowTest.UseVisualStyleBackColor = true;
            this.btn_ColorArrowTest.Click += new System.EventHandler(this.btn_ColorArrowTest_Click);
            // 
            // btn_ColorProgressBarTest
            // 
            this.btn_ColorProgressBarTest.Location = new System.Drawing.Point(12, 41);
            this.btn_ColorProgressBarTest.Name = "btn_ColorProgressBarTest";
            this.btn_ColorProgressBarTest.Size = new System.Drawing.Size(97, 23);
            this.btn_ColorProgressBarTest.TabIndex = 0;
            this.btn_ColorProgressBarTest.Text = "ColorProgressBarTest";
            this.btn_ColorProgressBarTest.UseVisualStyleBackColor = true;
            this.btn_ColorProgressBarTest.Click += new System.EventHandler(this.btn_ColorProgressBarTest_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_ColorProgressBarTest);
            this.Controls.Add(this.btn_ColorArrowTest);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ColorArrowTest;
        private System.Windows.Forms.Button btn_ColorProgressBarTest;
    }
}