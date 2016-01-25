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

    /// <summary>
    /// 分層顏色箭頭按鈕
    /// </summary>
    public partial class ColorArrowButton : UserControl
    {
        #region 事件委派

        /// <summary>
        /// 滑鼠點擊事件
        /// </summary>
        public event MouseEventHandler MouseDownEvent;

        /// <summary>
        /// 滑鼠放開事件
        /// </summary>
        public event MouseEventHandler MouseUpEvent;

        /// <summary>
        /// 滑鼠移動事件
        /// </summary>
        public event MouseEventHandler MouseMoveEvent;

        #endregion

        #region 公開屬性

        internal DirectionEnum _setDirection = DirectionEnum.Left;
        /// <summary>
        /// 設置箭頭方向
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

                    _generationLevelPointProcess = true;
                    this.Invalidate();
                }
            }
        }

        internal Color _setLevelDownColor = Color.Red;
        /// <summary>
        /// 設置分層選中按下顏色
        /// </summary>
        public Color setLevelDownColor
        {
            get
            {
                return _setLevelDownColor;
            }
            set
            {
                if (_setLevelDownColor != value)
                {
                    _setLevelDownColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setLevelUpColor = Color.Yellow;
        /// <summary>
        /// 設置分層選中放開顏色
        /// </summary>
        public Color setLevelUpColor
        {
            get
            {
                return _setLevelUpColor;
            }
            set
            {
                if (_setLevelUpColor != value)
                {
                    _setLevelUpColor = value;
                    this.Invalidate();
                }
            }
        }

        internal Color _setBackgroundColor = Color.Black;
        /// <summary>
        /// 設置箭頭背景顏色
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

        internal int _setEdgeWidth = 3;
        /// <summary>
        /// 設定邊線寬度
        /// </summary>
        public int setEdgeWidth
        {
            get
            {
                return _setEdgeWidth;
            }
            set
            {
                if (_setEdgeWidth != value)
                {
                    _setEdgeWidth = value;
                    _generationLevelPointProcess = true;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #region 唯讀屬性

        internal Point[,] _getLevelPoint = new Point[4, 4];
        /// <summary>
        /// 取得各層級所有點
        /// 共4層級, 每1層級內有4點存放(層級4為三角形只有3點)
        /// </summary>
        public Point[,] getLevelPoint
        {
            get
            {
                return _getLevelPoint;
            }
        }


        internal int _getLevel = -1;
        /// <summary>
        /// 取得目前選取層級
        /// </summary>
        public int getLevel
        {
            get
            {
                // 運算目前所在層級
                int X = _getMouseStatus.X;
                int Y = _getMouseStatus.Y;

                _getLevel = -1;

                if (_mouseEnter)
                {
                    switch (_setDirection)
                    {
                        case DirectionEnum.Left:
                            if (X <= _getLevelPoint[0, 0].X && X > _getLevelPoint[1, 0].X)
                            {
                                _getLevel = 1;
                            }
                            else if (X <= _getLevelPoint[1, 0].X && X > _getLevelPoint[2, 0].X)
                            {
                                _getLevel = 2;
                            }
                            else if (X <= _getLevelPoint[2, 0].X && X > _getLevelPoint[3, 0].X)
                            {
                                _getLevel = 3;
                            }
                            else if (X <= _getLevelPoint[3, 0].X && X > _getLevelPoint[3, 3].X)
                            {
                                _getLevel = 4;
                            }
                            break;
                        case DirectionEnum.Right:
                            if (X >= _getLevelPoint[0, 0].X && X < _getLevelPoint[1, 0].X)
                            {
                                _getLevel = 1;
                            }
                            else if (X >= _getLevelPoint[1, 0].X && X < _getLevelPoint[2, 0].X)
                            {
                                _getLevel = 2;
                            }
                            else if (X >= _getLevelPoint[2, 0].X && X < _getLevelPoint[3, 0].X)
                            {
                                _getLevel = 3;
                            }
                            else if (X >= _getLevelPoint[3, 0].X && X < _getLevelPoint[3, 3].X)
                            {
                                _getLevel = 4;
                            }
                            break;
                        case DirectionEnum.Up:
                            if (Y <= _getLevelPoint[0, 0].Y && Y > _getLevelPoint[1, 0].Y)
                            {
                                _getLevel = 1;
                            }
                            else if (Y <= _getLevelPoint[1, 0].Y && Y > _getLevelPoint[2, 0].Y)
                            {
                                _getLevel = 2;
                            }
                            else if (Y <= _getLevelPoint[2, 0].Y && Y > _getLevelPoint[3, 0].Y)
                            {
                                _getLevel = 3;
                            }
                            else if (Y <= _getLevelPoint[3, 0].Y && Y > _getLevelPoint[3, 3].Y)
                            {
                                _getLevel = 4;
                            }
                            break;
                        case DirectionEnum.Down:
                            if (Y >= _getLevelPoint[0, 0].Y && Y < _getLevelPoint[1, 0].Y)
                            {
                                _getLevel = 1;
                            }
                            else if (Y >= _getLevelPoint[1, 0].Y && Y < _getLevelPoint[2, 0].Y)
                            {
                                _getLevel = 2;
                            }
                            else if (Y >= _getLevelPoint[2, 0].Y && Y < _getLevelPoint[3, 0].Y)
                            {
                                _getLevel = 3;
                            }
                            else if (Y >= _getLevelPoint[3, 0].Y && Y < _getLevelPoint[3, 3].Y)
                            {
                                _getLevel = 4;
                            }
                            break;
                    }
                }
                return _getLevel;
            }
        }

        internal MouseEventArgs _getMouseStatus = new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0);
        /// <summary>
        /// 取得目前滑鼠狀態
        /// </summary>
        public MouseEventArgs getMouseStatus
        {
            get
            {
                return _getMouseStatus;
            }
        }

        #endregion

        #region 內部變數

        internal bool _generationLevelPointProcess = true;
        internal bool _mouseEnter = false;

        #endregion

        #region 初始化

        /// <summary>
        /// 建構函數
        /// </summary>
        public ColorArrowButton()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // 註冊滑鼠事件
            this.MouseDown += ColorArrowButton_MouseDown;
            this.MouseUp += ColorArrowButton_MouseUp;
            this.MouseMove += ColorArrowButton_MouseMove;
            this.MouseLeave += ColorArrowButton_MouseLeave;
            this.MouseEnter += ColorArrowButton_MouseEnter;

            // 註冊尺寸事件
            this.Resize += ColorArrowButton_Resize;
        }


        #endregion

        #region 繪圖

        /// <summary>
        /// 重載 OnPaint 
        /// </summary>
        /// <param name="e">繪圖參數</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 取得控制項長寬

            // 產生4層級所需點
            if (_generationLevelPointProcess)
            {
                GenerationLevelPoint(this.Height, this.Width);
            }

            // 畫三角路徑
            using (Pen pathPen = new Pen(_setBackgroundColor, _setEdgeWidth))
            {
                g.DrawLine(pathPen, _getLevelPoint[0, 0], _getLevelPoint[3, 3]);
                g.DrawLine(pathPen, _getLevelPoint[3, 3], _getLevelPoint[0, 1]);
                g.DrawLine(pathPen, _getLevelPoint[0, 1], _getLevelPoint[0, 0]);
            }

            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            GraphicsPath gp;
            for (int idx = 0; idx < 4; idx++)
            {
                gp = new GraphicsPath(FillMode.Alternate);
                if (getLevel == -1 || idx > getLevel - 1)
                {
                    drawBrush = new SolidBrush(_setBackgroundColor);
                }
                else
                {
                    if (_getMouseStatus.Button == MouseButtons.Left)
                    {
                        drawBrush = new SolidBrush(_setLevelDownColor);
                    }
                    else
                    {
                        drawBrush = new SolidBrush(_setLevelUpColor);
                    }
                }

                gp.AddPolygon(new Point[4] { _getLevelPoint[idx, 0], _getLevelPoint[idx, 1], _getLevelPoint[idx, 2], _getLevelPoint[idx, 3] });

                g.FillPath(drawBrush, gp);

                drawBrush.Dispose();
                gp.Dispose();
            }


        }

        private void GenerationLevelPoint(int heigth, int width)
        {
            int w1 = 0; int w2 = 0; int w3 = 0; int w4 = 0; int w5 = 0;
            int h1 = 0; int h2 = 0; int h3 = 0; int h4 = 0; int h5 = 0;

            int w01 = 0; int w11 = 0; int w02 = 0; int w12 = 0; int w03 = 0; int w13 = 0;
            int w04 = 0; int w14 = 0; int w05 = 0; int w15 = 0;
            int h01 = 0; int h11 = 0; int h02 = 0; int h12 = 0; int h03 = 0; int h13 = 0;
            int h04 = 0; int h14 = 0; int h05 = 0; int h15 = 0;

            int s;

            switch (_setDirection)
            {
                case DirectionEnum.Left:

                    s = (width - 2 * _setEdgeWidth) / 4;

                    w1 = _setEdgeWidth + 4 * s;
                    w2 = _setEdgeWidth + 3 * s;
                    w3 = _setEdgeWidth + 2 * s;
                    w4 = _setEdgeWidth + s;
                    w5 = _setEdgeWidth;

                    s = heigth / 8;

                    h01 = _setEdgeWidth;
                    h11 = _setEdgeWidth + 8 * s;
                    h02 = _setEdgeWidth + s;
                    h12 = _setEdgeWidth + 7 * s;
                    h03 = _setEdgeWidth + 2 * s;
                    h13 = _setEdgeWidth + 6 * s;
                    h04 = _setEdgeWidth + 3 * s;
                    h14 = _setEdgeWidth + 5 * s;
                    h05 = _setEdgeWidth + 4 * s;
                    h15 = h05;

                    _getLevelPoint[0, 0] = new Point(w1, h01);
                    _getLevelPoint[0, 1] = new Point(w1, h11);
                    _getLevelPoint[0, 2] = new Point(w2, h12);
                    _getLevelPoint[0, 3] = new Point(w2, h02);

                    _getLevelPoint[1, 0] = _getLevelPoint[0, 3];
                    _getLevelPoint[1, 1] = _getLevelPoint[0, 2];
                    _getLevelPoint[1, 2] = new Point(w3, h13);
                    _getLevelPoint[1, 3] = new Point(w3, h03);

                    _getLevelPoint[2, 0] = _getLevelPoint[1, 3];
                    _getLevelPoint[2, 1] = _getLevelPoint[1, 2];
                    _getLevelPoint[2, 2] = new Point(w4, h14);
                    _getLevelPoint[2, 3] = new Point(w4, h04);

                    _getLevelPoint[3, 0] = _getLevelPoint[2, 3];
                    _getLevelPoint[3, 1] = _getLevelPoint[2, 2];
                    _getLevelPoint[3, 2] = new Point(w5, h15);
                    _getLevelPoint[3, 3] = _getLevelPoint[3, 2];

                    break;
                case DirectionEnum.Right:

                    s = (width - 2 * _setEdgeWidth) / 4;

                    w5 = _setEdgeWidth + 4 * s;
                    w4 = _setEdgeWidth + 3 * s;
                    w3 = _setEdgeWidth + 2 * s;
                    w2 = _setEdgeWidth + s;
                    w1 = _setEdgeWidth;

                    s = heigth / 8;

                    h01 = _setEdgeWidth;
                    h11 = _setEdgeWidth + 8 * s;
                    h02 = _setEdgeWidth + s;
                    h12 = _setEdgeWidth + 7 * s;
                    h03 = _setEdgeWidth + 2 * s;
                    h13 = _setEdgeWidth + 6 * s;
                    h04 = _setEdgeWidth + 3 * s;
                    h14 = _setEdgeWidth + 5 * s;
                    h05 = _setEdgeWidth + 4 * s;
                    h15 = h05;

                    _getLevelPoint[0, 0] = new Point(w1, h01);
                    _getLevelPoint[0, 1] = new Point(w1, h11);
                    _getLevelPoint[0, 2] = new Point(w2, h12);
                    _getLevelPoint[0, 3] = new Point(w2, h02);

                    _getLevelPoint[1, 0] = _getLevelPoint[0, 3];
                    _getLevelPoint[1, 1] = _getLevelPoint[0, 2];
                    _getLevelPoint[1, 2] = new Point(w3, h13);
                    _getLevelPoint[1, 3] = new Point(w3, h03);

                    _getLevelPoint[2, 0] = _getLevelPoint[1, 3];
                    _getLevelPoint[2, 1] = _getLevelPoint[1, 2];
                    _getLevelPoint[2, 2] = new Point(w4, h14);
                    _getLevelPoint[2, 3] = new Point(w4, h04);

                    _getLevelPoint[3, 0] = _getLevelPoint[2, 3];
                    _getLevelPoint[3, 1] = _getLevelPoint[2, 2];
                    _getLevelPoint[3, 2] = new Point(w5, h15);
                    _getLevelPoint[3, 3] = _getLevelPoint[3, 2];

                    break;
                case DirectionEnum.Up:

                    s = (heigth - 2 * _setEdgeWidth) / 4;

                    h1 = _setEdgeWidth + 4 * s;
                    h2 = _setEdgeWidth + 3 * s;
                    h3 = _setEdgeWidth + 2 * s;
                    h4 = _setEdgeWidth + s;
                    h5 = _setEdgeWidth;

                    s = width / 8;

                    w01 = _setEdgeWidth;
                    w11 = _setEdgeWidth + 8 * s;
                    w02 = _setEdgeWidth + s;
                    w12 = _setEdgeWidth + 7 * s;
                    w03 = _setEdgeWidth + 2 * s;
                    w13 = _setEdgeWidth + 6 * s;
                    w04 = _setEdgeWidth + 3 * s;
                    w14 = _setEdgeWidth + 5 * s;
                    w05 = _setEdgeWidth + 4 * s;
                    w15 = w05;

                    _getLevelPoint[0, 0] = new Point(w01, h1);
                    _getLevelPoint[0, 1] = new Point(w11, h1);
                    _getLevelPoint[0, 2] = new Point(w12, h2);
                    _getLevelPoint[0, 3] = new Point(w02, h2);

                    _getLevelPoint[1, 0] = _getLevelPoint[0, 3];
                    _getLevelPoint[1, 1] = _getLevelPoint[0, 2];
                    _getLevelPoint[1, 2] = new Point(w13, h3);
                    _getLevelPoint[1, 3] = new Point(w03, h3);

                    _getLevelPoint[2, 0] = _getLevelPoint[1, 3];
                    _getLevelPoint[2, 1] = _getLevelPoint[1, 2];
                    _getLevelPoint[2, 2] = new Point(w14, h4);
                    _getLevelPoint[2, 3] = new Point(w04, h4);

                    _getLevelPoint[3, 0] = _getLevelPoint[2, 3];
                    _getLevelPoint[3, 1] = _getLevelPoint[2, 2];
                    _getLevelPoint[3, 2] = new Point(w15, h5);
                    _getLevelPoint[3, 3] = _getLevelPoint[3, 2];

                    break;
                case DirectionEnum.Down:

                    s = (heigth - 2 * _setEdgeWidth) / 4;

                    h5 = _setEdgeWidth + 4 * s;
                    h4 = _setEdgeWidth + 3 * s;
                    h3 = _setEdgeWidth + 2 * s;
                    h2 = _setEdgeWidth + s;
                    h1 = _setEdgeWidth;

                    s = width / 8;

                    w01 = _setEdgeWidth;
                    w11 = _setEdgeWidth + 8 * s;
                    w02 = _setEdgeWidth + s;
                    w12 = _setEdgeWidth + 7 * s;
                    w03 = _setEdgeWidth + 2 * s;
                    w13 = _setEdgeWidth + 6 * s;
                    w04 = _setEdgeWidth + 3 * s;
                    w14 = _setEdgeWidth + 5 * s;
                    w05 = _setEdgeWidth + 4 * s;
                    w15 = w05;

                    _getLevelPoint[0, 0] = new Point(w01, h1);
                    _getLevelPoint[0, 1] = new Point(w11, h1);
                    _getLevelPoint[0, 2] = new Point(w12, h2);
                    _getLevelPoint[0, 3] = new Point(w02, h2);

                    _getLevelPoint[1, 0] = _getLevelPoint[0, 3];
                    _getLevelPoint[1, 1] = _getLevelPoint[0, 2];
                    _getLevelPoint[1, 2] = new Point(w13, h3);
                    _getLevelPoint[1, 3] = new Point(w03, h3);

                    _getLevelPoint[2, 0] = _getLevelPoint[1, 3];
                    _getLevelPoint[2, 1] = _getLevelPoint[1, 2];
                    _getLevelPoint[2, 2] = new Point(w14, h4);
                    _getLevelPoint[2, 3] = new Point(w04, h4);

                    _getLevelPoint[3, 0] = _getLevelPoint[2, 3];
                    _getLevelPoint[3, 1] = _getLevelPoint[2, 2];
                    _getLevelPoint[3, 2] = new Point(w15, h5);
                    _getLevelPoint[3, 3] = _getLevelPoint[3, 2];

                    break;
            }


            _generationLevelPointProcess = false;
            return;
        }

        #endregion

        #region 滑鼠

        private void ColorArrowButton_MouseDown(object sender, MouseEventArgs e)
        {
            // 修正滑鼠狀態物件
            _getMouseStatus = e;

            this.Invalidate();

            if (MouseDownEvent != null)
            {
                MouseDownEvent(sender, e);
            }
        }

        private void ColorArrowButton_MouseUp(object sender, MouseEventArgs e)
        {
            // 修正滑鼠狀態物件
            _getMouseStatus = e;

            this.Invalidate();

            if (MouseUpEvent != null)
            {
                MouseUpEvent(sender, e);
            }
        }

        private void ColorArrowButton_MouseMove(object sender, MouseEventArgs e)
        {
            // 修正滑鼠狀態物件
            _getMouseStatus = e;

            this.Invalidate();

            if (MouseMoveEvent != null)
            {
                MouseMoveEvent(sender, e);
            }
        }

        private void ColorArrowButton_MouseLeave(object sender, EventArgs e)
        {
            _mouseEnter = false;
            this.Invalidate();
        }
        private void ColorArrowButton_MouseEnter(object sender, EventArgs e)
        {
            _mouseEnter = true;
            this.Invalidate();
        }

        #endregion

        private void ColorArrowButton_Resize(object sender, EventArgs e)
        {
            _generationLevelPointProcess = true;
            this.Invalidate();
        }


    }
}
