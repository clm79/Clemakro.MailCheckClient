namespace Clemakro.MailCheckClient
{
    partial class AppSettingsForm
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
            System.Windows.Forms.Label smtpFromNameLabel;
            System.Windows.Forms.Label smtpFromAddressLabel;
            System.Windows.Forms.Label smtpLoginUsernameLabel;
            System.Windows.Forms.Label smtpLoginPasswordLabel;
            System.Windows.Forms.Label smtpHostLabel;
            System.Windows.Forms.Label smtpPortLabel;
            System.Windows.Forms.GroupBox smtpGroupBox;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label smtpToAddressLabel;
            System.Windows.Forms.GroupBox imapGroupBox;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
            System.Windows.Forms.Label imapLoginUsernameLabel;
            System.Windows.Forms.Label imapLoginPasswordLabel;
            System.Windows.Forms.GroupBox loggingGroupBox;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.smtpTestButton = new System.Windows.Forms.Button();
            this.imapTestButton = new System.Windows.Forms.Button();
            this.mailLoggingFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.receiveTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.imapHostTextBox = new System.Windows.Forms.TextBox();
            this.imapPortTextBox = new System.Windows.Forms.NumericUpDown();
            this.imapSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.imapNetworkTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.imapLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.imapLoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.smtpHostTextBox = new System.Windows.Forms.TextBox();
            this.smtpPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.smtpSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpNetworkTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.smtpToAddressTextBox = new System.Windows.Forms.TextBox();
            this.smtpLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.smtpLoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.smtpFromNameTextBox = new System.Windows.Forms.TextBox();
            this.smtpFromAddressTextBox = new System.Windows.Forms.TextBox();
            this.mailLoggingFileTextBox = new System.Windows.Forms.TextBox();
            this.mailLoggingEnabledCheckBox = new System.Windows.Forms.CheckBox();
            smtpFromNameLabel = new System.Windows.Forms.Label();
            smtpFromAddressLabel = new System.Windows.Forms.Label();
            smtpLoginUsernameLabel = new System.Windows.Forms.Label();
            smtpLoginPasswordLabel = new System.Windows.Forms.Label();
            smtpHostLabel = new System.Windows.Forms.Label();
            smtpPortLabel = new System.Windows.Forms.Label();
            smtpGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            smtpToAddressLabel = new System.Windows.Forms.Label();
            imapGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            imapLoginUsernameLabel = new System.Windows.Forms.Label();
            imapLoginPasswordLabel = new System.Windows.Forms.Label();
            loggingGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            smtpGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            imapGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            loggingGroupBox.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTimeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imapPortTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imapNetworkTimeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNetworkTimeoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // smtpFromNameLabel
            // 
            smtpFromNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpFromNameLabel.AutoSize = true;
            smtpFromNameLabel.Location = new System.Drawing.Point(3, 0);
            smtpFromNameLabel.Name = "smtpFromNameLabel";
            smtpFromNameLabel.Size = new System.Drawing.Size(64, 13);
            smtpFromNameLabel.TabIndex = 0;
            smtpFromNameLabel.Text = "From Name:";
            // 
            // smtpFromAddressLabel
            // 
            smtpFromAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpFromAddressLabel.AutoSize = true;
            smtpFromAddressLabel.Location = new System.Drawing.Point(242, 0);
            smtpFromAddressLabel.Name = "smtpFromAddressLabel";
            smtpFromAddressLabel.Size = new System.Drawing.Size(106, 13);
            smtpFromAddressLabel.TabIndex = 2;
            smtpFromAddressLabel.Text = "From E-Mail Address:";
            // 
            // smtpLoginUsernameLabel
            // 
            smtpLoginUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpLoginUsernameLabel.AutoSize = true;
            smtpLoginUsernameLabel.Location = new System.Drawing.Point(3, 78);
            smtpLoginUsernameLabel.Name = "smtpLoginUsernameLabel";
            smtpLoginUsernameLabel.Size = new System.Drawing.Size(87, 13);
            smtpLoginUsernameLabel.TabIndex = 4;
            smtpLoginUsernameLabel.Text = "Login Username:";
            // 
            // smtpLoginPasswordLabel
            // 
            smtpLoginPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpLoginPasswordLabel.AutoSize = true;
            smtpLoginPasswordLabel.Location = new System.Drawing.Point(242, 78);
            smtpLoginPasswordLabel.Name = "smtpLoginPasswordLabel";
            smtpLoginPasswordLabel.Size = new System.Drawing.Size(85, 13);
            smtpLoginPasswordLabel.TabIndex = 5;
            smtpLoginPasswordLabel.Text = "Login Password:";
            // 
            // smtpHostLabel
            // 
            smtpHostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpHostLabel.AutoSize = true;
            smtpHostLabel.Location = new System.Drawing.Point(3, 0);
            smtpHostLabel.Name = "smtpHostLabel";
            smtpHostLabel.Size = new System.Drawing.Size(32, 13);
            smtpHostLabel.TabIndex = 1;
            smtpHostLabel.Text = "Host:";
            // 
            // smtpPortLabel
            // 
            smtpPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpPortLabel.AutoSize = true;
            smtpPortLabel.Location = new System.Drawing.Point(162, 0);
            smtpPortLabel.Name = "smtpPortLabel";
            smtpPortLabel.Size = new System.Drawing.Size(29, 13);
            smtpPortLabel.TabIndex = 2;
            smtpPortLabel.Text = "Port:";
            // 
            // smtpGroupBox
            // 
            smtpGroupBox.AutoSize = true;
            smtpGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            smtpGroupBox.Controls.Add(tableLayoutPanel2);
            smtpGroupBox.Controls.Add(tableLayoutPanel1);
            smtpGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            smtpGroupBox.Location = new System.Drawing.Point(0, 48);
            smtpGroupBox.Name = "smtpGroupBox";
            smtpGroupBox.Size = new System.Drawing.Size(484, 204);
            smtpGroupBox.TabIndex = 0;
            smtpGroupBox.TabStop = false;
            smtpGroupBox.Text = "SMTP";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.27027F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            tableLayoutPanel2.Controls.Add(this.smtpHostTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(smtpHostLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(smtpPortLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(this.smtpPortNumericUpDown, 1, 1);
            tableLayoutPanel2.Controls.Add(this.smtpSSLCheckBox, 2, 1);
            tableLayoutPanel2.Controls.Add(this.smtpTestButton, 3, 2);
            tableLayoutPanel2.Controls.Add(label3, 3, 0);
            tableLayoutPanel2.Controls.Add(this.smtpNetworkTimeoutNumericUpDown, 3, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 133);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(478, 68);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // smtpTestButton
            // 
            this.smtpTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpTestButton.Location = new System.Drawing.Point(400, 42);
            this.smtpTestButton.Name = "smtpTestButton";
            this.smtpTestButton.Size = new System.Drawing.Size(75, 23);
            this.smtpTestButton.TabIndex = 4;
            this.smtpTestButton.Text = "Test";
            this.smtpTestButton.UseVisualStyleBackColor = true;
            this.smtpTestButton.Click += new System.EventHandler(this.smtpTestButton_Click);
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(293, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 13);
            label3.TabIndex = 3;
            label3.Text = "Network Timeout (seconds):";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(this.smtpToAddressTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(smtpToAddressLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(this.smtpLoginUsernameTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(this.smtpLoginPasswordTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(smtpFromNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(this.smtpFromNameTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(smtpFromAddressLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(this.smtpFromAddressTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(smtpLoginUsernameLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(smtpLoginPasswordLabel, 1, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(478, 117);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // smtpToAddressLabel
            // 
            smtpToAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpToAddressLabel.AutoSize = true;
            smtpToAddressLabel.Location = new System.Drawing.Point(242, 39);
            smtpToAddressLabel.Name = "smtpToAddressLabel";
            smtpToAddressLabel.Size = new System.Drawing.Size(96, 13);
            smtpToAddressLabel.TabIndex = 6;
            smtpToAddressLabel.Text = "To E-Mail Address:";
            // 
            // imapGroupBox
            // 
            imapGroupBox.AutoSize = true;
            imapGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            imapGroupBox.Controls.Add(tableLayoutPanel3);
            imapGroupBox.Controls.Add(tableLayoutPanel4);
            imapGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            imapGroupBox.Location = new System.Drawing.Point(0, 252);
            imapGroupBox.Name = "imapGroupBox";
            imapGroupBox.Size = new System.Drawing.Size(484, 126);
            imapGroupBox.TabIndex = 1;
            imapGroupBox.TabStop = false;
            imapGroupBox.Text = "IMAP";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            tableLayoutPanel3.Controls.Add(this.imapHostTextBox, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(this.imapPortTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(this.imapSSLCheckBox, 2, 1);
            tableLayoutPanel3.Controls.Add(this.imapTestButton, 3, 2);
            tableLayoutPanel3.Controls.Add(label4, 3, 0);
            tableLayoutPanel3.Controls.Add(this.imapNetworkTimeoutNumericUpDown, 3, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 55);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.Size = new System.Drawing.Size(478, 68);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 13);
            label1.TabIndex = 1;
            label1.Text = "Host:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(162, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 2;
            label2.Text = "Port:";
            // 
            // imapTestButton
            // 
            this.imapTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imapTestButton.Location = new System.Drawing.Point(400, 42);
            this.imapTestButton.Name = "imapTestButton";
            this.imapTestButton.Size = new System.Drawing.Size(75, 23);
            this.imapTestButton.TabIndex = 4;
            this.imapTestButton.Text = "Test";
            this.imapTestButton.UseVisualStyleBackColor = true;
            this.imapTestButton.Click += new System.EventHandler(this.imapTestButton_Click);
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(291, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 13);
            label4.TabIndex = 4;
            label4.Text = "Network Timeout (seconds):";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(this.imapLoginUsernameTextBox, 0, 1);
            tableLayoutPanel4.Controls.Add(this.imapLoginPasswordTextBox, 0, 1);
            tableLayoutPanel4.Controls.Add(imapLoginUsernameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(imapLoginPasswordLabel, 1, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(478, 39);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // imapLoginUsernameLabel
            // 
            imapLoginUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            imapLoginUsernameLabel.AutoSize = true;
            imapLoginUsernameLabel.Location = new System.Drawing.Point(3, 0);
            imapLoginUsernameLabel.Name = "imapLoginUsernameLabel";
            imapLoginUsernameLabel.Size = new System.Drawing.Size(87, 13);
            imapLoginUsernameLabel.TabIndex = 4;
            imapLoginUsernameLabel.Text = "Login Username:";
            // 
            // imapLoginPasswordLabel
            // 
            imapLoginPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            imapLoginPasswordLabel.AutoSize = true;
            imapLoginPasswordLabel.Location = new System.Drawing.Point(242, 0);
            imapLoginPasswordLabel.Name = "imapLoginPasswordLabel";
            imapLoginPasswordLabel.Size = new System.Drawing.Size(85, 13);
            imapLoginPasswordLabel.TabIndex = 5;
            imapLoginPasswordLabel.Text = "Login Password:";
            // 
            // loggingGroupBox
            // 
            loggingGroupBox.AutoSize = true;
            loggingGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loggingGroupBox.Controls.Add(tableLayoutPanel6);
            loggingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            loggingGroupBox.Location = new System.Drawing.Point(0, 0);
            loggingGroupBox.Name = "loggingGroupBox";
            loggingGroupBox.Size = new System.Drawing.Size(484, 48);
            loggingGroupBox.TabIndex = 2;
            loggingGroupBox.TabStop = false;
            loggingGroupBox.Text = "Mail File-Logging";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.23529F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.76471F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel6.Controls.Add(this.mailLoggingFileTextBox, 1, 0);
            tableLayoutPanel6.Controls.Add(this.mailLoggingEnabledCheckBox, 0, 0);
            tableLayoutPanel6.Controls.Add(this.mailLoggingFileButton, 2, 0);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(478, 29);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // mailLoggingFileButton
            // 
            this.mailLoggingFileButton.Location = new System.Drawing.Point(430, 3);
            this.mailLoggingFileButton.Name = "mailLoggingFileButton";
            this.mailLoggingFileButton.Size = new System.Drawing.Size(41, 23);
            this.mailLoggingFileButton.TabIndex = 2;
            this.mailLoggingFileButton.Text = "...";
            this.mailLoggingFileButton.UseVisualStyleBackColor = true;
            this.mailLoggingFileButton.Click += new System.EventHandler(this.mailLoggingFileButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 532);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(484, 29);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(325, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(406, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel7);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 378);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(484, 71);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Job Setup";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(this.sendIntervalNumericUpDown, 0, 1);
            tableLayoutPanel7.Controls.Add(this.receiveTimeoutNumericUpDown, 0, 1);
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(label6, 1, 0);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new System.Drawing.Size(478, 52);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 13);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(122, 13);
            label5.TabIndex = 5;
            label5.Text = "Send Interval (seconds):";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(242, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(140, 13);
            label6.TabIndex = 7;
            label6.Text = "Receive Timeout (seconds):";
            // 
            // sendIntervalNumericUpDown
            // 
            this.sendIntervalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "sendInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sendIntervalNumericUpDown.Location = new System.Drawing.Point(3, 29);
            this.sendIntervalNumericUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.sendIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sendIntervalNumericUpDown.Name = "sendIntervalNumericUpDown";
            this.sendIntervalNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.sendIntervalNumericUpDown.TabIndex = 0;
            this.sendIntervalNumericUpDown.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.sendInterval;
            // 
            // receiveTimeoutNumericUpDown
            // 
            this.receiveTimeoutNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "receiveTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.receiveTimeoutNumericUpDown.Location = new System.Drawing.Point(242, 29);
            this.receiveTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.receiveTimeoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.receiveTimeoutNumericUpDown.Name = "receiveTimeoutNumericUpDown";
            this.receiveTimeoutNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.receiveTimeoutNumericUpDown.TabIndex = 1;
            this.receiveTimeoutNumericUpDown.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.receiveTimeout;
            // 
            // imapHostTextBox
            // 
            this.imapHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapHostTextBox.Location = new System.Drawing.Point(3, 16);
            this.imapHostTextBox.MaxLength = 256;
            this.imapHostTextBox.Name = "imapHostTextBox";
            this.imapHostTextBox.Size = new System.Drawing.Size(153, 20);
            this.imapHostTextBox.TabIndex = 0;
            this.imapHostTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapHost;
            // 
            // imapPortTextBox
            // 
            this.imapPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapPortTextBox.Location = new System.Drawing.Point(162, 16);
            this.imapPortTextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.imapPortTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imapPortTextBox.Name = "imapPortTextBox";
            this.imapPortTextBox.Size = new System.Drawing.Size(59, 20);
            this.imapPortTextBox.TabIndex = 1;
            this.imapPortTextBox.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapPort;
            // 
            // imapSSLCheckBox
            // 
            this.imapSSLCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapSSLCheckBox.AutoSize = true;
            this.imapSSLCheckBox.Checked = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapSSL;
            this.imapSSLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imapSSLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapSSLCheckBox.Location = new System.Drawing.Point(227, 16);
            this.imapSSLCheckBox.Name = "imapSSLCheckBox";
            this.imapSSLCheckBox.Size = new System.Drawing.Size(58, 17);
            this.imapSSLCheckBox.TabIndex = 2;
            this.imapSSLCheckBox.Text = "SSL";
            this.imapSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // imapNetworkTimeoutNumericUpDown
            // 
            this.imapNetworkTimeoutNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapNetworkTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapNetworkTimeoutNumericUpDown.Location = new System.Drawing.Point(291, 16);
            this.imapNetworkTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.imapNetworkTimeoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imapNetworkTimeoutNumericUpDown.Name = "imapNetworkTimeoutNumericUpDown";
            this.imapNetworkTimeoutNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.imapNetworkTimeoutNumericUpDown.TabIndex = 3;
            this.imapNetworkTimeoutNumericUpDown.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapNetworkTimeout;
            // 
            // imapLoginUsernameTextBox
            // 
            this.imapLoginUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapLoginUsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapLoginUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapLoginUsernameTextBox.Location = new System.Drawing.Point(3, 16);
            this.imapLoginUsernameTextBox.MaxLength = 256;
            this.imapLoginUsernameTextBox.Name = "imapLoginUsernameTextBox";
            this.imapLoginUsernameTextBox.Size = new System.Drawing.Size(233, 20);
            this.imapLoginUsernameTextBox.TabIndex = 0;
            this.imapLoginUsernameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapLoginUsername;
            // 
            // imapLoginPasswordTextBox
            // 
            this.imapLoginPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapLoginPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapLoginPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapLoginPasswordTextBox.Location = new System.Drawing.Point(242, 16);
            this.imapLoginPasswordTextBox.MaxLength = 256;
            this.imapLoginPasswordTextBox.Name = "imapLoginPasswordTextBox";
            this.imapLoginPasswordTextBox.Size = new System.Drawing.Size(233, 20);
            this.imapLoginPasswordTextBox.TabIndex = 1;
            this.imapLoginPasswordTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapLoginPassword;
            this.imapLoginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // smtpHostTextBox
            // 
            this.smtpHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpHostTextBox.Location = new System.Drawing.Point(3, 16);
            this.smtpHostTextBox.MaxLength = 256;
            this.smtpHostTextBox.Name = "smtpHostTextBox";
            this.smtpHostTextBox.Size = new System.Drawing.Size(153, 20);
            this.smtpHostTextBox.TabIndex = 0;
            this.smtpHostTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpHost;
            // 
            // smtpPortNumericUpDown
            // 
            this.smtpPortNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpPortNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpPortNumericUpDown.Location = new System.Drawing.Point(162, 16);
            this.smtpPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.smtpPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smtpPortNumericUpDown.Name = "smtpPortNumericUpDown";
            this.smtpPortNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.smtpPortNumericUpDown.TabIndex = 1;
            this.smtpPortNumericUpDown.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpPort;
            // 
            // smtpSSLCheckBox
            // 
            this.smtpSSLCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpSSLCheckBox.AutoSize = true;
            this.smtpSSLCheckBox.Checked = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpSSL;
            this.smtpSSLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smtpSSLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpSSLCheckBox.Location = new System.Drawing.Point(229, 16);
            this.smtpSSLCheckBox.Name = "smtpSSLCheckBox";
            this.smtpSSLCheckBox.Size = new System.Drawing.Size(58, 17);
            this.smtpSSLCheckBox.TabIndex = 2;
            this.smtpSSLCheckBox.Text = "SSL";
            this.smtpSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpNetworkTimeoutNumericUpDown
            // 
            this.smtpNetworkTimeoutNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpNetworkTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpNetworkTimeoutNumericUpDown.Location = new System.Drawing.Point(293, 16);
            this.smtpNetworkTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.smtpNetworkTimeoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smtpNetworkTimeoutNumericUpDown.Name = "smtpNetworkTimeoutNumericUpDown";
            this.smtpNetworkTimeoutNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.smtpNetworkTimeoutNumericUpDown.TabIndex = 3;
            this.smtpNetworkTimeoutNumericUpDown.Value = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpNetworkTimeout;
            // 
            // smtpToAddressTextBox
            // 
            this.smtpToAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpToAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpToAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpToAddressTextBox.Location = new System.Drawing.Point(242, 55);
            this.smtpToAddressTextBox.MaxLength = 256;
            this.smtpToAddressTextBox.Name = "smtpToAddressTextBox";
            this.smtpToAddressTextBox.Size = new System.Drawing.Size(233, 20);
            this.smtpToAddressTextBox.TabIndex = 2;
            this.smtpToAddressTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpToAddress;
            // 
            // smtpLoginUsernameTextBox
            // 
            this.smtpLoginUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpLoginUsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpLoginUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpLoginUsernameTextBox.Location = new System.Drawing.Point(3, 94);
            this.smtpLoginUsernameTextBox.MaxLength = 256;
            this.smtpLoginUsernameTextBox.Name = "smtpLoginUsernameTextBox";
            this.smtpLoginUsernameTextBox.Size = new System.Drawing.Size(233, 20);
            this.smtpLoginUsernameTextBox.TabIndex = 3;
            this.smtpLoginUsernameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpLoginUsername;
            // 
            // smtpLoginPasswordTextBox
            // 
            this.smtpLoginPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpLoginPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpLoginPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpLoginPasswordTextBox.Location = new System.Drawing.Point(242, 94);
            this.smtpLoginPasswordTextBox.MaxLength = 256;
            this.smtpLoginPasswordTextBox.Name = "smtpLoginPasswordTextBox";
            this.smtpLoginPasswordTextBox.Size = new System.Drawing.Size(233, 20);
            this.smtpLoginPasswordTextBox.TabIndex = 4;
            this.smtpLoginPasswordTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpLoginPassword;
            this.smtpLoginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // smtpFromNameTextBox
            // 
            this.smtpFromNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpFromNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpFromName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpFromNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.smtpFromNameTextBox.MaxLength = 256;
            this.smtpFromNameTextBox.Name = "smtpFromNameTextBox";
            this.smtpFromNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.smtpFromNameTextBox.TabIndex = 0;
            this.smtpFromNameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpFromName;
            // 
            // smtpFromAddressTextBox
            // 
            this.smtpFromAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpFromAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpFromAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpFromAddressTextBox.Location = new System.Drawing.Point(242, 16);
            this.smtpFromAddressTextBox.MaxLength = 256;
            this.smtpFromAddressTextBox.Name = "smtpFromAddressTextBox";
            this.smtpFromAddressTextBox.Size = new System.Drawing.Size(233, 20);
            this.smtpFromAddressTextBox.TabIndex = 1;
            this.smtpFromAddressTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpFromAddress;
            // 
            // mailLoggingFileTextBox
            // 
            this.mailLoggingFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailLoggingFileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "mailLoggingFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailLoggingFileTextBox.Location = new System.Drawing.Point(72, 3);
            this.mailLoggingFileTextBox.MaxLength = 256;
            this.mailLoggingFileTextBox.Name = "mailLoggingFileTextBox";
            this.mailLoggingFileTextBox.Size = new System.Drawing.Size(352, 20);
            this.mailLoggingFileTextBox.TabIndex = 1;
            this.mailLoggingFileTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.mailLoggingFile;
            // 
            // mailLoggingEnabledCheckBox
            // 
            this.mailLoggingEnabledCheckBox.AutoSize = true;
            this.mailLoggingEnabledCheckBox.Checked = global::Clemakro.MailCheckClient.Properties.Settings.Default.mailLoggingEnabled;
            this.mailLoggingEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Clemakro.MailCheckClient.Properties.Settings.Default, "mailLoggingEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailLoggingEnabledCheckBox.Location = new System.Drawing.Point(3, 3);
            this.mailLoggingEnabledCheckBox.Name = "mailLoggingEnabledCheckBox";
            this.mailLoggingEnabledCheckBox.Size = new System.Drawing.Size(59, 17);
            this.mailLoggingEnabledCheckBox.TabIndex = 0;
            this.mailLoggingEnabledCheckBox.Text = "Enable";
            this.mailLoggingEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // AppSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(imapGroupBox);
            this.Controls.Add(smtpGroupBox);
            this.Controls.Add(loggingGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            smtpGroupBox.ResumeLayout(false);
            smtpGroupBox.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            imapGroupBox.ResumeLayout(false);
            imapGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            loggingGroupBox.ResumeLayout(false);
            loggingGroupBox.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTimeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imapPortTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imapNetworkTimeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNetworkTimeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox smtpFromNameTextBox;
        private System.Windows.Forms.TextBox smtpFromAddressTextBox;
        private System.Windows.Forms.TextBox smtpLoginUsernameTextBox;
        private System.Windows.Forms.TextBox smtpLoginPasswordTextBox;
        private System.Windows.Forms.TextBox smtpHostTextBox;
        private System.Windows.Forms.NumericUpDown smtpPortNumericUpDown;
        private System.Windows.Forms.CheckBox smtpSSLCheckBox;
        private System.Windows.Forms.TextBox imapHostTextBox;
        private System.Windows.Forms.NumericUpDown imapPortTextBox;
        private System.Windows.Forms.CheckBox imapSSLCheckBox;
        private System.Windows.Forms.TextBox imapLoginUsernameTextBox;
        private System.Windows.Forms.TextBox imapLoginPasswordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox smtpToAddressTextBox;
        private System.Windows.Forms.Button smtpTestButton;
        private System.Windows.Forms.Button imapTestButton;
        private System.Windows.Forms.NumericUpDown smtpNetworkTimeoutNumericUpDown;
        private System.Windows.Forms.NumericUpDown imapNetworkTimeoutNumericUpDown;
        private System.Windows.Forms.TextBox mailLoggingFileTextBox;
        private System.Windows.Forms.CheckBox mailLoggingEnabledCheckBox;
        private System.Windows.Forms.Button mailLoggingFileButton;
        private System.Windows.Forms.NumericUpDown sendIntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown receiveTimeoutNumericUpDown;
    }
}