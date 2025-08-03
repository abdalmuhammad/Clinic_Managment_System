using CRUD;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Managment_System
{
    public partial class ThirdReport : Form
    {
        public ThirdReport()
        {
            InitializeComponent();
        }

        private void ThirdReport_Load(object sender, EventArgs e)
        {

        }

        private void LoadDoctorConsultedToPatientReports()
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.Add(DoctorGV);
                LoadDa.Items.Add(DoctorRoleGV);
                LoadDa.Items.Add(TotalConsultPatientGV);
                LoadDa.Items.Add(TotalEarningGV);

                Hashtable ht = new Hashtable();

                DateTime fromDate = DateTimePicker_From.Value.Date;
                DateTime toDate = DateTimePicker_TO.Value.Date;

                int status = 2; // For Consulted

                ht.Add("@fromDate", fromDate);
                ht.Add("@toDate", toDate);
                ht.Add("@status", status);

                CrudClass.LoadData("st_getDoctorConsultedReport", dataGridView1, LoadDa, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllDoctorConsultedToPatientReports()
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.AddRange(new object[]
                {
                    DoctorGV,DoctorRoleGV, TotalConsultPatientGV, TotalEarningGV
                });

                Hashtable ht = new Hashtable();

                int status = 2;
                ht.Add("@fromDate", DBNull.Value);
                ht.Add("@toDate", DBNull.Value);
                ht.Add("@status", status);

                CrudClass.LoadData("st_getDoctorConsultedReport", dataGridView1, LoadDa, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all patient reports: " + ex.Message);
            }
        }

        private void View_Btn_Click(object sender, EventArgs e)
        {
            LoadAllDoctorConsultedToPatientReports();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            LoadDoctorConsultedToPatientReports();
        }

        private void Dwn_Btn_Click(object sender, EventArgs e)
        {
            ButtonWindow btnWindow = new ButtonWindow(dataGridView1);
            btnWindow.StartPosition = FormStartPosition.CenterScreen;
            btnWindow.Size = new Size(400, 300); // Medium Size Window
            btnWindow.ShowDialog(); // Show as Modal Dialog
        }
    }
}
