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
    public partial class AxisView : UserControl
    {
        #region 列舉

        /// <summary>
        /// 指向方向
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

        #region 公開屬性

        /// <summary>
        /// 設置方向
        /// </summary>
        protected DirectionEnum _setDirection = DirectionEnum.Right;
        /// <summary>
        /// 設置方向
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
                    if (value == DirectionEnum.Right || value == DirectionEnum.Left)
                    {
                        _setPointDirection = DirectionEnum.Up;
                    }
                    else
                    {
                        _setPointDirection = DirectionEnum.Right;
                    }
                    _setDirection = value;
                    this.Invalidate();
                }
            }
        }

        /// <summary>
        /// 設置點朝向方向
        /// </summary>
        protected DirectionEnum _setPointDirection = DirectionEnum.Up;
        /// <summary>
        /// 設置點朝向方向
        /// </summary>
        public DirectionEnum setPointDirection
        {
            get
            {
                return _setPointDirection;
            }
            set
            {
                if (!_setTextDisplay)
                {
                    return;
                }
                switch (_setDirection)
                {
                    case DirectionEnum.Left:
                    case DirectionEnum.Right:
                        if (value == DirectionEnum.Right || value == DirectionEnum.Left)
                        {
                            MessageBox.Show("只能設定朝上或朝下");
                            _setPointDirection = DirectionEnum.Up;
                            return;
                        }
                        break;
                    case DirectionEnum.Up:
                    case DirectionEnum.Down:
                        if (value == DirectionEnum.Up || value == DirectionEnum.Down)
                        {
                            MessageBox.Show("只能設定朝左或朝右");
                            _setPointDirection = DirectionEnum.Right;
                            return;
                        }
                        break;
                }
                _setPointDirection = value;
                this.Invalidate();
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

        #region 顏色

        /// <summary>
        /// 設定軸背景顏色
        /// </summary>
        protected Color _setAxisBackgroundColor = Color.Blue;
        /// <summary>
        /// 設定軸背景顏色
        /// </summary>
        public Color setAxisBackgroundColor
        {
            get
            {
                return _setAxisBackgroundColor;
            }
            set
            {
                _setAxisBackgroundColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 設定軸座標顏色
        /// </summary>
        protected Color _setAxisEdgeColor = Color.Black;
        /// <summary>
        /// 設定軸座標顏色
        /// </summary>
        public Color setAxisEdgeColor
        {
            get
            {
                return _setAxisEdgeColor;
            }
            set
            {
                _setAxisEdgeColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 設定點顏色
        /// </summary>
        protected Color _setPointColor = Color.Red;
        /// <summary>
        /// 設定點顏色
        /// </summary>
        public Color setPointColor
        {
            get
            {
                return _setPointColor;
            }
            set
            {
                _setPointColor = value;
                this.Invalidate();
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
                _setTextColor = value;
                this.Invalidate();
            }
        }

        #endregion

        #region 數值

        /// <summary>
        /// 設定最大值
        /// </summary>
        protected float _setMaxValue = 100f;
        /// <summary>
        /// 設定最大值
        /// </summary>
        public float setMaxValue
        {
            get
            {
                return _setMaxValue;
            }
            set
            {
                if (value < _setMinValue)
                {
                    MessageBox.Show("最大值設定錯誤");
                }
                else
                {
                    _setMaxValue = value;
                    this.Invalidate();
                }
            }
        }

        /// <summary>
        /// 設定最小值
        /// </summary>
        protected float _setMinValue = 0f;
        /// <summary>
        /// 設定最小值
        /// </summary>
        public float setMinValue
        {
            get
            {
                return _setMinValue;
            }
            set
            {
                if (value > _setMaxValue)
                {
                    MessageBox.Show("最小值設定錯誤");
                }
                else
                {
                    _setMinValue = value;
                    this.Invalidate();
                }
            }
        }

        /// <summary>
        /// 設定目前值
        /// </summary>
        protected float _setValue = 50f;
        /// <summary>
        /// 設定目前值
        /// </summary>
        public float setValue
        {
            get
            {
                return _setValue;
            }
            set
            {
                if (value < _setMinValue || value > _setMaxValue)
                {
                    MessageBox.Show("目前值設定錯誤");
                }
                else
                {
                    _setValue = value;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #endregion

        #region 唯讀屬性

        /// <summary>
        /// 軸標籤
        /// </summary>
        protected float[] _getAxisLabels = new float[101];
        /// <summary>
        /// 軸標籤
        /// </summary>
        public float[] getAxisLabels
        {
            get
            {
                return _getAxisLabels;
            }
        }

        /// <summary>
        /// 取得設定值所在標籤位置
        /// </summary>
        protected float _getValueLabel = 0;
        /// <summary>
        /// 取得設定值所在標籤位置
        /// </summary>
        public float getValueLabel
        {
            get
            {
                return _getValueLabel;
            }
        }

        #endregion

        #region 內部變數

        /// <summary>
        /// 軸繪製起始 X 位置
        /// </summary>
        protected float axis_widthedge = 1.5f;
        /// <summary>
        /// 軸繪製起始 Y 位置
        /// </summary>
        protected float axis_heightedge = 25f;

        /// <summary>
        /// 軸繪製高度
        /// </summary>
        protected float axis_height = 20f;
        /// <summary>
        /// 軸繪製寬度
        /// </summary>
        float axis_width = 0f;

        #endregion

        #region 初始化

        /// <summary>
        /// 建構函數
        /// </summary>
        public AxisView()
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
            switch (_setDirection)
            {
                case DirectionEnum.Left:
                case DirectionEnum.Right:
                    if (_setPointDirection == DirectionEnum.Up)
                    {
                        axis_widthedge = 1.5f;
                        axis_heightedge = 25f;
                        axis_height = 20f;
                        axis_width = Width - 2 * axis_widthedge;
                    }
                    else
                    {
                        axis_widthedge = 1.5f;
                        axis_heightedge = 0f;
                        axis_height = 20f;
                        axis_width = Width - 2 * axis_widthedge;
                    }
                    break;
                case DirectionEnum.Up:
                case DirectionEnum.Down:
                    if (_setPointDirection == DirectionEnum.Left)
                    {
                        axis_widthedge = 40f;
                        axis_heightedge = 1.5f;
                        axis_height = Height - 2 * axis_heightedge;
                        axis_width = 20f;
                    }
                    else
                    {
                        axis_widthedge = 0f;
                        axis_heightedge = 1.5f;
                        axis_height = Height - 2 * axis_heightedge;
                        axis_width = 20f;
                    }
                    break;

            }

            Graphics g = e.Graphics;
            GenerationAxis(g);
            GenerationPoint(g);

        }

        /// <summary>
        /// 產生座標軸
        /// </summary>
        /// <param name="g"></param>
        private void GenerationAxis(Graphics g)
        {
            Pen axisPen = new Pen(_setAxisEdgeColor, 1f);
            Brush axisBrush = new SolidBrush(_setAxisBackgroundColor);

            float delta = 0;
            // 畫座標軸背景
            RectangleF axisRectange = new RectangleF(axis_widthedge, axis_heightedge,
                        axis_width, axis_height);
            g.FillRectangle(axisBrush, axisRectange);

            switch (_setDirection)
            {
                case DirectionEnum.Up:
                case DirectionEnum.Down:
                    delta = axis_height / 100f;

                    // 畫坐標軸標示
                    for (int idx = 0; idx <= 100; idx++)
                    {
                        _getAxisLabels[idx] =  axis_heightedge + idx * delta;
                        if (idx % 10 == 0)
                        {
                            g.DrawLine(axisPen,
                               axis_widthedge,
                               _getAxisLabels[idx],
                               axis_widthedge + axis_width - 2f,
                               _getAxisLabels[idx]);
                        }
                        else
                        {
                            if (_setPointDirection == DirectionEnum.Left)
                            {
                                g.DrawLine(axisPen,
                                    axis_widthedge,
                                    _getAxisLabels[idx],
                                    axis_widthedge + axis_width / 2,
                                    _getAxisLabels[idx]);
                            }
                            else
                            {
                                g.DrawLine(axisPen,
                                    axis_widthedge + axis_width / 2,
                                    _getAxisLabels[idx],
                                    axis_widthedge + axis_width - 2f,
                                    _getAxisLabels[idx]);
                            }
                        }
                    }
                    break;
                case DirectionEnum.Right:
                case DirectionEnum.Left:
                    delta = axis_width / 100f;

                    // 畫坐標軸標示
                    for (int idx = 0; idx <= 100; idx++)
                    {
                        _getAxisLabels[idx] = axis_widthedge + idx * delta;
                        if (idx % 10 == 0)
                        {
                            g.DrawLine(axisPen,
                                _getAxisLabels[idx],
                                axis_heightedge,
                                _getAxisLabels[idx],
                                axis_heightedge + axis_height - 2f);
                        }
                        else
                        {
                            if (_setPointDirection == DirectionEnum.Up)
                            {
                                g.DrawLine(axisPen,
                                    _getAxisLabels[idx],
                                    axis_heightedge,
                                    _getAxisLabels[idx],
                                    axis_heightedge + axis_height / 2);
                            }
                            else
                            {
                                g.DrawLine(axisPen,
                                    _getAxisLabels[idx],
                                    axis_heightedge + axis_height / 2,
                                    _getAxisLabels[idx],
                                    axis_heightedge + axis_height - 2f);
                            }
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// 產生點
        /// </summary>
        /// <param name="g"></param>
        private void GenerationPoint(Graphics g)
        {
            Brush pointBrush = new SolidBrush(_setPointColor);
            float pValue = 0f;
            float valueLocation = 0f;
            float v = (_setValue - _setMinValue) * 100 / (_setMaxValue - _setMinValue);
            switch (_setDirection)
            {
                case DirectionEnum.Right:
                    pValue = v;
                    valueLocation = pValue * (axis_width) / 100f;
                    break;
                case DirectionEnum.Left:
                    pValue = 100 - v;
                    valueLocation = pValue * (axis_width) / 100f;
                    break;
                case DirectionEnum.Up:
                    pValue = 100 - v;
                    valueLocation = pValue * (axis_height) / 100f;
                    break;
                case DirectionEnum.Down:
                    pValue = v;
                    valueLocation = pValue * (axis_height) / 100f;
                    break;
            }
            _getValueLabel = valueLocation;

            GraphicsPath gp = new GraphicsPath(FillMode.Alternate);
            PointF[] pathPoint = new PointF[6];
            switch (_setDirection)
            {
                case DirectionEnum.Up:
                case DirectionEnum.Down:
                    if (_setPointDirection == DirectionEnum.Left)
                    {
                        pathPoint[0] = new PointF(axis_widthedge, valueLocation);
                        pathPoint[1] = new PointF(axis_widthedge + 5f, valueLocation - 5f);
                        pathPoint[2] = new PointF(axis_widthedge + axis_width, valueLocation - 5f);
                        pathPoint[3] = new PointF(axis_widthedge + axis_width, valueLocation + 5f);
                        pathPoint[4] = new PointF(axis_widthedge + 5f, valueLocation + 5f);
                        pathPoint[5] = pathPoint[0];
                    }
                    else
                    {
                        pathPoint[0] = new PointF(axis_widthedge + axis_width, valueLocation);
                        pathPoint[1] = new PointF(axis_widthedge + axis_width - 5f, valueLocation - 5f);
                        pathPoint[2] = new PointF(axis_widthedge, valueLocation - 5f);
                        pathPoint[3] = new PointF(axis_widthedge, valueLocation + 5f);
                        pathPoint[4] = new PointF(axis_widthedge + axis_width - 5f, valueLocation + 5f);
                        pathPoint[5] = pathPoint[0];
                    }
                    break;
                case DirectionEnum.Right:
                case DirectionEnum.Left:
                    if (_setPointDirection == DirectionEnum.Up)
                    {
                        pathPoint[0] = new PointF(valueLocation, axis_heightedge);
                        pathPoint[1] = new PointF(valueLocation - 5f, axis_heightedge + 5f);
                        pathPoint[2] = new PointF(valueLocation - 5f, axis_heightedge + axis_height);
                        pathPoint[3] = new PointF(valueLocation + 5f, axis_heightedge + axis_height);
                        pathPoint[4] = new PointF(valueLocation + 5f, axis_heightedge + 5f);
                        pathPoint[5] = pathPoint[0];
                    }
                    else
                    {
                        pathPoint[0] = new PointF(valueLocation, axis_heightedge + axis_height);
                        pathPoint[1] = new PointF(valueLocation - 5f, axis_heightedge + axis_height - 5f);
                        pathPoint[2] = new PointF(valueLocation - 5f, axis_heightedge);
                        pathPoint[3] = new PointF(valueLocation + 5f, axis_heightedge);
                        pathPoint[4] = new PointF(valueLocation + 5f, axis_heightedge + axis_height - 5f);
                        pathPoint[5] = pathPoint[0];
                    }
                    break;
            }

            gp.AddLines(pathPoint);
            g.FillPath(pointBrush, gp);
            gp.Dispose();
            GenerationText(g, pValue, valueLocation);
        }

        /// <summary>
        /// 產生文字
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pValue"></param>
        /// <param name="valueLocation"></param>
        private void GenerationText(Graphics g, float pValue, float valueLocation)
        {
            if (!_setTextDisplay)
            {
                return;
            }

            Brush textBrush = new SolidBrush(_setTextColor);
            int size = 14;
            // 量測文字尺寸
            Font font = new Font("Arial", size);
            SizeF textSize = g.MeasureString(_setValue.ToString(), font);
            PointF textPoint = new PointF();
            switch (_setDirection)
            {
                case DirectionEnum.Up:
                case DirectionEnum.Down:
                    if (_setPointDirection == DirectionEnum.Left)
                    {
                        textPoint = new PointF(axis_widthedge - textSize.Width, valueLocation - textSize.Height / 2);
                    }
                    else
                    {
                        textPoint = new PointF(axis_widthedge + axis_width, valueLocation - textSize.Height / 2);
                    }
                    break;
                case DirectionEnum.Right:
                case DirectionEnum.Left:
                    if (_setPointDirection == DirectionEnum.Up)
                    {
                        textPoint = new PointF(valueLocation - textSize.Width / 2, axis_heightedge - textSize.Height);
                    }
                    else
                    {
                        textPoint = new PointF(valueLocation - textSize.Width / 2, axis_heightedge + axis_height);
                    }
                    break;
            }
            g.DrawString(_setValue.ToString(), font, textBrush, textPoint);
        }

        #endregion
    }
}
