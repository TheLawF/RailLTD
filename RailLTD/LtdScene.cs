using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RailLTD
{
    public partial class LtdScene : Form
    {
        private int _green;
        private int _red;
        private int _blue;
        
        private Graphics _graphics;
        private List<Station> _stations;
        private RailLine _railLine;

        public LtdScene(int red, int green,  int blue, List<Station> stations)
        {
            _green = green;
            _red = red;
            _blue = blue;
            _stations = stations;
            InitializeComponent();
        }

        public LtdScene()
        {
            InitializeComponent();
        }

        private void LtdScene_Load(object sender, EventArgs e)
        {
            
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            var customPen = new Pen(Color.FromArgb(_red, _green, _blue), 30);
            _graphics = CreateGraphics();
            _graphics.Clear(BackColor);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            var start = new Point(0, Size.Height / 2);
            var end = new Point(Size.Width, Size.Height / 2);
            var unit = 1;
            if (_stations.Count > 0)
            {
                unit = Size.Width / _stations.Count;
            }
            
            var font = new Font("微软雅黑", 13.875F, 
                FontStyle.Regular,GraphicsUnit.Point, 134);
            
            _graphics.DrawLine(customPen,start, end);
            for (var i = 0; i < _stations.Count; i++)
            {
                _graphics.FillEllipse(new SolidBrush(Color.White),
                    new Rectangle(new Point(i * unit, start.Y-15), Size.Round(new SizeF(28F, 28F))));
                for (var j = 0; j < _stations[i].Name.ToCharArray().Length; j++)
                {
                    var str = _stations[i].Name.ToCharArray()[j].ToString();
                    _graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    _graphics.DrawString(str, font, new SolidBrush(Color.Black),
                        i * unit, start.Y + 12f + j * 15f);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _graphics = CreateGraphics();
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var start = new Point(0, Size.Height / 2);
            var end = new Point(Size.Width, Size.Height / 2);
            var unit = 1;
            if (_stations.Count > 0)
            {
                unit = Size.Width / _stations.Count;
            }
            
            // 准备绘制线条，如果用户在下拉框中点击“不选择”这一元素，则flag更改为false，
            var customPen = new Pen(Color.FromArgb(_red, _green, _blue) , 30);
            _graphics.DrawLine(customPen,start, end);
            var font = new Font("微软雅黑", 13.875F, 
                FontStyle.Regular,GraphicsUnit.Point, 134);
            
            for (var i = 0; i < _stations.Count; i++)
            {
                _graphics.FillEllipse(new SolidBrush(Color.White),
                    new Rectangle(new Point(i * unit, start.Y-15),
                        Size.Round(new SizeF(28F, 28F))));
                
                for (var j = 0; j < _stations[i].Name.ToCharArray().Length; j++)
                {
                    var str = _stations[i].Name.ToCharArray()[j].ToString();
                    _graphics.DrawString(str, font, new SolidBrush(Color.Black),
                        i * unit, start.Y + 12 + j * 15f);
                }
            }
        }
    }
}