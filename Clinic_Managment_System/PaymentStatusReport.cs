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

namespace Clinic_Managment_System
{
    public partial class PaymentStatusReport : Form
    {
        public PaymentStatusReport()
        {
            InitializeComponent();
        }
        private void PaymentStatusReport_Load(object sender, EventArgs e)
        {

        }
        private void loadPatientPaymentStatusFilterWise()
        {
            try
            {
                ListBox loadda = new ListBox();
                loadda.Items.Add(TurnGV);
                loadda.Items.Add(patientIDGV);
                loadda.Items.Add(patientGV);
                loadda.Items.Add(phoneGV);
                loadda.Items.Add(genderGV);
                loadda.Items.Add(ageGV);
                loadda.Items.Add(appointdateGV);
                loadda.Items.Add(doctorIDGV);
                loadda.Items.Add(DoctorGV);
                loadda.Items.Add(DoctorRoleGV);
                loadda.Items.Add(CheckupFeesGV);
                loadda.Items.Add(TotaltestFeesGV);
                loadda.Items.Add(TotalAmountGV);
                loadda.Items.Add(statusGV);
                loadda.Items.Add(AppIDGV);

                Hashtable ht = new Hashtable();
                ht.Add("@fromDate", DateTimePicker_From.Value.Date);
                ht.Add("@toDate", DateTimePicker_TO.Value.Date);

                string searchTerm = SearchTxtBox.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    ht.Add("@searchTerm", searchTerm);
                }
                else
                {
                    ht.Add("@searchTerm", DBNull.Value);
                }

                CrudClass.LoadData("st_gePatienttPaymentstatusReport", dataGridView1, loadda, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadAllPatienttPaymentstatus()
        {
            try
            {
                ListBox loadda = new ListBox();
                loadda.Items.Add(TurnGV);
                loadda.Items.Add(patientIDGV);
                loadda.Items.Add(patientGV);
                loadda.Items.Add(phoneGV);
                loadda.Items.Add(genderGV);
                loadda.Items.Add(ageGV);
                loadda.Items.Add(appointdateGV);
                loadda.Items.Add(doctorIDGV);
                loadda.Items.Add(DoctorGV);
                loadda.Items.Add(DoctorRoleGV);
                loadda.Items.Add(CheckupFeesGV);
                loadda.Items.Add(TotaltestFeesGV);
                loadda.Items.Add(TotalAmountGV);
                loadda.Items.Add(statusGV);
                loadda.Items.Add(AppIDGV);

                Hashtable ht = new Hashtable();

                ht.Add("@fromDate", DBNull.Value);
                ht.Add("@toDate", DBNull.Value);

                string searchTerm = SearchTxtBox.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    ht.Add("@searchTerm", searchTerm);
                }
                else
                {
                    ht.Add("@searchTerm", DBNull.Value);
                }

                CrudClass.LoadData("st_geViewAllPatienttPaymentstatusReport", dataGridView1, loadda, ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            loadPatientPaymentStatusFilterWise();
        }

        private void Dwn_Btn_Click(object sender, EventArgs e)
        {
            ButtonWindow btnWindow = new ButtonWindow(dataGridView1);
            btnWindow.StartPosition = FormStartPosition.CenterScreen;
            btnWindow.Size = new Size(400, 300);
            btnWindow.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "statusGV" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Received")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }

        }
        private void View_Btn_Click(object sender, EventArgs e)
        {
            LoadAllPatienttPaymentstatus();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadPatientPaymentStatusFilterWise();
                LoadAllPatienttPaymentstatus();
            }
        }
    }
}
