using System;
using CRUD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clinic_Managment_System
{
    public partial class SecondReport : Form
    {
        public SecondReport()
        {
            InitializeComponent();
        }

        private void LoadConsultedPatientReports()
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.Add(TurnGV);
                LoadDa.Items.Add(AppIDGV);
                LoadDa.Items.Add(appointdateGV);
                LoadDa.Items.Add(patientIDGV);
                LoadDa.Items.Add(patientGV);
                LoadDa.Items.Add(genderGV);
                LoadDa.Items.Add(ageGV);
                LoadDa.Items.Add(doctorIDGV);
                LoadDa.Items.Add(DoctorGV);
                LoadDa.Items.Add(DoctorRoleGV);
                LoadDa.Items.Add(checkupfeeGV);
                LoadDa.Items.Add(totaltestfeesGV);
                LoadDa.Items.Add(totalamountGV);
                LoadDa.Items.Add(statusGV);
                LoadDa.Items.Add(phoneGV);

                Hashtable ht = new Hashtable();

                DateTime fromDate = DateTimePicker_From.Value.Date;
                DateTime toDate = DateTimePicker_TO.Value.Date;

                int status = 1; // For Consulted

                ht.Add("@fromDate", fromDate);
                ht.Add("@toDate", toDate);
                ht.Add("@status", status);

                CrudClass.LoadData("st_getPatientConsultedReport", dataGridView1, LoadDa, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllConsultedReports()
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.AddRange(new object[]
                {
            TurnGV, AppIDGV, appointdateGV, patientIDGV, patientGV,
            genderGV, ageGV, doctorIDGV, DoctorGV, DoctorRoleGV,
            checkupfeeGV, totaltestfeesGV, totalamountGV, statusGV, phoneGV
                });

                Hashtable ht = new Hashtable();

                int status = 1;
                ht.Add("@fromDate", DBNull.Value);
                ht.Add("@toDate", DBNull.Value);
                ht.Add("@status", status);

                CrudClass.LoadData("st_getPatientConsultedReport", dataGridView1, LoadDa, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all patient reports: " + ex.Message);
            }
        }
        private void SecondReport_Load(object sender, EventArgs e)
        {

        }
        private void View_Btn_Click(object sender, EventArgs e)
        {
            LoadAllConsultedReports();
        }
        private void filter_btn_Click(object sender, EventArgs e)
        {
            LoadConsultedPatientReports();
        }
        private void DateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DateTimePicker_TO_ValueChanged(object sender, EventArgs e)
        {

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
