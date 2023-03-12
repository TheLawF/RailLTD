using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RailLTD
{
    public partial class LineSettingsWindow : Form
    {
        public string LineID;
        public List<Station> Stations = new List<Station>();
        public List<TimeTable> TimeTable = new List<TimeTable>();
        
        public LineSettingsWindow()
        {
            InitializeComponent();
        }
        private void exitInfoBox_TextChanged(object sender, EventArgs e)
        {
            if (exitInfoBox.Text == null) return;
            // stationDeleteBox.Items.Add(stationAddText.Text);
            exitInfoBox.Text = @"";
        }

        private void exitNumBox_TextChanged(object sender, EventArgs e)
        {
            if (exitNumBox.Text == null) return;
            // stationDeleteBox.Items.Add(stationAddText.Text);
            exitNumBox.Text = @"";
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var timeTable in TimeTable.Where(timeTable => fromComboBox.SelectedText == timeTable.Id))
            {
                
            }
        }

        private void intervalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void stationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addStationButton_Click(object sender, EventArgs e)
        {
            if (stationAddText.Text == null) return;
            int.TryParse(exitNumBox.Text, out var num);
            var station = new Station(
                stationAddText.Text,
                null,
                0,
                false,
                null);
            Stations.Add(station);
            // stationDeleteBox.Items.Add(stationAddText.Text);
            fromComboBox.Items.Add(stationAddText.Text);
            stationAddText.Text = @"";
            Stations.ForEach(s => stationListBox.Items.Add(s.Name));
            // AddInterval();
        }

        private void stRemoveButton_Click(object sender, EventArgs e)
        {
            if (Stations.Any()) return;
            Stations.ForEach(s =>
            {
                if (!Equals(s.Name, stationListBox.SelectedText)) return;
                stationListBox.Items.Remove(stationListBox.SelectedText);
                Stations.Remove(s);
            });
        }

        private void LineSettingsWindow_Load(object sender, EventArgs e)
        {
            lineHead.Text += LineID;
            for (var i = 1; i < 10; i++)
            {
                intervalBox.Items.Add(i + "分钟");
            }   
            Stations.ForEach(s => stationListBox.Items.Add(s.Name));
        }
        
        private void AddInterval()
        {
            
            if (Stations.Count <= 1) return;
            var time = int.Parse(intervalBox.Text.Substring(0,1));
            var timeList = new LinkedList<TimeTable>();
            foreach (var station in Stations)
            {
                timeList.AddLast(new LinkedListNode<TimeTable>(
                    new TimeTable(station.Name, time)));
                TimeTable.Add(new TimeTable(station.Name, time));
                // intervalListBox.Items.Add(station + ": " + time + "分钟");
                
            }
        }

        private void stationAddText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (int)Keys.Enter) return;
            int.TryParse(exitNumBox.Text, out var num);
            var station = new Station(
                stationAddText.Text,
                null,
                0,
                false,
                null);
            Stations.Add(station);
            // stationDeleteBox.Items.Add(stationAddText.Text);
            fromComboBox.Items.Add(stationAddText.Text);
            stationAddText.Text = @"";
            Stations.ForEach(s => stationListBox.Items.Add(s.Name));
            // AddInterval();
        }
    }
}