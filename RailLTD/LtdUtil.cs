using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Timers;
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
        
        public static void SaveAsJson(object o)
        {
            var type = o.GetType();
            var output = JsonConvert.SerializeObject(o);
        }
    }
    
}