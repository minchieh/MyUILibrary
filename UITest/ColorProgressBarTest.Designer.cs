﻿namespace UITest
{
    partial class ColorProgressBarTest
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.colorProgressBar4 = new MyUILibrary.ColorProgressBar();
            this.colorProgressBar2 = new MyUILibrary.ColorProgressBar();
            this.colorProgressBar1 = new MyUILibrary.ColorProgressBar();
            this.colorProgressBar3 = new MyUILibrary.ColorProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // colorProgressBar4
            // 
            this.colorProgressBar4.Location = new System.Drawing.Point(63, 197);
            this.colorProgressBar4.Name = "colorProgressBar4";
            this.colorProgressBar4.setBackgroundColor = System.Drawing.Color.White;
            this.colorProgressBar4.setDirection = MyUILibrary.ColorProgressBar.DirectionEnum.Left;
            this.colorProgressBar4.setEdgeColor = System.Drawing.Color.Black;
            this.colorProgressBar4.setEdgeWidth = 3;
            this.colorProgressBar4.setEndColor = System.Drawing.Color.Crimson;
            this.colorProgressBar4.setStartColor = System.Drawing.Color.Plum;
            this.colorProgressBar4.setTextColor = System.Drawing.Color.Black;
            this.colorProgressBar4.setTextDisplay = true;
            this.colorProgressBar4.setValue = 50;
            this.colorProgressBar4.Size = new System.Drawing.Size(170, 31);
            this.colorProgressBar4.TabIndex = 0;
            // 
            // colorProgressBar2
            // 
            this.colorProgressBar2.Location = new System.Drawing.Point(63, 26);
            this.colorProgressBar2.Name = "colorProgressBar2";
            this.colorProgressBar2.setBackgroundColor = System.Drawing.Color.White;
            this.colorProgressBar2.setDirection = MyUILibrary.ColorProgressBar.DirectionEnum.Right;
            this.colorProgressBar2.setEdgeColor = System.Drawing.Color.Black;
            this.colorProgressBar2.setEdgeWidth = 3;
            this.colorProgressBar2.setEndColor = System.Drawing.Color.Crimson;
            this.colorProgressBar2.setStartColor = System.Drawing.Color.Plum;
            this.colorProgressBar2.setTextColor = System.Drawing.Color.Black;
            this.colorProgressBar2.setTextDisplay = true;
            this.colorProgressBar2.setValue = 50;
            this.colorProgressBar2.Size = new System.Drawing.Size(170, 31);
            this.colorProgressBar2.TabIndex = 0;
            // 
            // colorProgressBar1
            // 
            this.colorProgressBar1.Location = new System.Drawing.Point(237, 26);
            this.colorProgressBar1.Name = "colorProgressBar1";
            this.colorProgressBar1.setBackgroundColor = System.Drawing.Color.Transparent;
            this.colorProgressBar1.setDirection = MyUILibrary.ColorProgressBar.DirectionEnum.Up;
            this.colorProgressBar1.setEdgeColor = System.Drawing.Color.Transparent;
            this.colorProgressBar1.setEdgeWidth = 0;
            this.colorProgressBar1.setEndColor = System.Drawing.Color.Black;
            this.colorProgressBar1.setStartColor = System.Drawing.Color.Lavender;
            this.colorProgressBar1.setTextColor = System.Drawing.Color.DarkRed;
            this.colorProgressBar1.setTextDisplay = true;
            this.colorProgressBar1.setValue = 80;
            this.colorProgressBar1.Size = new System.Drawing.Size(35, 202);
            this.colorProgressBar1.TabIndex = 0;
            // 
            // colorProgressBar3
            // 
            this.colorProgressBar3.Location = new System.Drawing.Point(22, 26);
            this.colorProgressBar3.Name = "colorProgressBar3";
            this.colorProgressBar3.setBackgroundColor = System.Drawing.Color.Transparent;
            this.colorProgressBar3.setDirection = MyUILibrary.ColorProgressBar.DirectionEnum.Down;
            this.colorProgressBar3.setEdgeColor = System.Drawing.Color.Transparent;
            this.colorProgressBar3.setEdgeWidth = 0;
            this.colorProgressBar3.setEndColor = System.Drawing.Color.Black;
            this.colorProgressBar3.setStartColor = System.Drawing.Color.Lavender;
            this.colorProgressBar3.setTextColor = System.Drawing.Color.DarkRed;
            this.colorProgressBar3.setTextDisplay = true;
            this.colorProgressBar3.setValue = 80;
            this.colorProgressBar3.Size = new System.Drawing.Size(35, 202);
            this.colorProgressBar3.TabIndex = 0;
            // 
            // ColorProgressBarTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.colorProgressBar4);
            this.Controls.Add(this.colorProgressBar2);
            this.Controls.Add(this.colorProgressBar3);
            this.Controls.Add(this.colorProgressBar1);
            this.Name = "ColorProgressBarTest";
            this.Text = "ColorProgressBarTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUILibrary.ColorProgressBar colorProgressBar1;
        private MyUILibrary.ColorProgressBar colorProgressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MyUILibrary.ColorProgressBar colorProgressBar4;
        private MyUILibrary.ColorProgressBar colorProgressBar3;
    }
}