using log4net;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clemakro.MailCheckClient
{
    public partial class AppMainForm : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private List<MailItem> mailItems = new List<MailItem>();

        public AppMainForm()
        {
            InitializeComponent();

            var appender = LogManager.GetRepository().GetAppenders().Where(a => a.Name == "RichTextBoxAppender").FirstOrDefault();
            if (appender != null)
            {
                ((RichTextBoxAppender)appender).RichTextBox = loggingRichTextBox;
            }
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Debug("Open settings dialog...");
            using (AppSettingsForm appSettingsForm = new AppSettingsForm())
            {
                if (appSettingsForm.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.Save();
                    logger.Debug("Settings saved.");
                }
                else
                {
                    logger.Debug("Settings cancelled.");
                }
            }
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {
            logger.Info("Loaded, Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        private void fileRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Debug("Run...");

            if (fileRunToolStripMenuItem.Checked)
            {
                sendTimer.Stop();

                lock(mailItems)
                {
                    foreach(MailItem mailItem in mailItems)
                    {
                        if(mailItem.Status == MailItem.StatusType.Sent)
                        {
                            mailItem.Status = MailItem.StatusType.Cancelled;
                            updateMailListViewItem(mailItem);
                        }
                    }
                }

                logger.Debug("Job state: Stopped.");
                fileRunToolStripMenuItem.Checked = false;
                fileSettingsToolStripMenuItem.Enabled = true;
                jobStateToolStripStatusLabel.Text = "Stopped";
            }
            else
            {
                mailListView.Items.Clear();
                lock(mailItems)
                {
                    mailItems.Clear();
                }

                fileSettingsToolStripMenuItem.Enabled = false;

                sendTimer.Interval = Decimal.ToInt32(Properties.Settings.Default.sendInterval) * 1000;
                sendTimer.Start();
                logger.Debug("Job state: Running.");
                fileRunToolStripMenuItem.Checked = true;
                jobStateToolStripStatusLabel.Text = "Running";

                sendTimer_Tick(null, null);
            }

        }

        private void insertMailListViewItem(MailItem mailItem)
        {
            ListViewItem listViewItem = new ListViewItem(String.Format("{0}", mailItem.Status));
            listViewItem.Tag = mailItem;
            mailItem.viewItem = listViewItem;

            switch(mailItem.Status)
            {
                case MailItem.StatusType.Cancelled:
                    listViewItem.ForeColor = System.Drawing.Color.Gray;
                    break;
                case MailItem.StatusType.Error:
                    listViewItem.ForeColor = System.Drawing.Color.Red;
                    break;
                case MailItem.StatusType.Received:
                    listViewItem.ForeColor = System.Drawing.Color.Green;
                    break;
                case MailItem.StatusType.Sent:
                    listViewItem.ForeColor = System.Drawing.Color.Black;
                    break;
                case MailItem.StatusType.TimedOut:
                    listViewItem.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    listViewItem.ForeColor = System.Drawing.Color.Black;
                    break;
            }

            listViewItem.SubItems.Add(String.Format("{0}", mailItem.Timestamp));
            listViewItem.SubItems.Add(String.Format("{0}", mailItem.Ticks));
            listViewItem.SubItems.Add(String.Format("{0}", mailItem.ToAddress));
            listViewItem.SubItems.Add(String.Format("{0}", mailItem.TimeoutTimestamp));
            mailListView.Items.Insert(0, listViewItem);
        }

        private void updateMailListViewItem(MailItem mailItem)
        {
            mailItem.viewItem.Text = String.Format("{0}", mailItem.Status);
            switch (mailItem.Status)
            {
                case MailItem.StatusType.Cancelled:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Gray;
                    break;
                case MailItem.StatusType.Error:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Red;
                    break;
                case MailItem.StatusType.Received:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Green;
                    break;
                case MailItem.StatusType.Sent:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Black;
                    break;
                case MailItem.StatusType.TimedOut:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    mailItem.viewItem.ForeColor = System.Drawing.Color.Black;
                    break;
            }
        }

        private async void sendTimer_Tick(object sender, EventArgs e)
        {
            logger.Debug("Send Timer Tick");
            sendInfoToolStripStatusLabel.Text = "Sending...";

            MailItem mailItem = new MailItem();
            mailItem.Timestamp = DateTime.Now;
            mailItem.Ticks = mailItem.Timestamp.Ticks;
            mailItem.ToAddress = Properties.Settings.Default.smtpToAddress;
            mailItem.TimeoutTimestamp = mailItem.Timestamp.AddSeconds(Decimal.ToDouble(Properties.Settings.Default.receiveTimeout));

            Task sendTask = Task.Run(() =>
            {


                string hostName = Dns.GetHostName();
                string hostIPv4 = "unknown";
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);
                foreach (IPAddress ip4 in addresses.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    hostIPv4 = ip4.ToString();
                    break;
                }

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(Properties.Settings.Default.smtpFromName, Properties.Settings.Default.smtpFromAddress));
                message.To.Add(MailboxAddress.Parse(mailItem.ToAddress));
                message.Subject = String.Format("Mail Check Client {0}", mailItem.Ticks);

                message.Body = new TextPart("plain")
                {
                    Text = String.Format(
                        "Hello\n\nThis e-mail was automatically generated by Mail Check Client.\n\nVersion: {0}\nClient-Host: {1} ({2})\nClient-Timestamp: {3}\nTicks: {4}\n\nEnd of message.",
                        System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                        hostName, hostIPv4,
                        mailItem.Timestamp,
                        mailItem.Ticks
                        )
                };


                using (SmtpClient client = Properties.Settings.Default.mailLoggingEnabled ? new SmtpClient(new ProtocolLogger(Properties.Settings.Default.mailLoggingFile)) : new SmtpClient())
                {
                    client.Timeout = Decimal.ToInt32(Properties.Settings.Default.smtpNetworkTimeout) * 1000;
                    client.ServerCertificateValidationCallback = NoSslCertificateValidationCallback;

                    try
                    {
                        if (Properties.Settings.Default.smtpSSL)
                        {
                            client.Connect(Properties.Settings.Default.smtpHost, Decimal.ToInt32(Properties.Settings.Default.smtpPort), MailKit.Security.SecureSocketOptions.Auto);
                        }
                        else
                        {
                            client.Connect(Properties.Settings.Default.smtpHost, Decimal.ToInt32(Properties.Settings.Default.smtpPort), false);
                        }

                        if (Properties.Settings.Default.smtpLoginUsername.Length > 0)
                        {
                            client.Authenticate(Properties.Settings.Default.smtpLoginUsername, Properties.Settings.Default.smtpLoginPassword);
                        }

                        logger.Info("Sending message...");
                        client.Send(message);
                        mailItem.Status = MailItem.StatusType.Sent;
                        logger.Info("Message successfully sent.");
                    }
                    catch (Exception ex)
                    {
                        mailItem.Status = MailItem.StatusType.Error;
                        logger.Error("Sending mail failed", ex);
                    }
                    finally
                    {
                        lock(mailItems)
                        {
                            mailItems.Add(mailItem);
                        }
                        client.Disconnect(true);
                    }
                }
            });

            await (sendTask);
            sendTask.Dispose();
            sendInfoToolStripStatusLabel.Text = "";
            insertMailListViewItem(mailItem);
        }

        private static bool NoSslCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
