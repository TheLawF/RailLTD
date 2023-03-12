using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RailLTD
{
    public partial class LtdScene : Form
    {
        private int _red;
        private int _green;
        private int _blue;
        
        private Graphics _graphics;
        private List<Station> _stations;
        private RailLine _railLine;
        private bool _flag;
        private JsonConfigure _configure;

        public LtdScene(int red, int green,  int blue, List<Station> stations)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _stations = stations;
            InitializeComponent();
        }

        public LtdScene(RailLine line)
        {
            _green = line.LineColor.G;
            _red = line.LineColor.R;
            _blue = line.LineColor.B;
            _stations = line.Stations;
            InitializeComponent();
        }

        public LtdScene(JsonConfigure json)
        {
            _configure = json;
            _red = json.Line.LineColor.R;
            _green = json.Line.LineColor.G;
            _blue = json.Line.LineColor.B;
            _stations = json.Line.Stations;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintLine();
            // LoadLtdScene(_flag);
        }
        
        
        /// <summary>
        /// 在这里启动轨道交通乘客信息显示屏的多个线程，根据传入的索引值调用不同的
        /// 方法，循环绘制不同的乘客信息显示。
        /// 
        /// 现在还用不到 interval 这个参数
        /// </summary>
        /// <param name="flag"> 用于决定是否应该跳出三幅画面的循环切换 </param>
        /// <param name="elapsedMilliseconds"> 每幅画面的存在时间 </param>
        /// <param name="interval"> 两个站之间所需的时间，用于跳出循环 </param>
        /// <param name="coachIndex"> 车厢的索引标号，用于决定车厢画面的数字 </param>
        public void LoadLtdScene(bool flag, int interval, int coachIndex, long elapsedMilliseconds)
        {
            var pool = new List<Thread>
            {
                new Thread(() =>
                {
                    ShowLine(flag, elapsedMilliseconds);
                }),
                new Thread(() =>
                {
                    ShowStation(flag, elapsedMilliseconds);
                }),
                new Thread(() =>
                {
                    ShowTrain(flag, elapsedMilliseconds);
                })
            };
            do
            {
                pool.ForEach(thread => thread.Start());
            } while (_flag);
        }

        /// <summary>
        /// 多线程的代码已经开发结束，现在可以直接在这些方法里面编写具体的Winform图像绘制了
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="elapsedMilliseconds"></param>
        private void ShowLine(bool flag, long elapsedMilliseconds)
        {
            if (!flag) return;
            
            var watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                if (watch.ElapsedMilliseconds >= elapsedMilliseconds)
                {
                    _flag = false;
                    Thread.CurrentThread.Abort();
                }
                
                PaintLine();
            }
        }

        private void ShowStation(bool flag, long elapsedMilliseconds)
        {
            if (!flag) return;
            
            var watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                if (watch.ElapsedMilliseconds >= elapsedMilliseconds)
                {
                    _flag = false;
                    Thread.CurrentThread.Abort();
                }
            }
        }

        private static void ShowNext()
        {
            
        }

        private void ShowTrain(bool flag, long elapsedMilliseconds)
        {
            if (!flag) return;
            
            var watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                if (watch.ElapsedMilliseconds >= elapsedMilliseconds)
                {
                    _flag = false;
                    Thread.CurrentThread.Abort();
                }
                
            }
        }

        private static void ShowIsDoorOpen(object sender, ElapsedEventArgs e)
        {
            
        }
        
        public static void ToJson(object o)
        {
            var type = o.GetType();
            var output = JsonConvert.SerializeObject(o);
            
        }

        public static object FromJson(string json)
        {
            return JsonConvert.DeserializeObject(json);
        }

        public void PaintLine()
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