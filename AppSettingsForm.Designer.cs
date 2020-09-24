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
            System.Windows.Forms.Label smtpToAddressLabel;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label imapLoginUsernameLabel;
            System.Windows.Forms.Label imapLoginPasswordLabel;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.smtpHostTextBox = new System.Windows.Forms.TextBox();
            this.smtpPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.smtpSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpTestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.smtpToAddressTextBox = new System.Windows.Forms.TextBox();
            this.smtpLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.smtpLoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.smtpFromNameTextBox = new System.Windows.Forms.TextBox();
            this.smtpFromAddressTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imapHostTextBox = new System.Windows.Forms.TextBox();
            this.imapPortTextBox = new System.Windows.Forms.NumericUpDown();
            this.imapSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.imapTestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.imapLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.imapLoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            smtpFromNameLabel = new System.Windows.Forms.Label();
            smtpFromAddressLabel = new System.Windows.Forms.Label();
            smtpLoginUsernameLabel = new System.Windows.Forms.Label();
            smtpLoginPasswordLabel = new System.Windows.Forms.Label();
            smtpHostLabel = new System.Windows.Forms.Label();
            smtpPortLabel = new System.Windows.Forms.Label();
            smtpGroupBox = new System.Windows.Forms.GroupBox();
            smtpToAddressLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            imapLoginUsernameLabel = new System.Windows.Forms.Label();
            imapLoginPasswordLabel = new System.Windows.Forms.Label();
            smtpGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imapPortTextBox)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            smtpFromAddressLabel.Location = new System.Drawing.Point(239, 0);
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
            smtpLoginPasswordLabel.Location = new System.Drawing.Point(239, 78);
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
            smtpPortLabel.Location = new System.Drawing.Point(310, 0);
            smtpPortLabel.Name = "smtpPortLabel";
            smtpPortLabel.Size = new System.Drawing.Size(29, 13);
            smtpPortLabel.TabIndex = 2;
            smtpPortLabel.Text = "Port:";
            // 
            // smtpGroupBox
            // 
            smtpGroupBox.AutoSize = true;
            smtpGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            smtpGroupBox.Controls.Add(this.tableLayoutPanel2);
            smtpGroupBox.Controls.Add(this.tableLayoutPanel1);
            smtpGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            smtpGroupBox.Location = new System.Drawing.Point(3, 3);
            smtpGroupBox.Name = "smtpGroupBox";
            smtpGroupBox.Size = new System.Drawing.Size(478, 204);
            smtpGroupBox.TabIndex = 0;
            smtpGroupBox.TabStop = false;
            smtpGroupBox.Text = "SMTP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.53587F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.46413F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.Controls.Add(this.smtpHostTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(smtpHostLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(smtpPortLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.smtpPortNumericUpDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.smtpSSLCheckBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.smtpTestButton, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // smtpHostTextBox
            // 
            this.smtpHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpHostTextBox.Location = new System.Drawing.Point(3, 16);
            this.smtpHostTextBox.MaxLength = 256;
            this.smtpHostTextBox.Name = "smtpHostTextBox";
            this.smtpHostTextBox.Size = new System.Drawing.Size(301, 20);
            this.smtpHostTextBox.TabIndex = 0;
            this.smtpHostTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpHost;
            // 
            // smtpPortNumericUpDown
            // 
            this.smtpPortNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpPortNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpPortNumericUpDown.Location = new System.Drawing.Point(310, 16);
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
            this.smtpPortNumericUpDown.Size = new System.Drawing.Size(72, 20);
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
            this.smtpSSLCheckBox.Location = new System.Drawing.Point(388, 16);
            this.smtpSSLCheckBox.Name = "smtpSSLCheckBox";
            this.smtpSSLCheckBox.Size = new System.Drawing.Size(81, 17);
            this.smtpSSLCheckBox.TabIndex = 2;
            this.smtpSSLCheckBox.Text = "SSL";
            this.smtpSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpTestButton
            // 
            this.smtpTestButton.Location = new System.Drawing.Point(388, 42);
            this.smtpTestButton.Name = "smtpTestButton";
            this.smtpTestButton.Size = new System.Drawing.Size(75, 23);
            this.smtpTestButton.TabIndex = 2;
            this.smtpTestButton.Text = "Test";
            this.smtpTestButton.UseVisualStyleBackColor = true;
            this.smtpTestButton.Click += new System.EventHandler(this.smtpTestButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.smtpToAddressTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(smtpToAddressLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.smtpLoginUsernameTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.smtpLoginPasswordTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(smtpFromNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.smtpFromNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(smtpFromAddressLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.smtpFromAddressTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(smtpLoginUsernameLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(smtpLoginPasswordLabel, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 117);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // smtpToAddressTextBox
            // 
            this.smtpToAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpToAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpToAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpToAddressTextBox.Location = new System.Drawing.Point(239, 55);
            this.smtpToAddressTextBox.MaxLength = 256;
            this.smtpToAddressTextBox.Name = "smtpToAddressTextBox";
            this.smtpToAddressTextBox.Size = new System.Drawing.Size(230, 20);
            this.smtpToAddressTextBox.TabIndex = 2;
            this.smtpToAddressTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpToAddress;
            // 
            // smtpToAddressLabel
            // 
            smtpToAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            smtpToAddressLabel.AutoSize = true;
            smtpToAddressLabel.Location = new System.Drawing.Point(239, 39);
            smtpToAddressLabel.Name = "smtpToAddressLabel";
            smtpToAddressLabel.Size = new System.Drawing.Size(96, 13);
            smtpToAddressLabel.TabIndex = 6;
            smtpToAddressLabel.Text = "To E-Mail Address:";
            // 
            // smtpLoginUsernameTextBox
            // 
            this.smtpLoginUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpLoginUsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpLoginUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpLoginUsernameTextBox.Location = new System.Drawing.Point(3, 94);
            this.smtpLoginUsernameTextBox.MaxLength = 256;
            this.smtpLoginUsernameTextBox.Name = "smtpLoginUsernameTextBox";
            this.smtpLoginUsernameTextBox.Size = new System.Drawing.Size(230, 20);
            this.smtpLoginUsernameTextBox.TabIndex = 3;
            this.smtpLoginUsernameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpLoginUsername;
            // 
            // smtpLoginPasswordTextBox
            // 
            this.smtpLoginPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpLoginPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpLoginPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpLoginPasswordTextBox.Location = new System.Drawing.Point(239, 94);
            this.smtpLoginPasswordTextBox.MaxLength = 256;
            this.smtpLoginPasswordTextBox.Name = "smtpLoginPasswordTextBox";
            this.smtpLoginPasswordTextBox.Size = new System.Drawing.Size(230, 20);
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
            this.smtpFromNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.smtpFromNameTextBox.TabIndex = 0;
            this.smtpFromNameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpFromName;
            // 
            // smtpFromAddressTextBox
            // 
            this.smtpFromAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpFromAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "smtpFromAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.smtpFromAddressTextBox.Location = new System.Drawing.Point(239, 16);
            this.smtpFromAddressTextBox.MaxLength = 256;
            this.smtpFromAddressTextBox.Name = "smtpFromAddressTextBox";
            this.smtpFromAddressTextBox.Size = new System.Drawing.Size(230, 20);
            this.smtpFromAddressTextBox.TabIndex = 1;
            this.smtpFromAddressTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.smtpFromAddress;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(this.tableLayoutPanel3);
            groupBox1.Controls.Add(this.tableLayoutPanel4);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(3, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(478, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "IMAP";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.53587F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.46413F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.Controls.Add(this.imapHostTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.imapPortTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.imapSSLCheckBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.imapTestButton, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 68);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // imapHostTextBox
            // 
            this.imapHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapHostTextBox.Location = new System.Drawing.Point(3, 16);
            this.imapHostTextBox.MaxLength = 256;
            this.imapHostTextBox.Name = "imapHostTextBox";
            this.imapHostTextBox.Size = new System.Drawing.Size(301, 20);
            this.imapHostTextBox.TabIndex = 0;
            this.imapHostTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapHost;
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
            label2.Location = new System.Drawing.Point(310, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 2;
            label2.Text = "Port:";
            // 
            // imapPortTextBox
            // 
            this.imapPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapPortTextBox.Location = new System.Drawing.Point(310, 16);
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
            this.imapPortTextBox.Size = new System.Drawing.Size(72, 20);
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
            this.imapSSLCheckBox.Location = new System.Drawing.Point(388, 16);
            this.imapSSLCheckBox.Name = "imapSSLCheckBox";
            this.imapSSLCheckBox.Size = new System.Drawing.Size(81, 17);
            this.imapSSLCheckBox.TabIndex = 2;
            this.imapSSLCheckBox.Text = "SSL";
            this.imapSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // imapTestButton
            // 
            this.imapTestButton.Location = new System.Drawing.Point(388, 42);
            this.imapTestButton.Name = "imapTestButton";
            this.imapTestButton.Size = new System.Drawing.Size(75, 23);
            this.imapTestButton.TabIndex = 2;
            this.imapTestButton.Text = "Test";
            this.imapTestButton.UseVisualStyleBackColor = true;
            this.imapTestButton.Click += new System.EventHandler(this.imapTestButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.imapLoginUsernameTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.imapLoginPasswordTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(imapLoginUsernameLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(imapLoginPasswordLabel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 39);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // imapLoginUsernameTextBox
            // 
            this.imapLoginUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapLoginUsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapLoginUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapLoginUsernameTextBox.Location = new System.Drawing.Point(3, 16);
            this.imapLoginUsernameTextBox.MaxLength = 256;
            this.imapLoginUsernameTextBox.Name = "imapLoginUsernameTextBox";
            this.imapLoginUsernameTextBox.Size = new System.Drawing.Size(230, 20);
            this.imapLoginUsernameTextBox.TabIndex = 0;
            this.imapLoginUsernameTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapLoginUsername;
            // 
            // imapLoginPasswordTextBox
            // 
            this.imapLoginPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imapLoginPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Clemakro.MailCheckClient.Properties.Settings.Default, "imapLoginPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imapLoginPasswordTextBox.Location = new System.Drawing.Point(239, 16);
            this.imapLoginPasswordTextBox.MaxLength = 256;
            this.imapLoginPasswordTextBox.Name = "imapLoginPasswordTextBox";
            this.imapLoginPasswordTextBox.Size = new System.Drawing.Size(230, 20);
            this.imapLoginPasswordTextBox.TabIndex = 1;
            this.imapLoginPasswordTextBox.Text = global::Clemakro.MailCheckClient.Properties.Settings.Default.imapLoginPassword;
            this.imapLoginPasswordTextBox.UseSystemPasswordChar = true;
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
            imapLoginPasswordLabel.Location = new System.Drawing.Point(239, 0);
            imapLoginPasswordLabel.Name = "imapLoginPasswordLabel";
            imapLoginPasswordLabel.Size = new System.Drawing.Size(85, 13);
            imapLoginPasswordLabel.TabIndex = 5;
            imapLoginPasswordLabel.Text = "Login Password:";
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 529);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(478, 29);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(319, 3);
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
            this.cancelButton.Location = new System.Drawing.Point(400, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AppSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(groupBox1);
            this.Controls.Add(smtpGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettingsForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            smtpGroupBox.ResumeLayout(false);
            smtpGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imapPortTextBox)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox smtpFromNameTextBox;
        private System.Windows.Forms.TextBox smtpFromAddressTextBox;
        private System.Windows.Forms.TextBox smtpLoginUsernameTextBox;
        private System.Windows.Forms.TextBox smtpLoginPasswordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox smtpHostTextBox;
        private System.Windows.Forms.NumericUpDown smtpPortNumericUpDown;
        private System.Windows.Forms.CheckBox smtpSSLCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox imapHostTextBox;
        private System.Windows.Forms.NumericUpDown imapPortTextBox;
        private System.Windows.Forms.CheckBox imapSSLCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox imapLoginUsernameTextBox;
        private System.Windows.Forms.TextBox imapLoginPasswordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox smtpToAddressTextBox;
        private System.Windows.Forms.Button smtpTestButton;
        private System.Windows.Forms.Button imapTestButton;
    }
}