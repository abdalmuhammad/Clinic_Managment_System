using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenticaion;
using DocumentFormat.OpenXml.Wordprocessing;


namespace Clinic_Managment_System
{
    public partial class LoginWindow : Form
    {
        private bool fadeIn = true;
        public LoginWindow()
        {
            InitializeComponent();
/*            SetupWelcomeLabel();
*/        }
        
        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "") { username.BackColor = System.Drawing.Color.Firebrick; } else { username.BackColor = System.Drawing.Color.White; }
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonpaswrdbtn_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void bluepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonloginBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkcontrols(LoginPanel).Count > 0)
            {
                MainClass.showMessage("Fields with Red are mandatory. ", "Error");
            }
            else
            {
                Hashtable ht = new Hashtable();
                ht.Add("@username", username.Text);
                ht.Add("@passw", kryptonpaswrdbtn.Text);
                if (login.getLoginDetails("st_getAuthenticationDetails", ht))
                {
                    MainClass.LoggedInUserID = Convert.ToInt32(login.USERID);
                    MainClass.LoggedInUserRole = login.ROLE;


                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.showMessage("Enter correct username or password. ", "Error");
                }

            }
        }
        private void krptoncancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
