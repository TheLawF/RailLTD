using System.ComponentModel;

namespace RailLTD
{
    partial class SettingsDialog
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.disposeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HomeButton.Location = new System.Drawing.Point(12, 351);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(244, 75);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "返回主界面";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.settingsLabel.Location = new System.Drawing.Point(250, 119);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(286, 83);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "设置菜单";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(272, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(248, 75);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "返回LTD";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // disposeButton
            // 
            this.disposeButton.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.disposeButton.Location = new System.Drawing.Point(542, 351);
            this.disposeButton.Name = "disposeButton";
            this.disposeButton.Size = new System.Drawing.Size(246, 75);
            this.disposeButton.TabIndex = 3;
            this.disposeButton.Text = "关闭对话框";
            this.disposeButton.UseVisualStyleBackColor = true;
            this.disposeButton.Click += new System.EventHandler(this.disposeButton_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disposeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.HomeButton);
            this.Name = "SettingsDialog";
            this.Text = "SettingsDialog";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button disposeButton;

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label settingsLabel;

        #endregion
    }
}