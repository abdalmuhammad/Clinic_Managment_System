using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings;

namespace Clinic_Managment_System
{
    public partial class SettingWindow : Form
    {
        public SettingWindow()
        {
            InitializeComponent();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (IScheckBox.Checked) 
            {
                userIDtextBox.AllowDrop = true;
                passwordtextBox.AllowDrop = true;

                if (MainClass.checkcontrols(Settingpanel).Count > 0)
                {
                    MainClass.showMessage("Fields with red color are mandatory,", "Error");
                }
                else
                {
                    Setting.createFile("CMS_Connect", 1, DataSourcetextBox.Text, databasetextBox.Text);
                }

            }
            else
            {
                userIDtextBox.AllowDrop = false;
                passwordtextBox.AllowDrop = false;

                if (MainClass.checkcontrols(Settingpanel).Count > 0)
                {
                    MainClass.showMessage("Fields with red color are mandatory,", "Error");
                }
                else
                {
                    Setting.createFile("CMS_Connect", 0, DataSourcetextBox.Text, databasetextBox.Text, userIDtextBox.Text, passwordtextBox.Text);
                }
            }

            LoginWindow lw = new LoginWindow();
            MainClass.showWindow(lw, this, MDI.ActiveForm);

             
        }

        private void IScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IScheckBox.Checked)
            {
                userIDtextBox.Enabled = false;
                passwordtextBox.Enabled = false;
                userIDtextBox.Text = "";
                passwordtextBox.Text = "";
            }
            else
            {
                userIDtextBox.Enabled=true;
                passwordtextBox.Enabled = true;
            }
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
