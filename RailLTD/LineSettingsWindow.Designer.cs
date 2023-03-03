using System.ComponentModel;

namespace RailLTD
{
    partial class LineSettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.findStLabel = new System.Windows.Forms.Label();
            this.stationListBox = new System.Windows.Forms.ComboBox();
            this.stRemoveButton = new System.Windows.Forms.Button();
            this.exitNumBox = new System.Windows.Forms.RichTextBox();
            this.exitNumlabel = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.Label();
            this.addStationButton = new System.Windows.Forms.Button();
            this.stationAddText = new System.Windows.Forms.RichTextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.exitInfoBox = new System.Windows.Forms.RichTextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.lineHead = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toStationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findStLabel
            // 
            this.findStLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findStLabel.Location = new System.Drawing.Point(49, 684);
            this.findStLabel.Name = "findStLabel";
            this.findStLabel.Size = new System.Drawing.Size(217, 62);
            this.findStLabel.TabIndex = 62;
            this.findStLabel.Text = "车站列表：";
            // 
            // stationListBox
            // 
            this.stationListBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.Location = new System.Drawing.Point(295, 681);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(313, 56);
            this.stationListBox.TabIndex = 61;
            this.stationListBox.SelectedIndexChanged += new System.EventHandler(this.stationListBox_SelectedIndexChanged);
            // 
            // stRemoveButton
            // 
            this.stRemoveButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stRemoveButton.Location = new System.Drawing.Point(440, 835);
            this.stRemoveButton.Name = "stRemoveButton";
            this.stRemoveButton.Size = new System.Drawing.Size(240, 60);
            this.stRemoveButton.TabIndex = 60;
            this.stRemoveButton.Text = "删除车站";
            this.stRemoveButton.UseVisualStyleBackColor = true;
            this.stRemoveButton.Click += new System.EventHandler(this.stRemoveButton_Click);
            // 
            // exitNumBox
            // 
            this.exitNumBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitNumBox.Location = new System.Drawing.Point(285, 308);
            this.exitNumBox.Name = "exitNumBox";
            this.exitNumBox.Size = new System.Drawing.Size(145, 56);
            this.exitNumBox.TabIndex = 59;
            this.exitNumBox.Text = "";
            this.exitNumBox.TextChanged += new System.EventHandler(this.exitNumBox_TextChanged);
            // 
            // exitNumlabel
            // 
            this.exitNumlabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitNumlabel.Location = new System.Drawing.Point(39, 311);
            this.exitNumlabel.Name = "exitNumlabel";
            this.exitNumlabel.Size = new System.Drawing.Size(273, 54);
            this.exitNumlabel.TabIndex = 58;
            this.exitNumlabel.Text = "出入口编号：";
            // 
            // interval
            // 
            this.interval.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interval.Location = new System.Drawing.Point(39, 442);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(237, 50);
            this.interval.TabIndex = 57;
            this.interval.Text = "车站间隔：";
            // 
            // addStationButton
            // 
            this.addStationButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addStationButton.Location = new System.Drawing.Point(39, 835);
            this.addStationButton.Name = "addStationButton";
            this.addStationButton.Size = new System.Drawing.Size(240, 60);
            this.addStationButton.TabIndex = 55;
            this.addStationButton.Text = "添加车站";
            this.addStationButton.UseVisualStyleBackColor = true;
            this.addStationButton.Click += new System.EventHandler(this.addStationButton_Click);
            // 
            // stationAddText
            // 
            this.stationAddText.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationAddText.Location = new System.Drawing.Point(285, 136);
            this.stationAddText.Name = "stationAddText";
            this.stationAddText.Size = new System.Drawing.Size(320, 56);
            this.stationAddText.TabIndex = 54;
            this.stationAddText.Text = "";
            // 
            // stationLabel
            // 
            this.stationLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationLabel.Location = new System.Drawing.Point(39, 139);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(237, 50);
            this.stationLabel.TabIndex = 53;
            this.stationLabel.Text = "车站名称：";
            // 
            // exitInfoBox
            // 
            this.exitInfoBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitInfoBox.Location = new System.Drawing.Point(285, 246);
            this.exitInfoBox.Name = "exitInfoBox";
            this.exitInfoBox.Size = new System.Drawing.Size(320, 56);
            this.exitInfoBox.TabIndex = 64;
            this.exitInfoBox.Text = "";
            this.exitInfoBox.TextChanged += new System.EventHandler(this.exitInfoBox_TextChanged);
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitLabel.Location = new System.Drawing.Point(39, 253);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(243, 49);
            this.exitLabel.TabIndex = 63;
            this.exitLabel.Text = "车站出入口：";
            // 
            // lineHead
            // 
            this.lineHead.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineHead.Location = new System.Drawing.Point(39, 43);
            this.lineHead.Name = "lineHead";
            this.lineHead.Size = new System.Drawing.Size(357, 63);
            this.lineHead.TabIndex = 65;
            this.lineHead.Text = "当前线路：";
            // 
            // intervalBox
            // 
            this.intervalBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Location = new System.Drawing.Point(553, 559);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(145, 56);
            this.intervalBox.TabIndex = 56;
            this.intervalBox.SelectedIndexChanged += new System.EventHandler(this.intervalBox_SelectedIndexChanged);
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(160, 492);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(270, 56);
            this.fromComboBox.TabIndex = 68;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // toLabel
            // 
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLabel.Location = new System.Drawing.Point(49, 562);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(105, 67);
            this.toLabel.TabIndex = 67;
            this.toLabel.Text = "到：";
            // 
            // fromLabel
            // 
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromLabel.Location = new System.Drawing.Point(49, 495);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(105, 67);
            this.fromLabel.TabIndex = 66;
            this.fromLabel.Text = "从：";
            // 
            // toStationLabel
            // 
            this.toStationLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toStationLabel.Location = new System.Drawing.Point(160, 559);
            this.toStationLabel.Name = "toStationLabel";
            this.toStationLabel.Size = new System.Drawing.Size(236, 54);
            this.toStationLabel.TabIndex = 69;
            this.toStationLabel.Text = "（下一站）";
            this.toStationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(432, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 57);
            this.label2.TabIndex = 70;
            this.label2.Text = "需要";
            // 
            // LineSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 982);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toStationLabel);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.lineHead);
            this.Controls.Add(this.exitInfoBox);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.findStLabel);
            this.Controls.Add(this.stationListBox);
            this.Controls.Add(this.stRemoveButton);
            this.Controls.Add(this.exitNumBox);
            this.Controls.Add(this.exitNumlabel);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.addStationButton);
            this.Controls.Add(this.stationAddText);
            this.Controls.Add(this.stationLabel);
            this.Name = "LineSettingsWindow";
            this.Text = "LineSettingsWindow";
            this.Load += new System.EventHandler(this.LineSettingsWindow_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label toStationLabel;

        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;

        private System.Windows.Forms.RichTextBox exitInfoBox;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label lineHead;

        private System.Windows.Forms.Label findStLabel;
        private System.Windows.Forms.ComboBox stationListBox;
        private System.Windows.Forms.Button stRemoveButton;
        private System.Windows.Forms.RichTextBox exitNumBox;
        private System.Windows.Forms.Label exitNumlabel;
        private System.Windows.Forms.Label interval;
        private System.Windows.Forms.ComboBox intervalBox;
        private System.Windows.Forms.Button addStationButton;
        private System.Windows.Forms.RichTextBox stationAddText;
        private System.Windows.Forms.Label stationLabel;

        #endregion
    }
}