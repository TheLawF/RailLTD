using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RailLTD
{
    public partial class LTDWindow : Form
    {
        
        private int _green;
        private int _red;
        private int _blue;

        private string _lineId;
        private string _lineNum;
        private const string NoneLine = "不选择";

        private Graphics _graphics;
        private TimeTable startStation;
        private TimeTable endStation;
        
        private int _intervalFrom;
        private int _intervalTo;
        private int _carrigeIndex = 1;

        private readonly List<string> _stations = new List<string>();
        private readonly List<TimeTable> _timeTable = new List<TimeTable>();
        private readonly List<string> _exits = new List<string>();
        private readonly HashSet<List<string>> _stationAndExit = new HashSet<List<string>>();
        private volatile ArrayList _lineItems = new ArrayList();
        
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
            // 移除整个面板控件
            Controls.Remove(homePanel);
            
            _graphics = CreateGraphics();
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var start = new Point(0, Size.Height / 2);
            var end = new Point(Size.Width, Size.Height / 2);
            
            // 准备绘制线条，如果用户在下拉框中点击“不选择”这一元素，则flag更改为false，
            var customPen = new Pen(Color.FromArgb(_red, _green, _blue) , 30);
            _graphics.DrawLine(customPen,start, end);
            _graphics.FillEllipse(new SolidBrush(Color.White),
                new Rectangle(new Point(start.X, start.Y-15), Size.Round(new SizeF(28F, 28F))));
            var ltd = new LtdUtil();
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
            _graphics.DrawLine(customPen,start, end);
            _graphics.FillEllipse(new SolidBrush(Color.White),
                new Rectangle(new Point(start.X, start.Y-15), Size.Round(new SizeF(28F, 28F))));

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

        private void lineChoseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = lineChoseBox.SelectedText;
            if (result == NoneLine)
            {
                return;
            }
            var start = new Point(0, Size.Height / 2);
            var end = new Point(Size.Width, Size.Height / 2);
            var index = lineChoseBox.SelectedIndex -1;
            var crtLine = new Pen(_crtColors[index], 30);
            
            _graphics.DrawLine(crtLine,start, end);
            _graphics.FillEllipse(new SolidBrush(Color.White),
                new Rectangle(new Point(start.X, start.Y-15), Size.Round(new SizeF(28F, 28F))));
        }

        private void LTDWindow_Load(object sender, EventArgs e)
        {
            _lineItems.Add(NoneLine);
            _lineItems.AddRange(CRTColor.Lines);
            lineChoseBox.Items.AddRange(_lineItems.ToArray());
            for (var i = 1; i < 10; i++)
            {
                intervalBox.Items.Add(i + "分钟");
            }
            if (int.TryParse(msText.Text, out var ms))
            {
                timer.Interval = ms;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (stationAddText.Text == null) return;
            _stations.Add(stationAddText.Text);
            // stationDeleteBox.Items.Add(stationAddText.Text);
            fromComboBox.Items.Add(stationAddText.Text);
            toComboBox.Items.Add(stationAddText.Text);
            stationAddText.Text = @"";
            stationListBox.Items.AddRange(new object[] { _stations });
        }

        private void removeStation_Click(object sender, EventArgs e)
        {
            // if (stationDeleteBox.Items.Count == 0) return;
            // _stations.Remove(stationDeleteBox.SelectedText);
            // stationDeleteBox.Items.RemoveAt(stationDeleteBox.SelectedIndex);
            fromComboBox.Items.Remove(stationAddText.Text);
            toComboBox.Items.Remove(stationAddText.Text);
        }

        private void stationDeleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (stationDeleteBox.Items.Count == 0) return;
            // _stations.Remove(stationDeleteBox.SelectedText);
            //stationDeleteBox.Items.RemoveAt(stationDeleteBox.SelectedIndex);
        }

        private void addInterval_Click(object sender, EventArgs e)
        {
            
            if (_stations.Count <= 1) return;
            var time = int.Parse(intervalBox.Text.Substring(0,1));
            var timeList = new LinkedList<TimeTable>();
            foreach (var station in _stations)
            {
                timeList.AddLast(new LinkedListNode<TimeTable>(
                        new TimeTable(station, time)));
                _timeTable.Add(new TimeTable(station, time));
                // intervalListBox.Items.Add(station + ": " + time + "分钟");
                
            }
        }

        private void removeInterval_Click(object sender, EventArgs e)
        {
            if (_stations.Count <= 1) return;
            var time = int.Parse(intervalBox.Text.Substring(0,1));
            _timeTable.Remove(new TimeTable(intervalBox.SelectedText, time));
            intervalBox.Items.RemoveAt(intervalBox.SelectedIndex);
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toComboBox.Items.Count == 0) return;
            foreach (var timeTable in _timeTable.Where(timeTable => fromComboBox.SelectedText == timeTable.Id))
            {
                if (fromComboBox.SelectedText == toComboBox.SelectedText)
                {
                    timeLabel.Text = @"需要" + timeTable.Interval + @"分钟";
                }
                else if (_intervalTo != 0)
                {
                    _intervalFrom = timeTable.Interval + _intervalTo;
                    timeLabel.Text = @"需要" + _intervalFrom + @"分钟";
                }
            }
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromComboBox.Items.Count == 0) return;
            foreach (var timeTable in _timeTable.Where(timeTable => fromComboBox.SelectedText == timeTable.Id))
            {
                if (toComboBox.SelectedText == fromComboBox.SelectedText)
                {
                    timeLabel.Text = @"需要" + timeTable.Interval + @"分钟";
                }
                else if (_intervalFrom != 0)
                {
                    _intervalTo = timeTable.Interval + _intervalFrom;
                    timeLabel.Text = @"需要" + _intervalTo+ @"分钟";
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                
            }

            if (e.KeyChar == (int)Keys.Left && _carrigeIndex >= 1)
            {
                _carrigeIndex++;
            }

            if (e.KeyChar == (int)Keys.Right && _carrigeIndex <= 6)
            {
                _carrigeIndex--;
            }
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
            if (exitNumBox.Text == null) return;
            // stationDeleteBox.Items.Add(stationAddText.Text);
            exitNumBox.Text = @"";
        }

        private void exitInfoBox_TextChanged(object sender, EventArgs e)
        {
            if (exitInfoBox.Text == null) return;
            // stationDeleteBox.Items.Add(stationAddText.Text);
            exitInfoBox.Text = @"";
        
        }
    }
}