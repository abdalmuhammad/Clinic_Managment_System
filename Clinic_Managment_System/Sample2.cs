using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {
            //MainClass.ApplyRoundedStyle(ADD_Btn, 20, 2, Color.Black);
        }

        public static int edit = 0;
        private void ADD_Btn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(Left_panel);
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                MainClass.EnableControls(Left_panel);
            }
        }

        public virtual void View_Btn_Click(object sender, EventArgs e)
        {

        }
        public virtual void Save_Btn_Click(object sender, EventArgs e)
        {

        }

        public virtual void Delete_Btn_Click(object sender, EventArgs e)
        {

        }
        public virtual void Search_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
