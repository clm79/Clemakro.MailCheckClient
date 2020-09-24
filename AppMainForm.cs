using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clemakro.MailCheckClient
{
    public partial class AppMainForm : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
    }
}
