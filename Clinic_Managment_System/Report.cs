using CRUD;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clinic_Managment_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void LoadPatientReports()
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.Add(TurnGV);
                LoadDa.Items.Add(patientIDGV);
                LoadDa.Items.Add(patientGV);
                LoadDa.Items.Add(genderGV);
                LoadDa.Items.Add(appointdateGV);
                LoadDa.Items.Add(ageGV);
                LoadDa.Items.Add(DoctorGV);
                LoadDa.Items.Add(doctorIDGV);
                LoadDa.Items.Add(statusGV);
                LoadDa.Items.Add(AppIDGV);
                LoadDa.Items.Add(phoneGV);
                CrudClass.LoadData("st_getPatientAppointmentRegistration", dataGridView1, LoadDa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox LoadDa = new ListBox();
                LoadDa.Items.Add(TurnGV);
                LoadDa.Items.Add(patientIDGV);
                LoadDa.Items.Add(patientGV);
                LoadDa.Items.Add(genderGV);
                LoadDa.Items.Add(appointdateGV);
                LoadDa.Items.Add(ageGV);
                LoadDa.Items.Add(DoctorGV);
                LoadDa.Items.Add(doctorIDGV);
                LoadDa.Items.Add(statusGV);
                LoadDa.Items.Add(AppIDGV);
                LoadDa.Items.Add(phoneGV);

                Hashtable ht = new Hashtable();
                ht.Add("@fromDate", DateTimePicker_From.Value.Date);
                ht.Add("@toDate", DateTimePicker_TO.Value.Date);

                CrudClass.LoadData("st_filterPatientAppointmentsByDate", dataGridView1, LoadDa, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date filter error: " + ex.Message);
            }
        }
        private void SearctxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ListBox LoadDa = new ListBox();
                    LoadDa.Items.Add(TurnGV);
                    LoadDa.Items.Add(patientIDGV);
                    LoadDa.Items.Add(patientGV);
                    LoadDa.Items.Add(genderGV);
                    LoadDa.Items.Add(appointdateGV);
                    LoadDa.Items.Add(ageGV);
                    LoadDa.Items.Add(DoctorGV);
                    LoadDa.Items.Add(doctorIDGV);
                    LoadDa.Items.Add(statusGV);
                    LoadDa.Items.Add(AppIDGV);
                    LoadDa.Items.Add(phoneGV);

                    Hashtable ht = new Hashtable();
                    ht.Add("@searchTerm", SearctxtBox.Text.Trim());

                    CrudClass.LoadData("st_searchPatientAppointments", dataGridView1, LoadDa, ht);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
            }
        }
        private void View_Btn_Click(object sender, EventArgs e)
        {
            LoadPatientReports();
        }

        private void Dwn_Btn_Click(object sender, EventArgs e)
        {
            ButtonWindow btnWindow = new ButtonWindow(dataGridView1);
            btnWindow.StartPosition = FormStartPosition.CenterScreen;
            btnWindow.Size = new Size(400, 300); // Medium Size Window
            btnWindow.ShowDialog(); // Show as Modal Dialog
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearctxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
