﻿using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using MailKit.Net.Imap;
using log4net;
using System.IO;
using MailKit;

namespace Clemakro.MailCheckClient
{
    public partial class AppSettingsForm : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AppSettingsForm()
        {
            InitializeComponent();
        }

        private void smtpTestButton_Click(object sender, EventArgs e)
        {
            logger.Info("Testing SMTP connection...");

            using (SmtpClient client = smtpLoggingEnabledCheckBox.Checked && smtpLoggingFileTextBox.Text.Length>0 ? new SmtpClient(new ProtocolLogger(smtpLoggingFileTextBox.Text)) : new SmtpClient())
            {
                client.Timeout = Decimal.ToInt32(smtpNetworkTimeoutNumericUpDown.Value) * 1000;
                client.ServerCertificateValidationCallback = NoSslCertificateValidationCallback;

                try
                {
                    if (smtpSSLCheckBox.Checked)
                    {
                        client.Connect(smtpHostTextBox.Text, Decimal.ToInt32(smtpPortNumericUpDown.Value), MailKit.Security.SecureSocketOptions.Auto);
                    }
                    else
                    {
                        client.Connect(smtpHostTextBox.Text, Decimal.ToInt32(smtpPortNumericUpDown.Value), false);
                    }

                    if (smtpLoginUsernameTextBox.Text.Length > 0)
                    {
                        client.Authenticate(smtpLoginUsernameTextBox.Text, smtpLoginPasswordTextBox.Text);
                    }

                    logger.Info("SMTP Test OK");
                    MessageBox.Show(this, "SMTP Test OK", "SMTP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Error("SMTP Test failed", ex);
                    MessageBox.Show(this, "SMTP Test failed: " + ex.Message, "SMTP Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }

        private void imapTestButton_Click(object sender, EventArgs e)
        {
            logger.Info("Testing IMAP connection...");

            using (ImapClient client = smtpLoggingEnabledCheckBox.Checked && smtpLoggingFileTextBox.Text.Length > 0 ? new ImapClient(new ProtocolLogger(smtpLoggingFileTextBox.Text)) : new ImapClient())
            {
                client.Timeout = Decimal.ToInt32(smtpNetworkTimeoutNumericUpDown.Value) * 1000;
                client.ServerCertificateValidationCallback = NoSslCertificateValidationCallback;

                try
                {
                    if (imapSSLCheckBox.Checked)
                    {
                        client.Connect(imapHostTextBox.Text, Decimal.ToInt32(imapPortTextBox.Value), MailKit.Security.SecureSocketOptions.Auto);
                    }
                    else
                    {
                        client.Connect(imapHostTextBox.Text, Decimal.ToInt32(imapPortTextBox.Value), false);
                    }

                    if (imapLoginPasswordTextBox.Text.Length > 0)
                    {
                        client.Authenticate(imapLoginUsernameTextBox.Text, imapLoginPasswordTextBox.Text);
                    }

                    MailKit.IMailFolder inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    logger.Info("IMAP Test OK, inbox message count: " + inbox.Count);
                    MessageBox.Show(this, "IMAP Test OK, inbox message count: " + inbox.Count, "IMAP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Error("IMAP Test failed", ex);
                    MessageBox.Show(this, "IMAP Test failed: " + ex.Message, "IMAP Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }


        private static bool NoSslCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void smtpLoggingFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "SMTP Logging";
                saveFileDialog.FileName = smtpLoggingFileTextBox.Text;
                DialogResult rs = saveFileDialog.ShowDialog(this);
                if(rs==DialogResult.OK)
                {
                    smtpLoggingFileTextBox.Text = saveFileDialog.FileName;
                }
            }
            
        }

        private void imapLoggingFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "IMAP Logging";
                saveFileDialog.FileName = imapLoggingFileTextBox.Text;
                DialogResult rs = saveFileDialog.ShowDialog(this);
                if (rs == DialogResult.OK)
                {
                    imapLoggingFileTextBox.Text = saveFileDialog.FileName;
                }
            }

        }
    }
}
