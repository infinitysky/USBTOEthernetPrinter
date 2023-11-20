
using System.IO;

namespace LocalPrinterServer
{
    partial class LocalPrinterServerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPrinterServerMain));
            this.SettingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultPrinterNameLabel = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(12, 305);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(77, 23);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "Setting";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(280, 305);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Local Printer Server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LocalPrinterServer.Properties.Resources.Snipaste_2023_11_20_00_01_12;
            this.pictureBox1.InitialImage = global::LocalPrinterServer.Properties.Resources.Snipaste_2023_11_20_00_01_12;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 165);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Printer Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefaultPrinterNameLabel
            // 
            this.DefaultPrinterNameLabel.AutoSize = true;
            this.DefaultPrinterNameLabel.Location = new System.Drawing.Point(156, 262);
            this.DefaultPrinterNameLabel.Name = "DefaultPrinterNameLabel";
            this.DefaultPrinterNameLabel.Size = new System.Drawing.Size(0, 13);
            this.DefaultPrinterNameLabel.TabIndex = 4;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(139, 305);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // LocalPrinterServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 374);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.DefaultPrinterNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LocalPrinterServerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Printer Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DefaultPrinterNameLabel;
        private System.Windows.Forms.Button HideButton;
    }
}

