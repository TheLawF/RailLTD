using System;
using System.Windows.Forms;

namespace RailLTD
{
    partial class LTDWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.RichTextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.RichTextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.redText = new System.Windows.Forms.RichTextBox();
            this.greenLabel = new System.Windows.Forms.Label();
            this.greenText = new System.Windows.Forms.RichTextBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueText = new System.Windows.Forms.RichTextBox();
            this.crtLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.findLineLabel = new System.Windows.Forms.Label();
            this.lineListBox = new System.Windows.Forms.ComboBox();
            this.findStLabel = new System.Windows.Forms.Label();
            this.stationListBox = new System.Windows.Forms.ComboBox();
            this.lineRemoveButton = new System.Windows.Forms.Button();
            this.stRemoveButton = new System.Windows.Forms.Button();
            this.addLineButton = new System.Windows.Forms.Button();
            this.exitNumBox = new System.Windows.Forms.RichTextBox();
            this.exitNumlabel = new System.Windows.Forms.Label();
            this.exitInfoBox = new System.Windows.Forms.RichTextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.Label();
            this.msText = new System.Windows.Forms.RichTextBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.switchingLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.getInterval = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.addStationButton = new System.Windows.Forms.Button();
            this.stationAddText = new System.Windows.Forms.RichTextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.showLTD = new System.Windows.Forms.Button();
            this.lineChoseBox = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.Location = new System.Drawing.Point(9, 35);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(237, 50);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "线路名称：";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(252, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(320, 56);
            this.idText.TabIndex = 5;
            this.idText.Text = "";
            this.idText.TextChanged += new System.EventHandler(this.idText_TextChanged);
            // 
            // numLabel
            // 
            this.numLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLabel.Location = new System.Drawing.Point(999, 26);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(243, 50);
            this.numLabel.TabIndex = 6;
            this.numLabel.Text = "线路编号：";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(1255, 23);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(320, 56);
            this.numText.TabIndex = 7;
            this.numText.Text = "";
            this.numText.TextChanged += new System.EventHandler(this.numText_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorLabel.Location = new System.Drawing.Point(9, 128);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(237, 50);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "线路颜色：";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redLabel.Location = new System.Drawing.Point(210, 122);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(51, 50);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "R";
            // 
            // redText
            // 
            this.redText.Location = new System.Drawing.Point(252, 122);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(100, 56);
            this.redText.TabIndex = 10;
            this.redText.Text = "";
            this.redText.TextChanged += new System.EventHandler(this.redText_TextChanged);
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.greenLabel.Location = new System.Drawing.Point(358, 120);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(58, 50);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "G";
            // 
            // greenText
            // 
            this.greenText.Location = new System.Drawing.Point(404, 120);
            this.greenText.Name = "greenText";
            this.greenText.Size = new System.Drawing.Size(100, 56);
            this.greenText.TabIndex = 12;
            this.greenText.Text = "";
            this.greenText.TextChanged += new System.EventHandler(this.greenText_TextChanged);
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blueLabel.Location = new System.Drawing.Point(510, 122);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(50, 50);
            this.blueLabel.TabIndex = 13;
            this.blueLabel.Text = "B";
            // 
            // blueText
            // 
            this.blueText.Location = new System.Drawing.Point(563, 122);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(100, 56);
            this.blueText.TabIndex = 14;
            this.blueText.Text = "";
            this.blueText.TextChanged += new System.EventHandler(this.blueText_TextChanged);
            // 
            // crtLabel
            // 
            this.crtLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crtLabel.Location = new System.Drawing.Point(601, 29);
            this.crtLabel.Name = "crtLabel";
            this.crtLabel.Size = new System.Drawing.Size(205, 50);
            this.crtLabel.TabIndex = 15;
            this.crtLabel.Text = "选择线路：";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(931, 892);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(349, 66);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.findLineLabel);
            this.homePanel.Controls.Add(this.lineListBox);
            this.homePanel.Controls.Add(this.findStLabel);
            this.homePanel.Controls.Add(this.stationListBox);
            this.homePanel.Controls.Add(this.lineRemoveButton);
            this.homePanel.Controls.Add(this.stRemoveButton);
            this.homePanel.Controls.Add(this.addLineButton);
            this.homePanel.Controls.Add(this.exitNumBox);
            this.homePanel.Controls.Add(this.exitNumlabel);
            this.homePanel.Controls.Add(this.exitInfoBox);
            this.homePanel.Controls.Add(this.exitLabel);
            this.homePanel.Controls.Add(this.interval);
            this.homePanel.Controls.Add(this.msText);
            this.homePanel.Controls.Add(this.msLabel);
            this.homePanel.Controls.Add(this.switchingLabel);
            this.homePanel.Controls.Add(this.timeLabel);
            this.homePanel.Controls.Add(this.toComboBox);
            this.homePanel.Controls.Add(this.fromComboBox);
            this.homePanel.Controls.Add(this.toLabel);
            this.homePanel.Controls.Add(this.fromLabel);
            this.homePanel.Controls.Add(this.getInterval);
            this.homePanel.Controls.Add(this.intervalBox);
            this.homePanel.Controls.Add(this.addStationButton);
            this.homePanel.Controls.Add(this.stationAddText);
            this.homePanel.Controls.Add(this.stationLabel);
            this.homePanel.Controls.Add(this.showLTD);
            this.homePanel.Controls.Add(this.resetButton);
            this.homePanel.Controls.Add(this.lineChoseBox);
            this.homePanel.Controls.Add(this.crtLabel);
            this.homePanel.Controls.Add(this.blueText);
            this.homePanel.Controls.Add(this.blueLabel);
            this.homePanel.Controls.Add(this.greenText);
            this.homePanel.Controls.Add(this.greenLabel);
            this.homePanel.Controls.Add(this.redText);
            this.homePanel.Controls.Add(this.redLabel);
            this.homePanel.Controls.Add(this.colorLabel);
            this.homePanel.Controls.Add(this.numText);
            this.homePanel.Controls.Add(this.numLabel);
            this.homePanel.Controls.Add(this.idText);
            this.homePanel.Controls.Add(this.idLabel);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1906, 1050);
            this.homePanel.TabIndex = 18;
            // 
            // findLineLabel
            // 
            this.findLineLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findLineLabel.Location = new System.Drawing.Point(740, 125);
            this.findLineLabel.Name = "findLineLabel";
            this.findLineLabel.Size = new System.Drawing.Size(217, 62);
            this.findLineLabel.TabIndex = 54;
            this.findLineLabel.Text = "查找线路：";
            // 
            // lineListBox
            // 
            this.lineListBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineListBox.FormattingEnabled = true;
            this.lineListBox.Location = new System.Drawing.Point(963, 125);
            this.lineListBox.Name = "lineListBox";
            this.lineListBox.Size = new System.Drawing.Size(313, 56);
            this.lineListBox.TabIndex = 53;
            // 
            // findStLabel
            // 
            this.findStLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findStLabel.Location = new System.Drawing.Point(457, 429);
            this.findStLabel.Name = "findStLabel";
            this.findStLabel.Size = new System.Drawing.Size(217, 62);
            this.findStLabel.TabIndex = 52;
            this.findStLabel.Text = "查找车站：";
            // 
            // stationListBox
            // 
            this.stationListBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.Location = new System.Drawing.Point(680, 426);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(313, 56);
            this.stationListBox.TabIndex = 51;
            // 
            // lineRemoveButton
            // 
            this.lineRemoveButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineRemoveButton.Location = new System.Drawing.Point(457, 217);
            this.lineRemoveButton.Name = "lineRemoveButton";
            this.lineRemoveButton.Size = new System.Drawing.Size(240, 60);
            this.lineRemoveButton.TabIndex = 50;
            this.lineRemoveButton.Text = "删除线路";
            this.lineRemoveButton.UseVisualStyleBackColor = true;
            // 
            // stRemoveButton
            // 
            this.stRemoveButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stRemoveButton.Location = new System.Drawing.Point(457, 509);
            this.stRemoveButton.Name = "stRemoveButton";
            this.stRemoveButton.Size = new System.Drawing.Size(240, 60);
            this.stRemoveButton.TabIndex = 49;
            this.stRemoveButton.Text = "删除车站";
            this.stRemoveButton.UseVisualStyleBackColor = true;
            // 
            // addLineButton
            // 
            this.addLineButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addLineButton.Location = new System.Drawing.Point(9, 217);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(240, 60);
            this.addLineButton.TabIndex = 48;
            this.addLineButton.Text = "添加线路";
            this.addLineButton.UseVisualStyleBackColor = true;
            // 
            // exitNumBox
            // 
            this.exitNumBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitNumBox.Location = new System.Drawing.Point(857, 347);
            this.exitNumBox.Name = "exitNumBox";
            this.exitNumBox.Size = new System.Drawing.Size(136, 56);
            this.exitNumBox.TabIndex = 47;
            this.exitNumBox.Text = "";
            this.exitNumBox.TextChanged += new System.EventHandler(this.exitNumBox_TextChanged);
            // 
            // exitNumlabel
            // 
            this.exitNumlabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitNumlabel.Location = new System.Drawing.Point(601, 351);
            this.exitNumlabel.Name = "exitNumlabel";
            this.exitNumlabel.Size = new System.Drawing.Size(273, 54);
            this.exitNumlabel.TabIndex = 46;
            this.exitNumlabel.Text = "出入口编号：";
            // 
            // exitInfoBox
            // 
            this.exitInfoBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitInfoBox.Location = new System.Drawing.Point(1255, 347);
            this.exitInfoBox.Name = "exitInfoBox";
            this.exitInfoBox.Size = new System.Drawing.Size(320, 56);
            this.exitInfoBox.TabIndex = 45;
            this.exitInfoBox.Text = "";
            this.exitInfoBox.TextChanged += new System.EventHandler(this.exitInfoBox_TextChanged);
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitLabel.Location = new System.Drawing.Point(1006, 356);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(243, 49);
            this.exitLabel.TabIndex = 44;
            this.exitLabel.Text = "车站出入口：";
            // 
            // interval
            // 
            this.interval.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interval.Location = new System.Drawing.Point(9, 429);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(237, 50);
            this.interval.TabIndex = 43;
            this.interval.Text = "车站间隔：";
            // 
            // msText
            // 
            this.msText.Font = new System.Drawing.Font("微软雅黑", 13.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msText.Location = new System.Drawing.Point(302, 730);
            this.msText.Name = "msText";
            this.msText.Size = new System.Drawing.Size(270, 56);
            this.msText.TabIndex = 42;
            this.msText.Text = "5000";
            this.msText.TextChanged += new System.EventHandler(this.MsText_TextChanged);
            // 
            // msLabel
            // 
            this.msLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msLabel.Location = new System.Drawing.Point(578, 734);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(96, 58);
            this.msLabel.TabIndex = 41;
            this.msLabel.Text = "毫秒";
            // 
            // switchingLabel
            // 
            this.switchingLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switchingLabel.Location = new System.Drawing.Point(9, 734);
            this.switchingLabel.Name = "switchingLabel";
            this.switchingLabel.Size = new System.Drawing.Size(294, 58);
            this.switchingLabel.TabIndex = 39;
            this.switchingLabel.Text = "画面滚动间隔：";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(908, 637);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(259, 64);
            this.timeLabel.TabIndex = 38;
            this.timeLabel.Text = "需要*分钟";
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(629, 637);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(258, 56);
            this.toComboBox.TabIndex = 37;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(302, 637);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(270, 56);
            this.fromComboBox.TabIndex = 36;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // toLabel
            // 
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLabel.Location = new System.Drawing.Point(578, 640);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(83, 67);
            this.toLabel.TabIndex = 34;
            this.toLabel.Text = "到";
            // 
            // fromLabel
            // 
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromLabel.Location = new System.Drawing.Point(243, 644);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(71, 67);
            this.fromLabel.TabIndex = 33;
            this.fromLabel.Text = "从";
            // 
            // getInterval
            // 
            this.getInterval.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getInterval.Location = new System.Drawing.Point(9, 644);
            this.getInterval.Name = "getInterval";
            this.getInterval.Size = new System.Drawing.Size(247, 67);
            this.getInterval.TabIndex = 31;
            this.getInterval.Text = "查询时刻表：";
            // 
            // intervalBox
            // 
            this.intervalBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Location = new System.Drawing.Point(252, 423);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(145, 56);
            this.intervalBox.TabIndex = 30;
            // 
            // addStationButton
            // 
            this.addStationButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addStationButton.Location = new System.Drawing.Point(9, 509);
            this.addStationButton.Name = "addStationButton";
            this.addStationButton.Size = new System.Drawing.Size(240, 60);
            this.addStationButton.TabIndex = 21;
            this.addStationButton.Text = "添加车站";
            this.addStationButton.UseVisualStyleBackColor = true;
            this.addStationButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // stationAddText
            // 
            this.stationAddText.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationAddText.Location = new System.Drawing.Point(252, 349);
            this.stationAddText.Name = "stationAddText";
            this.stationAddText.Size = new System.Drawing.Size(320, 56);
            this.stationAddText.TabIndex = 20;
            this.stationAddText.Text = "";
            // 
            // stationLabel
            // 
            this.stationLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stationLabel.Location = new System.Drawing.Point(9, 355);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(237, 50);
            this.stationLabel.TabIndex = 19;
            this.stationLabel.Text = "车站名称：";
            // 
            // showLTD
            // 
            this.showLTD.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showLTD.Location = new System.Drawing.Point(252, 892);
            this.showLTD.Name = "showLTD";
            this.showLTD.Size = new System.Drawing.Size(349, 66);
            this.showLTD.TabIndex = 18;
            this.showLTD.Text = "Show LTD";
            this.showLTD.UseVisualStyleBackColor = true;
            this.showLTD.Click += new System.EventHandler(this.showLTD_Click);
            // 
            // lineChoseBox
            // 
            this.lineChoseBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineChoseBox.FormattingEnabled = true;
            this.lineChoseBox.Location = new System.Drawing.Point(812, 23);
            this.lineChoseBox.Name = "lineChoseBox";
            this.lineChoseBox.Size = new System.Drawing.Size(145, 56);
            this.lineChoseBox.TabIndex = 16;
            this.lineChoseBox.SelectedIndexChanged += new System.EventHandler(this.lineChoseBox_SelectedIndexChanged);
            // 
            // LTDWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1051);
            this.Controls.Add(this.homePanel);
            this.Name = "LTDWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LTDWindow_Load);
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label findLineLabel;
        private System.Windows.Forms.ComboBox lineListBox;

        private System.Windows.Forms.Label findStLabel;

        private System.Windows.Forms.ComboBox stationListBox;

        private System.Windows.Forms.Button lineRemoveButton;

        private System.Windows.Forms.Button stRemoveButton;

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button addLineButton;

        private System.Windows.Forms.RichTextBox exitNumBox;

        private System.Windows.Forms.RichTextBox exitInfoBox;

        private System.Windows.Forms.Label exitNumlabel;

        private System.Windows.Forms.RichTextBox msText;

        private System.Windows.Forms.Label msLabel;

        private System.Windows.Forms.Label switchingLabel;

        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Label timeLabel;

        private System.Windows.Forms.ComboBox fromComboBox;

        private System.Windows.Forms.Label toLabel;

        private System.Windows.Forms.Label fromLabel;

        private System.Windows.Forms.ComboBox intervalBox;
        private System.Windows.Forms.Label getInterval;

        private System.Windows.Forms.Label interval;

        private System.Windows.Forms.RichTextBox stationAddText;
        private System.Windows.Forms.Button addStationButton;

        private System.Windows.Forms.Label stationLabel;

        private System.Windows.Forms.Button showLTD;

        private System.Windows.Forms.Panel homePanel;

        private System.Windows.Forms.Button resetButton;

        private System.Windows.Forms.ComboBox lineChoseBox;

        private System.Windows.Forms.Label crtLabel;

        private System.Windows.Forms.RichTextBox blueText;
        private System.Windows.Forms.Label redLabel;

        private System.Windows.Forms.RichTextBox greenText;
        private System.Windows.Forms.Label blueLabel;

        private System.Windows.Forms.Label numLabel;

        private System.Windows.Forms.RichTextBox redText;

        private System.Windows.Forms.RichTextBox numText;
        private System.Windows.Forms.Label colorLabel;

        private System.Windows.Forms.RichTextBox idText;
        private System.Windows.Forms.Label greenLabel;

        private System.Windows.Forms.Label idLabel;
        private Timer timer;

        #endregion
    }
}