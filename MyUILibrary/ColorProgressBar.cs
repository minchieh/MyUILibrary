using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyUILibrary
{
    public partial class ColorProgressBar : UserControl
    {
        #region 列舉

        /// <summary>
        /// 方向列舉
        /// </summary>
        /// <summary>
        /// 箭頭指向方向
        /// </summary>
        public enum DirectionEnum
        {
            /// <summary>
            /// 左
            /// </summary>
            Left,
            /// <summary>
            /// 右
            /// </summary>
            Right,
            /// <summary>
            /// 上
            /// </summary>
            Up,
            /// <summary>
            /// 下
            /// </summary>
            Down
        }

        #endregion

        #region 事件委派

        #endregion

        #region 公開屬性

        /// <summary>
        /// 設定進度方向
        /// </summary>
        protected DirectionEnum _setDirection = DirectionEnum.Right;
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

        /// <summary>
        /// 設定進度值
        /// </summary>
        protected int _setValue = 0;
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

        /// <summary>
        /// 設定背景顏色
        /// </summary>
        protected Color _setBackgroundColor = Color.White;
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

        /// <summary>
        /// 設定起始顏色
        /// </summary>
        protected Color _setStartColor = Color.OrangeRed;
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

        /// <summary>
        /// 設定結束顏色
        /// </summary>
        protected Color _setEndColor = Color.DarkRed;
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

        /// <summary>
        /// 設定邊框顏色
        /// </summary>
        protected Color _setEdgeColor = Color.Black;
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

        /// <summary>
        /// 設定文字顏色
        /// </summary>
        protected Color _setTextColor = Color.Black;
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

        /// <summary>
        /// 設定線框
        /// </summary>
        protected int _setEdgeWidth = 3;
        /// <summary>
        /// 設定線框
        /// </summary>
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

        /// <summary>
        /// 設定進度文字是否顯示
        /// </summary>
        protected bool _setTextDisplay = true;
        /// <summary>
        /// 設定進度文字是否顯示
        /// </summary>
        public bool setTextDisplay
        {
            get
            {
                return _setTextDisplay;
            }
            set
            {
                if (_setTextDisplay != value)
                {
                    _setTextDisplay = value;
                    this.Invalidate();
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

            // 啟用雙緩衝
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
            Graphics g = e.Graphics;

            // 邊框
            float h_low = _setEdgeWidth;
            float h_high = Height - _setEdgeWidth;
            float w_low = _setEdgeWidth;
            float w_high = Width - _setEdgeWidth;

            PointF[] edgePoints = new PointF[5];
            edgePoints[0] = new PointF(w_low, h_low);
            edgePoints[1] = new PointF(w_low, h_high);
            edgePoints[2] = new PointF(w_high, h_high);
            edgePoints[3] = new PointF(w_high, h_low);
            edgePoints[4] = edgePoints[0];

            // 繪製背景
            Brush backgroundBrush = new SolidBrush(_setBackgroundColor);
            g.FillPolygon(backgroundBrush, edgePoints);
            backgroundBrush.Dispose();

            // 繪製邊框
            Pen edgePen = new Pen(_setEdgeColor, _setEdgeWidth);
            g.DrawLines(edgePen, edgePoints);
            edgePen.Dispose();

            // 繪製進度 
            if (_setValue == 0)
            {
                return;
            }
            RectangleF progressRectangle = new RectangleF(0, 0, 100, 100);
            LinearGradientBrush progressBrush = new LinearGradientBrush(progressRectangle, _setStartColor, _setEndColor, LinearGradientMode.Horizontal);

            w_low = 1.5f * w_low;
            h_low = 1.5f * h_low;
            w_high = w_high - 0.5f * _setEdgeWidth;
            h_high = h_high - 0.5f * _setEdgeWidth;

            float v;
            switch (_setDirection)
            {
                case DirectionEnum.Right:
                    v = (w_high - w_low) * _setValue / 100;
                    progressRectangle = new RectangleF(w_low, h_low, v, h_high - h_low);
                    progressBrush = new LinearGradientBrush(progressRectangle, _setStartColor, _setEndColor, LinearGradientMode.Horizontal);
                    break;
                case DirectionEnum.Left:
                    v = (w_high - w_low) * _setValue / 100;
                    progressRectangle = new RectangleF(w_high - v, h_low, v, h_high - h_low);
                    progressBrush = new LinearGradientBrush(progressRectangle, _setStartColor, _setEndColor, -180f);
                    break;
                case DirectionEnum.Up:
                    v = (h_high - h_low) * _setValue / 100;
                    progressRectangle = new RectangleF(w_low, h_high - v, w_high - w_low, v);
                    progressBrush = new LinearGradientBrush(progressRectangle, _setStartColor, _setEndColor, -90f);
                    break;
                case DirectionEnum.Down:
                    v = (h_high - h_low) * _setValue / 100;
                    progressRectangle = new RectangleF(w_low, h_low, w_high - w_low, v);
                    progressBrush = new LinearGradientBrush(progressRectangle, _setStartColor, _setEndColor, 90f);
                    break;

            }
            g.FillRectangle(progressBrush, progressRectangle);

            // 繪製進度文字
            if (_setTextDisplay)
            {
                int size = 14;

                // 量測文字尺寸
                Font font = new Font("Arial", size);
                SizeF textSize = g.MeasureString(_setValue.ToString(), font);

                modifyLoop:
                if (size == 1)
                {
                    goto modifyFinish;
                }

                switch (_setDirection)
                {
                    case DirectionEnum.Right:
                    case DirectionEnum.Left:
                        if (textSize.Height > Height)
                        {
                            --size;
                            font.Dispose();
                            font = new Font("Arial", size);
                            textSize = g.MeasureString(_setValue.ToString(), font);
                            goto modifyLoop;
                        }
                        break;
                    case DirectionEnum.Up:
                    case DirectionEnum.Down:
                        if (textSize.Width > Width)
                        {
                            --size;
                            font.Dispose();
                            font = new Font("Arial", size);
                            textSize = g.MeasureString(_setValue.ToString(), font);
                            goto modifyLoop;
                        }
                        break;
                }

                modifyFinish:
                PointF textPoint = new PointF((_setEdgeWidth + Width - textSize.Width) / 2,
                    (_setEdgeWidth + Height - textSize.Height) / 2);

                Brush textBrush = new SolidBrush(_setTextColor);
                g.DrawString(_setValue.ToString(), font, textBrush, textPoint);

                textBrush.Dispose();
                font.Dispose();
            }

            progressBrush.Dispose();

        }

        #endregion
    }
}
