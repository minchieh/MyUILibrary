namespace UITest
{
    partial class ColorArrowButtonTest
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorArrowButton1 = new MyUILibrary.ColorArrowButton();
            this.colorArrowButton2 = new MyUILibrary.ColorArrowButton();
            this.colorArrowButton3 = new MyUILibrary.ColorArrowButton();
            this.colorArrowButton4 = new MyUILibrary.ColorArrowButton();
            this.SuspendLayout();
            // 
            // colorArrowButton1
            // 
            this.colorArrowButton1.Location = new System.Drawing.Point(12, 12);
            this.colorArrowButton1.Name = "colorArrowButton1";
            this.colorArrowButton1.setBackgroundColor = System.Drawing.Color.Black;
            this.colorArrowButton1.setDirection = MyUILibrary.ColorArrowButton.DirectionEnum.Left;
            this.colorArrowButton1.setEdgeWidth = 3;
            this.colorArrowButton1.setLevelDownColor = System.Drawing.Color.Red;
            this.colorArrowButton1.setLevelUpColor = System.Drawing.Color.Yellow;
            this.colorArrowButton1.Size = new System.Drawing.Size(100, 100);
            this.colorArrowButton1.TabIndex = 0;
            // 
            // colorArrowButton2
            // 
            this.colorArrowButton2.Location = new System.Drawing.Point(148, 12);
            this.colorArrowButton2.Name = "colorArrowButton2";
            this.colorArrowButton2.setBackgroundColor = System.Drawing.Color.DarkGray;
            this.colorArrowButton2.setDirection = MyUILibrary.ColorArrowButton.DirectionEnum.Right;
            this.colorArrowButton2.setEdgeWidth = 3;
            this.colorArrowButton2.setLevelDownColor = System.Drawing.Color.Green;
            this.colorArrowButton2.setLevelUpColor = System.Drawing.Color.Gold;
            this.colorArrowButton2.Size = new System.Drawing.Size(100, 100);
            this.colorArrowButton2.TabIndex = 0;
            // 
            // colorArrowButton3
            // 
            this.colorArrowButton3.Location = new System.Drawing.Point(12, 133);
            this.colorArrowButton3.Name = "colorArrowButton3";
            this.colorArrowButton3.setBackgroundColor = System.Drawing.Color.Firebrick;
            this.colorArrowButton3.setDirection = MyUILibrary.ColorArrowButton.DirectionEnum.Up;
            this.colorArrowButton3.setEdgeWidth = 3;
            this.colorArrowButton3.setLevelDownColor = System.Drawing.Color.DarkSeaGreen;
            this.colorArrowButton3.setLevelUpColor = System.Drawing.Color.Aqua;
            this.colorArrowButton3.Size = new System.Drawing.Size(100, 100);
            this.colorArrowButton3.TabIndex = 0;
            // 
            // colorArrowButton4
            // 
            this.colorArrowButton4.Location = new System.Drawing.Point(148, 133);
            this.colorArrowButton4.Name = "colorArrowButton4";
            this.colorArrowButton4.setBackgroundColor = System.Drawing.Color.LawnGreen;
            this.colorArrowButton4.setDirection = MyUILibrary.ColorArrowButton.DirectionEnum.Down;
            this.colorArrowButton4.setEdgeWidth = 3;
            this.colorArrowButton4.setLevelDownColor = System.Drawing.Color.DeepSkyBlue;
            this.colorArrowButton4.setLevelUpColor = System.Drawing.Color.AliceBlue;
            this.colorArrowButton4.Size = new System.Drawing.Size(100, 100);
            this.colorArrowButton4.TabIndex = 0;
            // 
            // ColorArrowButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.colorArrowButton4);
            this.Controls.Add(this.colorArrowButton3);
            this.Controls.Add(this.colorArrowButton2);
            this.Controls.Add(this.colorArrowButton1);
            this.Name = "ColorArrowButtonTest";
            this.Text = "ColorArrowButtonTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUILibrary.ColorArrowButton colorArrowButton1;
        private MyUILibrary.ColorArrowButton colorArrowButton2;
        private MyUILibrary.ColorArrowButton colorArrowButton3;
        private MyUILibrary.ColorArrowButton colorArrowButton4;
    }
}

