namespace Clemakro.MailCheckClient
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            this.loggingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.mailListView = new System.Windows.Forms.ListView();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.mailListView);
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
            // fileRunToolStripMenuItem
            // 
            this.fileRunToolStripMenuItem.Name = "fileRunToolStripMenuItem";
            this.fileRunToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fileRunToolStripMenuItem.Text = "&Run";
            this.fileRunToolStripMenuItem.Click += new System.EventHandler(this.fileRunToolStripMenuItem_Click);
            // 
            // fileSettingsToolStripMenuItem
            // 
            this.fileSettingsToolStripMenuItem.Name = "fileSettingsToolStripMenuItem";
            this.fileSettingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fileSettingsToolStripMenuItem.Text = "&Settings...";
            this.fileSettingsToolStripMenuItem.Click += new System.EventHandler(this.fileSettingsToolStripMenuItem_Click);
            // 
            // fileExitToolStripMenuItem
            // 
            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
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
            // sendInfoToolStripStatusLabel
            // 
            this.sendInfoToolStripStatusLabel.Name = "sendInfoToolStripStatusLabel";
            this.sendInfoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // sendTimer
            // 
            this.sendTimer.Tick += new System.EventHandler(this.sendTimer_Tick);
            // 
            // mailListView
            // 
            this.mailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5});
            this.mailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailListView.FullRowSelect = true;
            this.mailListView.GridLines = true;
            this.mailListView.HideSelection = false;
            this.mailListView.Location = new System.Drawing.Point(0, 0);
            this.mailListView.Name = "mailListView";
            this.mailListView.Size = new System.Drawing.Size(784, 225);
            this.mailListView.TabIndex = 0;
            this.mailListView.UseCompatibleStateImageBehavior = false;
            this.mailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Status";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Timestamp";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ticks";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "To-Address";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Timeout";
            columnHeader5.Width = 160;
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
            splitContainer1.Panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListView mailListView;
    }
}

