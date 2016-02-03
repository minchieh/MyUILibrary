using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyUILibrary
{
    /// <summary>
    /// XY軸位置顯示
    /// </summary>
    public partial class XYAxisView : UserControl
    {
        #region 公開屬性

        /// <summary>
        /// 設定目前值
        /// </summary>
        protected PointF _setValue = new PointF(30, 80);
        /// <summary>
        /// 設定目前值
        /// </summary>
        public PointF setValue
        {
            get
            {
                return _setValue;
            }
            set
            {
                if (value.X != _setValue.X)
                {
                    axisView_X.setValue = value.X;
                }
                if (value.Y != _setValue.Y)
                {
                    axisView_Y.setValue = value.Y;
                }
                _setValue = value;
                this.Invalidate();
            }
        }

        #endregion

        #region 初始化

        /// <summary>
        /// 建構函數
        /// </summary>
        public XYAxisView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #endregion

        #region 繪圖

        /// <summary>
        /// 重繪
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // 格線
            float p = 0;
            for (int idx = 0; idx <= 100; idx += 10)
            {
                p = axisView_X.getAxisLabels[idx];
                g.DrawLine(Pens.Black,
                    axisView_X.Location.X + p,
                    axisView_Y.Location.Y + axisView_Y.getAxisLabels[0],
                    axisView_X.Location.X + p,
                    axisView_Y.Location.Y + axisView_Y.getAxisLabels[axisView_Y.getAxisLabels.Length - 1]);
            }
            for (int idx = 0; idx <= 100; idx += 10)
            {
                p = axisView_Y.getAxisLabels[idx];
                g.DrawLine(Pens.Black,
                    axisView_X.Location.X + axisView_X.getAxisLabels[0],
                    axisView_Y.Location.Y + p,
                    axisView_X.Location.X + axisView_X.getAxisLabels[axisView_X.getAxisLabels.Length - 1],
                    axisView_Y.Location.Y + p);
            }

            // 值標註
            //g.DrawLine(new Pen(Color.Blue, 3f),
            //    axisView_X.Location.X + axisView_X.getValueLabel + 6f,
            //    axisView_Y.Location.Y + axisView_Y.getAxisLabels[0],
            //    axisView_X.Location.X + axisView_X.getValueLabel + 6f,
            //    axisView_Y.Location.Y + axisView_Y.getValueLabel + 6f);
            //g.DrawLine(new Pen(Color.Blue, 3f),
            //   axisView_X.Location.X + axisView_X.getAxisLabels[0],
            //   axisView_Y.Location.Y + axisView_Y.getValueLabel + 6f,
            //   axisView_X.Location.X + axisView_X.getValueLabel + 6f,
            //   axisView_Y.Location.Y + axisView_Y.getValueLabel + 6f);
        }

        #endregion

        private void XYAxisView_Resize(object sender, EventArgs e)
        {
            axisView_X.Size = new Size(this.Width - 29, axisView_X.Size.Height);
            axisView_Y.Size = new Size(axisView_Y.Size.Width, this.Height - 29);
        }
    }
}
