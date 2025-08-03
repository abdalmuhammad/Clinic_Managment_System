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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public void Reports_Load(object Form)
        {
            if (this.MainPanel.Controls.Count >0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {
            Reports_Load(new Dashboard());
        }
        private void Reports_Btn_Click(object sender, EventArgs e)
        {
            Reports_Load(new Report());
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void ReportBackbtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void PatientConsultRept_Btn_Click(object sender, EventArgs e)
        {
            Reports_Load(new SecondReport());
        }

        private void DoctorPerforBtn_Click(object sender, EventArgs e)
        {
            Reports_Load(new ThirdReport());
        }

        private void Dashboard_Btn_MouseClick(object sender, MouseEventArgs e)
        {
            /*Dashboard_Btn.BackColor = Color.DarkBlue;*/
        }

        private void Dashboard_Btn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void PatntPymntStatusBtn_Click(object sender, EventArgs e)
        {
            Reports_Load(new PaymentStatusReport());
        }
    }
}
