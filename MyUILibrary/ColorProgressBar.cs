using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyUILibrary
{
    public partial class ColorProgressBar : UserControl
    {
        #region 列舉

        /// <summary>
        /// 方向列舉
        /// </summary>
        public enum DirectionEnum
        {
            /// <summary>
            /// 水平
            /// </summary>
            Horizontal,
            /// <summary>
            /// 垂直
            /// </summary>
            Vertical
        }

        #endregion

        #region 事件委派

        #endregion

        #region 公開屬性

        internal DirectionEnum _setDirection = DirectionEnum.Horizontal;
        /// <summary>
        /// 設定進度方向
        /// </summary>
        public DirectionEnum setDirection
        {
            get
            {
                return _setDirection;
            }
            set
            {
                if (_setDirection != value)
                {
                    _setDirection = value;
                    this.Invalidate();
                }
            }
        }

        internal int _setValue = 0;
        /// <summary>
        /// 設定進度值
        /// </summary>
        public int setValue
        {
            get
            {
                return _setValue;
            }
            set
            {
                if (_setValue != value)
                {
                    if (value >= 0 && value <= 100)
                    {
                        _setValue = value;
                        this.Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("設定值須在 0 ~ 100 之間");
                    }
                }
            }
        }

        #region 顏色

        internal Color _setBackgroundColor = Color.White;
        /// <summary>
        /// 設定背景顏色
        /// </summary>
        public Color setBackgroundColor
        {
            get
            {
                return _setBackgroundColor;
            }
            set
            {
                if (_setBackgroundColor != value)
                {
                    _setBackgroundColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setStartColor = Color.OrangeRed;
        /// <summary>
        /// 設定起始顏色
        /// </summary>
        public Color setStartColor
        {
            get
            {
                return _setStartColor;
            }
            set
            {
                if (_setStartColor != value)
                {
                    _setStartColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setEndColor = Color.DarkRed;
        /// <summary>
        /// 設定結束顏色
        /// </summary>
        public Color setEndColor
        {
            get
            {
                return _setEndColor;
            }
            set
            {
                if (_setEndColor != value)
                {
                    _setEndColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setEdgeColor = Color.Black;
        /// <summary>
        /// 設定邊框顏色
        /// </summary>
        public Color setEdgeColor
        {
            get
            {
                return _setEdgeColor;
            }
            set
            {
                if (_setEdgeColor != value)
                {
                    _setEdgeColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setTextColor = Color.Black;
        /// <summary>
        /// 設定文字顏色
        /// </summary>
        public Color setTextColor
        {
            get
            {
                return _setTextColor;
            }
            set
            {
                if (_setTextColor != value)
                {
                    _setTextColor = value;
                    this.Invalidate();
                }
            }
        }

        #endregion

        internal int _setEdgeWidth = 3;
        public int setEdgeWidth
        {
            get
            {
                return _setEdgeWidth;
            }
            set
            {
                if (value >= 0)
                {
                    _setEdgeWidth = value;
                    this.Invalidate();
                }
                else
                {
                    MessageBox.Show("設定值需大於 0");
                }
            }
        }

        #endregion

        #region 初始化

        /// <summary>
        /// 建構函數
        /// </summary>
        public ColorProgressBar()
        {
            InitializeComponent();
        }

        #endregion

        #region 繪圖

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 邊框
            float h_low = _setEdgeWidth;
            float h_high = Height - _setEdgeWidth;
            float w_low = _setEdgeWidth;
            float w_high = Width - _setEdgeWidth;

            PointF[] EdgePoints = new PointF[5];
            EdgePoints[0] = new PointF(w_low, h_low);
            EdgePoints[1] = new PointF(w_low, h_high);
            EdgePoints[2] = new PointF(w_high, h_high);
            EdgePoints[3] = new PointF(w_high, h_low);
            EdgePoints[4] = EdgePoints[0];

            // 繪製背景
            Brush BackgroundBrush = new SolidBrush(_setBackgroundColor);
            g.FillPolygon(BackgroundBrush, EdgePoints);
            BackgroundBrush.Dispose();


            // 繪製邊框
            Pen EdgePen = new Pen(_setEdgeColor, _setEdgeWidth);
            g.DrawLines(EdgePen, EdgePoints);
            EdgePen.Dispose();

            if (_setValue == 0)
            {
                return;
            }

            // 繪製進度
            RectangleF ProgressRectangle = new RectangleF(0, 0, 100, 100);
            LinearGradientBrush ProgressBrush = new LinearGradientBrush(ProgressRectangle, _setStartColor, _setEndColor, LinearGradientMode.Horizontal);

            w_low = 1.5f * w_low;
            h_low = 1.5f * h_low;
            w_high = w_high - 0.5f * _setEdgeWidth;
            h_high = h_high - 0.5f * _setEdgeWidth;

            float v;
            if (_setDirection == DirectionEnum.Horizontal)
            {
                v = (w_high - w_low) * _setValue / 100;

                ProgressRectangle = new RectangleF(w_low, h_low, v, h_high - h_low);
                ProgressBrush = new LinearGradientBrush(ProgressRectangle, _setStartColor, _setEndColor, LinearGradientMode.Horizontal);
            }
            else
            {
                v = (h_high - h_low) * _setValue / 100;

                ProgressRectangle = new RectangleF(w_low, h_low, w_high - w_low, v);
                ProgressBrush = new LinearGradientBrush(ProgressRectangle, _setStartColor, _setEndColor, LinearGradientMode.Vertical);
            }

            g.FillRectangle(ProgressBrush, ProgressRectangle);

            ProgressBrush.Dispose();
            

        }

        #endregion
    }
}
