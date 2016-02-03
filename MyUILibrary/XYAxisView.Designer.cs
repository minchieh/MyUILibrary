namespace MyUILibrary
{
    partial class XYAxisView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.axisView_Y = new MyUILibrary.AxisView();
            this.axisView_X = new MyUILibrary.AxisView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y\\X";
            // 
            // axisView_Y
            // 
            this.axisView_Y.Location = new System.Drawing.Point(4, 25);
            this.axisView_Y.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.axisView_Y.Name = "axisView_Y";
            this.axisView_Y.setAxisBackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.axisView_Y.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView_Y.setDirection = MyUILibrary.AxisView.DirectionEnum.Down;
            this.axisView_Y.setMaxValue = 100F;
            this.axisView_Y.setMinValue = 0F;
            this.axisView_Y.setPointColor = System.Drawing.Color.Firebrick;
            this.axisView_Y.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Right;
            this.axisView_Y.setTextColor = System.Drawing.Color.Black;
            this.axisView_Y.setTextDisplay = false;
            this.axisView_Y.setValue = 80F;
            this.axisView_Y.Size = new System.Drawing.Size(22, 225);
            this.axisView_Y.TabIndex = 0;
            // 
            // axisView_X
            // 
            this.axisView_X.Location = new System.Drawing.Point(26, 3);
            this.axisView_X.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.axisView_X.Name = "axisView_X";
            this.axisView_X.setAxisBackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.axisView_X.setAxisEdgeColor = System.Drawing.Color.Black;
            this.axisView_X.setDirection = MyUILibrary.AxisView.DirectionEnum.Right;
            this.axisView_X.setMaxValue = 100F;
            this.axisView_X.setMinValue = 0F;
            this.axisView_X.setPointColor = System.Drawing.Color.Firebrick;
            this.axisView_X.setPointDirection = MyUILibrary.AxisView.DirectionEnum.Down;
            this.axisView_X.setTextColor = System.Drawing.Color.Black;
            this.axisView_X.setTextDisplay = false;
            this.axisView_X.setValue = 30F;
            this.axisView_X.Size = new System.Drawing.Size(225, 22);
            this.axisView_X.TabIndex = 0;
            // 
            // XYAxisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axisView_Y);
            this.Controls.Add(this.axisView_X);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "XYAxisView";
            this.Size = new System.Drawing.Size(254, 254);
            this.Resize += new System.EventHandler(this.XYAxisView_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxisView axisView_X;
        private AxisView axisView_Y;
        private System.Windows.Forms.Label label1;
    }
}
