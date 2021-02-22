﻿namespace Auto_Tweaking_Utility
{
    partial class ProcessExplorerSetupForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
	
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessExplorerSetupForm));
            this.Line2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.DestinationFolder = new System.Windows.Forms.GroupBox();
            this.InstallPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.ProcessExplorer = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.CheckBoxReplaceTaskManagerWithProcessExplorer = new System.Windows.Forms.CheckBox();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Titlebar_Label = new System.Windows.Forms.Label();
            this.Titlebar_Close = new System.Windows.Forms.Button();
            this.DestinationFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessExplorer)).BeginInit();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line2
            // 
            this.Line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line2.Location = new System.Drawing.Point(-8, 335);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(499, 2);
            this.Line2.TabIndex = 79;
            this.Line2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label6.Location = new System.Drawing.Point(9, 261);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(131, 13);
            this.Label6.TabIndex = 78;
            this.Label6.Text = "Space required: 1.42 MB";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label5.Location = new System.Drawing.Point(9, 108);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(372, 39);
            this.Label5.TabIndex = 77;
            this.Label5.Text = "Setup will install Process Explorer in the following folder. To install in a\r\ndif" +
    "ferent folder, click Browse and select another folder.\r\nClick Install to start t" +
    "he installation.";
            // 
            // DestinationFolder
            // 
            this.DestinationFolder.Controls.Add(this.InstallPath);
            this.DestinationFolder.Controls.Add(this.ButtonBrowse);
            this.DestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinationFolder.Location = new System.Drawing.Point(12, 199);
            this.DestinationFolder.Name = "DestinationFolder";
            this.DestinationFolder.Size = new System.Drawing.Size(463, 59);
            this.DestinationFolder.TabIndex = 76;
            this.DestinationFolder.TabStop = false;
            this.DestinationFolder.Text = "Destination folder";
            // 
            // InstallPath
            // 
            this.InstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.InstallPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstallPath.ForeColor = System.Drawing.Color.White;
            this.InstallPath.Location = new System.Drawing.Point(11, 23);
            this.InstallPath.Name = "InstallPath";
            this.InstallPath.ReadOnly = true;
            this.InstallPath.Size = new System.Drawing.Size(355, 22);
            this.InstallPath.TabIndex = 57;
            this.InstallPath.Text = "C:\\Program Files\\Process Explorer";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBrowse.Location = new System.Drawing.Point(372, 23);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 22);
            this.ButtonBrowse.TabIndex = 58;
            this.ButtonBrowse.Text = "Browse..";
            this.ButtonBrowse.UseVisualStyleBackColor = false;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(400, 345);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 21);
            this.ButtonCancel.TabIndex = 74;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.ButtonInstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstall.Location = new System.Drawing.Point(319, 345);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(75, 21);
            this.ButtonInstall.TabIndex = 73;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.UseVisualStyleBackColor = false;
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // ProcessExplorer
            // 
            this.ProcessExplorer.Image = ((System.Drawing.Image)(resources.GetObject("ProcessExplorer.Image")));
            this.ProcessExplorer.Location = new System.Drawing.Point(415, 29);
            this.ProcessExplorer.Name = "ProcessExplorer";
            this.ProcessExplorer.Size = new System.Drawing.Size(64, 64);
            this.ProcessExplorer.TabIndex = 71;
            this.ProcessExplorer.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label4.Location = new System.Drawing.Point(28, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(257, 13);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "Select where you want to install Process Explorer";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 45);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 13);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Custom Setup";
            // 
            // Line1
            // 
            this.Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line1.Location = new System.Drawing.Point(-8, 94);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(499, 2);
            this.Line1.TabIndex = 80;
            this.Line1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckBoxReplaceTaskManagerWithProcessExplorer
            // 
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.AutoSize = true;
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.Location = new System.Drawing.Point(12, 309);
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.Name = "CheckBoxReplaceTaskManagerWithProcessExplorer";
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.Size = new System.Drawing.Size(247, 17);
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.TabIndex = 81;
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.Text = "Replace task manager with Process Explorer";
            this.CheckBoxReplaceTaskManagerWithProcessExplorer.UseVisualStyleBackColor = true;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.Titlebar.Controls.Add(this.Titlebar_Label);
            this.Titlebar.Controls.Add(this.Titlebar_Close);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(481, 25);
            this.Titlebar.TabIndex = 137;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Label
            // 
            this.Titlebar_Label.AutoSize = true;
            this.Titlebar_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Label.ForeColor = System.Drawing.Color.White;
            this.Titlebar_Label.Location = new System.Drawing.Point(4, 5);
            this.Titlebar_Label.Name = "Titlebar_Label";
            this.Titlebar_Label.Size = new System.Drawing.Size(123, 13);
            this.Titlebar_Label.TabIndex = 3;
            this.Titlebar_Label.Text = "Process Explorer Setup";
            this.Titlebar_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // Titlebar_Close
            // 
            this.Titlebar_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar_Close.BackgroundImage")));
            this.Titlebar_Close.FlatAppearance.BorderSize = 0;
            this.Titlebar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlebar_Close.Location = new System.Drawing.Point(462, 4);
            this.Titlebar_Close.Name = "Titlebar_Close";
            this.Titlebar_Close.Size = new System.Drawing.Size(15, 15);
            this.Titlebar_Close.TabIndex = 0;
            this.Titlebar_Close.UseVisualStyleBackColor = true;
            this.Titlebar_Close.Click += new System.EventHandler(this.Titlebar_Close_Click);
            // 
            // ProcessExplorerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(481, 376);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.CheckBoxReplaceTaskManagerWithProcessExplorer);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.DestinationFolder);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInstall);
            this.Controls.Add(this.ProcessExplorer);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessExplorerSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Explorer Setup";
            this.Shown += new System.EventHandler(this.InstallProcessExplorerForm_Shown);
            this.DestinationFolder.ResumeLayout(false);
            this.DestinationFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessExplorer)).EndInit();
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.GroupBox DestinationFolder;
        private System.Windows.Forms.TextBox InstallPath;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.PictureBox ProcessExplorer;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.CheckBox CheckBoxReplaceTaskManagerWithProcessExplorer;
        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Label Titlebar_Label;
        private System.Windows.Forms.Button Titlebar_Close;
    }
}