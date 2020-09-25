﻿namespace Clemakro.MailCheckClient
{
    partial class AppMainForm
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStrip toolStrip1;
            System.Windows.Forms.StatusStrip statusStrip1;
            this.loggingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.fileRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 49);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.loggingRichTextBox);
            splitContainer1.Size = new System.Drawing.Size(784, 490);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 3;
            // 
            // loggingRichTextBox
            // 
            this.loggingRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggingRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.loggingRichTextBox.Name = "loggingRichTextBox";
            this.loggingRichTextBox.Size = new System.Drawing.Size(784, 261);
            this.loggingRichTextBox.TabIndex = 0;
            this.loggingRichTextBox.Text = "";
            this.loggingRichTextBox.WordWrap = false;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileRunToolStripMenuItem,
            this.fileSettingsToolStripMenuItem,
            this.fileExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // fileSettingsToolStripMenuItem
            // 
            this.fileSettingsToolStripMenuItem.Name = "fileSettingsToolStripMenuItem";
            this.fileSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileSettingsToolStripMenuItem.Text = "&Settings...";
            this.fileSettingsToolStripMenuItem.Click += new System.EventHandler(this.fileSettingsToolStripMenuItem_Click);
            // 
            // fileExitToolStripMenuItem
            // 
            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileExitToolStripMenuItem.Text = "E&xit";
            this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.fileExitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(784, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobStateToolStripStatusLabel,
            this.sendInfoToolStripStatusLabel});
            statusStrip1.Location = new System.Drawing.Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // jobStateToolStripStatusLabel
            // 
            this.jobStateToolStripStatusLabel.Name = "jobStateToolStripStatusLabel";
            this.jobStateToolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.jobStateToolStripStatusLabel.Text = "Stopped";
            // 
            // sendTimer
            // 
            this.sendTimer.Tick += new System.EventHandler(this.sendTimer_Tick);
            // 
            // fileRunToolStripMenuItem
            // 
            this.fileRunToolStripMenuItem.Name = "fileRunToolStripMenuItem";
            this.fileRunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileRunToolStripMenuItem.Text = "&Run";
            this.fileRunToolStripMenuItem.Click += new System.EventHandler(this.fileRunToolStripMenuItem_Click);
            // 
            // sendInfoToolStripStatusLabel
            // 
            this.sendInfoToolStripStatusLabel.Name = "sendInfoToolStripStatusLabel";
            this.sendInfoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(splitContainer1);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(toolStrip1);
            this.Controls.Add(mainMenuStrip);
            this.MainMenuStrip = mainMenuStrip;
            this.Name = "AppMainForm";
            this.Text = "Mail Check Client";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSettingsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox loggingRichTextBox;
        private System.Windows.Forms.ToolStripStatusLabel jobStateToolStripStatusLabel;
        private System.Windows.Forms.Timer sendTimer;
        private System.Windows.Forms.ToolStripMenuItem fileRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sendInfoToolStripStatusLabel;
    }
}

