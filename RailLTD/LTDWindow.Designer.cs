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
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.resetButton = new System.Windows.Forms.Button();
            this.showLTD = new System.Windows.Forms.Button();
            this.editStationButton = new System.Windows.Forms.Button();
            this.switchingLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            this.msText = new System.Windows.Forms.RichTextBox();
            this.addLineButton = new System.Windows.Forms.Button();
            this.lineRemoveButton = new System.Windows.Forms.Button();
            this.lineListBox = new System.Windows.Forms.ComboBox();
            this.findLineLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.Location = new System.Drawing.Point(13, 35);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(237, 50);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "线路名称：";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(263, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(450, 56);
            this.idText.TabIndex = 5;
            this.idText.Text = "";
            this.idText.TextChanged += new System.EventHandler(this.idText_TextChanged);
            // 
            // numLabel
            // 
            this.numLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLabel.Location = new System.Drawing.Point(13, 125);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(243, 50);
            this.numLabel.TabIndex = 6;
            this.numLabel.Text = "线路编号：";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(262, 119);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(451, 56);
            this.numText.TabIndex = 7;
            this.numText.Text = "";
            this.numText.TextChanged += new System.EventHandler(this.numText_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorLabel.Location = new System.Drawing.Point(15, 215);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(237, 50);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "线路颜色：";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redLabel.Location = new System.Drawing.Point(260, 209);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(51, 50);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "R";
            // 
            // redText
            // 
            this.redText.Location = new System.Drawing.Point(302, 209);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(100, 56);
            this.redText.TabIndex = 10;
            this.redText.Text = "";
            this.redText.TextChanged += new System.EventHandler(this.redText_TextChanged);
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.greenLabel.Location = new System.Drawing.Point(408, 207);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(58, 50);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "G";
            // 
            // greenText
            // 
            this.greenText.Location = new System.Drawing.Point(454, 207);
            this.greenText.Name = "greenText";
            this.greenText.Size = new System.Drawing.Size(100, 56);
            this.greenText.TabIndex = 12;
            this.greenText.Text = "";
            this.greenText.TextChanged += new System.EventHandler(this.greenText_TextChanged);
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blueLabel.Location = new System.Drawing.Point(560, 209);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(50, 50);
            this.blueLabel.TabIndex = 13;
            this.blueLabel.Text = "B";
            // 
            // blueText
            // 
            this.blueText.Location = new System.Drawing.Point(613, 209);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(100, 56);
            this.blueText.TabIndex = 14;
            this.blueText.Text = "";
            this.blueText.TextChanged += new System.EventHandler(this.blueText_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(547, 695);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(349, 66);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // showLTD
            // 
            this.showLTD.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showLTD.Location = new System.Drawing.Point(53, 695);
            this.showLTD.Name = "showLTD";
            this.showLTD.Size = new System.Drawing.Size(349, 66);
            this.showLTD.TabIndex = 18;
            this.showLTD.Text = "Show LTD";
            this.showLTD.UseVisualStyleBackColor = true;
            this.showLTD.Click += new System.EventHandler(this.showLTD_Click);
            // 
            // editStationButton
            // 
            this.editStationButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editStationButton.Location = new System.Drawing.Point(13, 486);
            this.editStationButton.Name = "editStationButton";
            this.editStationButton.Size = new System.Drawing.Size(240, 60);
            this.editStationButton.TabIndex = 21;
            this.editStationButton.Text = "编辑车站";
            this.editStationButton.UseVisualStyleBackColor = true;
            this.editStationButton.Click += new System.EventHandler(this.editStationButton_Click);
            // 
            // switchingLabel
            // 
            this.switchingLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switchingLabel.Location = new System.Drawing.Point(9, 589);
            this.switchingLabel.Name = "switchingLabel";
            this.switchingLabel.Size = new System.Drawing.Size(294, 58);
            this.switchingLabel.TabIndex = 39;
            this.switchingLabel.Text = "画面滚动间隔：";
            // 
            // msLabel
            // 
            this.msLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msLabel.Location = new System.Drawing.Point(578, 589);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(122, 58);
            this.msLabel.TabIndex = 41;
            this.msLabel.Text = "毫秒";
            // 
            // msText
            // 
            this.msText.Font = new System.Drawing.Font("微软雅黑", 13.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msText.Location = new System.Drawing.Point(302, 585);
            this.msText.Name = "msText";
            this.msText.Size = new System.Drawing.Size(270, 56);
            this.msText.TabIndex = 42;
            this.msText.Text = "8000";
            this.msText.TextChanged += new System.EventHandler(this.MsText_TextChanged);
            // 
            // addLineButton
            // 
            this.addLineButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addLineButton.Location = new System.Drawing.Point(13, 392);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(240, 60);
            this.addLineButton.TabIndex = 48;
            this.addLineButton.Text = "添加线路";
            this.addLineButton.UseVisualStyleBackColor = true;
            this.addLineButton.Click += new System.EventHandler(this.addLineButton_Click);
            // 
            // lineRemoveButton
            // 
            this.lineRemoveButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineRemoveButton.Location = new System.Drawing.Point(314, 392);
            this.lineRemoveButton.Name = "lineRemoveButton";
            this.lineRemoveButton.Size = new System.Drawing.Size(240, 60);
            this.lineRemoveButton.TabIndex = 50;
            this.lineRemoveButton.Text = "删除线路";
            this.lineRemoveButton.UseVisualStyleBackColor = true;
            // 
            // lineListBox
            // 
            this.lineListBox.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineListBox.FormattingEnabled = true;
            this.lineListBox.Location = new System.Drawing.Point(259, 299);
            this.lineListBox.Name = "lineListBox";
            this.lineListBox.Size = new System.Drawing.Size(454, 56);
            this.lineListBox.TabIndex = 53;
            // 
            // findLineLabel
            // 
            this.findLineLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findLineLabel.Location = new System.Drawing.Point(13, 299);
            this.findLineLabel.Name = "findLineLabel";
            this.findLineLabel.Size = new System.Drawing.Size(217, 62);
            this.findLineLabel.TabIndex = 54;
            this.findLineLabel.Text = "查找线路：";
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.saveConfigButton);
            this.homePanel.Controls.Add(this.findLineLabel);
            this.homePanel.Controls.Add(this.lineListBox);
            this.homePanel.Controls.Add(this.lineRemoveButton);
            this.homePanel.Controls.Add(this.addLineButton);
            this.homePanel.Controls.Add(this.msText);
            this.homePanel.Controls.Add(this.msLabel);
            this.homePanel.Controls.Add(this.switchingLabel);
            this.homePanel.Controls.Add(this.editStationButton);
            this.homePanel.Controls.Add(this.showLTD);
            this.homePanel.Controls.Add(this.resetButton);
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
            this.homePanel.Size = new System.Drawing.Size(1403, 835);
            this.homePanel.TabIndex = 18;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveConfigButton.Location = new System.Drawing.Point(314, 486);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(240, 60);
            this.saveConfigButton.TabIndex = 55;
            this.saveConfigButton.Text = "保存配置";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            // 
            // LTDWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1405, 838);
            this.Controls.Add(this.homePanel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "LTDWindow";
            this.Load += new System.EventHandler(this.LTDWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LTDWindow_KeyPress);
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button saveConfigButton;

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.RichTextBox idText;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.RichTextBox numText;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.RichTextBox redText;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.RichTextBox greenText;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.RichTextBox blueText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button showLTD;
        private System.Windows.Forms.Button editStationButton;
        private System.Windows.Forms.Label switchingLabel;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.RichTextBox msText;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.Button lineRemoveButton;
        private System.Windows.Forms.ComboBox lineListBox;
        private System.Windows.Forms.Label findLineLabel;
        private System.Windows.Forms.Panel homePanel;

        private System.Windows.Forms.Timer timer;

        #endregion
    }
}