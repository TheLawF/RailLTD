using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RailLTD
{
    public class LtdUtil
    {
        private bool _flag;
        private long _elapsedMilliseconds;
        public LtdUtil()
        {
        }

        public LtdUtil(bool flag, long elapsedMilliseconds)
        {
            _flag = flag;
            _elapsedMilliseconds = elapsedMilliseconds;
        }

        public static int GetDistance(int stationCount, int width)
        {
            return width / (stationCount + 1);
        }

        /// <summary>
        /// 等等，这里怎么还有一个LoadHomeScene 方法？？？
        /// </summary>
        public static void LoadHomeScene()
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
        
            /// <summary> 
            /// C# GDI+ 绘制圆角实心矩形 
            /// </summary> 
            /// <param name="g">Graphics 对象</param> 
            /// <param name="rectangle">要填充的矩形</param> 
            /// <param name="backColor">填充背景色</param> 
            /// <param name="r">圆角半径</param> 
            public static void FillRoundRectangle(Graphics g, Rectangle rectangle, Color backColor, int r)
            {
                rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width - 1, rectangle.Height - 1);
                Brush b = new SolidBrush(backColor);
                g.FillPath(b, GetRoundRectangle(rectangle, r));
            }
 
            /// <summary> 
            /// 根据普通矩形得到圆角矩形的路径 
            /// </summary> 
            /// <param name="rectangle">原始矩形</param> 
            /// <param name="r">半径</param> 
            /// <returns>图形路径</returns> 
            private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
            {
                int l = 2 * r;
                // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
                var gp = new GraphicsPath();
                gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
                gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);
 
                gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
                gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);
 
                gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
                gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);
 
                gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
                gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
                return gp;
            }
        
        public static void SaveAsJson(object o)
        {
            var output = JsonConvert.SerializeObject(o);
            var ofd = new SaveFileDialog();
            ofd.Filter = @"Json文件|*.json";
            var result = ofd.ShowDialog();
            
            if (result != DialogResult.OK) return; //点击确定按钮
            var jsonFile = new StreamWriter(ofd.FileName, true, Encoding.UTF8);
            jsonFile.Write(output);
            jsonFile.Close();
        }

        public static JsonConfigure LoadFromJson()
        {
            var builder = new StringBuilder();
            var ofd = new OpenFileDialog();
            ofd.Filter = @"Json文件|*.json";
            var result = ofd.ShowDialog();
            
            if (result != DialogResult.OK) return null; //点击确定按钮
            var jsonFile = new StreamReader(ofd.FileName, Encoding.UTF8);
            
            foreach (var jsonLine in jsonFile.ReadLine())
            {
                builder.Append(jsonLine);
            }
            jsonFile.Close();

            return JsonConvert.DeserializeObject<JsonConfigure>(builder.ToString());
        }

        public static JsonConfigure LoadFromJson(string path)
        {
            var jsonFile = new StreamReader(path, Encoding.UTF8);
            var builder = new StringBuilder();
            
            foreach (var jsonLine in jsonFile.ReadLine())
            {
                builder.Append(jsonLine);
            }
            jsonFile.Close();

            return JsonConvert.DeserializeObject<JsonConfigure>(builder.ToString());
        }
    }
    
}