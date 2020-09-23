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
        public AppMainForm()
        {
            InitializeComponent();
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettingsForm appSettingsForm = new AppSettingsForm();
            if(appSettingsForm.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
            }

        }
    }
}
