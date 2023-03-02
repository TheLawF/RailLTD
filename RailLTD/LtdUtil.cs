using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace RailLTD
{
    public class LtdUtil
    {
        public static int GetDistance(int stationCount, int width)
        {
            return width / (stationCount + 1);
        }

        /// <summary>
        /// 在这里启动轨道交通乘客信息显示屏的多个线程，根据传入的索引值调用不同的
        /// 静态方法，循环绘制不同的乘客信息显示，timer.interval 决定着每幅画面
        /// 存在的时间。
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="index"></param>
        public void StartLtdLoop(bool flag, int index)
        {
            loop : while (flag)
            {
                exe : switch (index)
                {
                    case 0:
                        SwitchLtdLoop(ShowStation, 5000, flag);
                        break;
                    case 1:
                        SwitchLtdLoop(ShowNext, 5000, flag);
                        break;
                    case 2:
                        SwitchLtdLoop(ShowTrain, 5000, flag);
                        break;
                    case 3:
                        SwitchLtdLoop(ShowIsDoorOpen, 5000, flag);
                        break;
                }
                
            }
        }

        private static void SwitchLtdLoop(ElapsedEventHandler e, double interval, bool flag)
        {
            var timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = interval; //执行间隔时间,单位为毫秒 
            timer.Start();
            timer.Elapsed += e;
        }

        private static void ShowStation(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            
        }

        private static void ShowNext(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            
        }

        private static void ShowTrain(object sender, ElapsedEventArgs elapsedEventArgs)
        {
           
        }

        private static void ShowIsDoorOpen(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            
        }
    }
    
}