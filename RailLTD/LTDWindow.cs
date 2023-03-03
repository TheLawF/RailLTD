using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RailLTD
{
    public partial class LTDWindow : Form
    {
        
        private int _green;
        private int _red;
        private int _blue;
        private bool _flag;

        private string _lineId;
        private string _lineNum;
        private const string NoneLine = "不选择";

        private Graphics _graphics;
        private TimeTable startStation;
        private TimeTable endStation;
        
        private int _intervalFrom;
        private int _intervalTo;
        private int _carriageIndex = 1;

        private List<Station> _stations = new List<Station>();
        private List<TimeTable> _timeTable = new List<TimeTable>();
        private List<string> _exits = new List<string>();
        private Hashtable _stationAndExit = new Hashtable();
        private ArrayList _lineItems = new ArrayList();
        
        // 这里是CRT重庆轨道交通的一些路线颜色信息
        private readonly Color[] _crtColors =
        {
            Color.FromArgb(250, 202, 46),
            Color.FromArgb(188, 16, 26),
            Color.FromArgb(34, 139, 34),
            Color.FromArgb(26, 79, 163),
            Color.FromArgb(232, 162, 58),
            Color.FromArgb(37, 180, 231),
            Color.FromArgb(255,129,191),
            Color.FromArgb(139, 0, 255),
        };
        
        public LTDWindow()
        {
            InitializeComponent();
        }

        private void showLTD_Click(object sender, EventArgs e)
        {
            var ltd = new LtdScene(_red, _green, _blue, _stations);
            ltd.ShowDialog();
        }

        // 重写更改窗体大小的事件，以便让其适用于线段的绘制
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

        private void idText_TextChanged(object sender, EventArgs e)
        {
            _lineId = idText.Text;
        }

        private void numText_TextChanged(object sender, EventArgs e)
        {
            _lineNum = numText.Text;
        }

        private void redText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(redText.Text, out var redInt)) return;
            if (redInt >= 0 | redInt <= 255)
            {
                _red = redInt;
            }
        }

        private void greenText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(greenText.Text, out var greenInt)) return;
            if (greenInt >= 0 | greenInt <= 255)
            {
                _green = greenInt;
            }
        }

        private void blueText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(blueText.Text, out var blueInt)) return;
            if (blueInt >= 0 | blueInt <= 255)
            {
                _blue = blueInt;
            }
        }

        private void LTDWindow_Load(object sender, EventArgs e)
        {
            _lineItems.Add(NoneLine);
            _lineItems.AddRange(CRTColor.Lines);
            
            if (int.TryParse(msText.Text, out var ms))
            {
                timer.Interval = ms;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
        }

        private void editStationButton_Click(object sender, EventArgs e)
        {
            var settingWindow = new LineSettingsWindow();
            settingWindow.ShowDialog();
            _stations = settingWindow.Stations;
        }


        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MsText_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(msText.Text, out var ms))
            {
                timer.Interval = ms;
            }
        }

        private void exitNumBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exitInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stRemoveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LTDWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)
            {
                var dialog = new SettingsDialog();
                dialog.ShowDialog();
            }

            if (e.KeyChar == (int)Keys.Left && _carriageIndex >= 1)
            {
                _carriageIndex++;
            }

            if (e.KeyChar == (int)Keys.Right && _carriageIndex <= 6)
            {
                _carriageIndex--;
            }
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            
        }
        
        private void LoadHomeScene()
        {
            
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
        /// <param name="carriageIndex"> 车厢的索引标号，用于决定车厢画面的数字 </param>
        public void LoadLtdScene(bool flag, int interval, int carriageIndex, long elapsedMilliseconds)
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
        
        public static void SaveAsJson(object o)
        {
            var type = o.GetType();
            var output = JsonConvert.SerializeObject(o);
        }
    }
}