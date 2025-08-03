using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CMS_connect";
            if (File.Exists(path))
            {
                LoginWindow lw = new LoginWindow();
                MainClass.showWindow(lw, MDI.ActiveForm);
            }
            else
            {
                SettingWindow lw = new SettingWindow();
                MainClass.showWindow(lw, MDI.ActiveForm);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingWindow lw = new SettingWindow();
            MainClass.showWindow(lw, MDI.ActiveForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWindow log = new LoginWindow();
            MainClass.showWindow(log, MDI.ActiveForm);
        }
    }
}
