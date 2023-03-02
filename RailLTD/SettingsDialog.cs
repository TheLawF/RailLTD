using System;
using System.Windows.Forms;

namespace RailLTD
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LtdUtil.LoadHomeScene();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void disposeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}