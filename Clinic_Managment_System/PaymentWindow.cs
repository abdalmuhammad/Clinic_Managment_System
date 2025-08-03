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
    public partial class PaymentWindow : Form
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }
        private void PatientWindow_Load(object sender, EventArgs e)
        {
                dataGridView1.AutoGenerateColumns = false;
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            AddPrintButtonToGrid();
        }
        private void loadcheckedPatient()
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
            loadda.Items.Add(TestNameGV);
            loadda.Items.Add(DiseaseNameGV);
            loadda.Items.Add(SymptomsNameGV);
            loadda.Items.Add(InternalMedicineGV);
            loadda.Items.Add(ExternalMedicineGV);
            loadda.Items.Add(RemarksGV);
            loadda.Items.Add(CheckupFeesGV);
            loadda.Items.Add(TotaltestFeesGV);
            loadda.Items.Add(TotalAmountGV);
            loadda.Items.Add(statusGV);
            loadda.Items.Add(AppIDGV);

            Hashtable ht = new Hashtable();

            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            int status = 1;

            ht.Add("@day", day);
            ht.Add("@month", month);
            ht.Add("@year", year);
            ht.Add("@status", status);

            CrudClass.LoadData("st_getPatientAppointmentRegistration3", dataGridView1, loadda, ht);
        }

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                loadcheckedPatient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Button Click Error: " + ex.Message);
            }
        }

        private void PaymentBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        public static int edit = 0;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               
                PatientTxtBox.Text = row.Cells["patientGV"].Value.ToString();
                GenderTxtBox.Text = row.Cells["genderGV"].Value.ToString();
                AgetxtBox.Text = row.Cells["ageGV"].Value.ToString();
                DoctortxtBox.Text = row.Cells["DoctorGV"].Value.ToString();
                DoctorCategorytxtBx.Text = row.Cells["DoctorRoleGV"].Value.ToString();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(row.Cells["TestNameGV"].Value.ToString().Split(','));

                listBox2.Items.Clear();
                listBox2.Items.AddRange(row.Cells["DiseaseNameGV"].Value.ToString().Split(','));

                listBox3.Items.Clear(); // Add a third ListBox for Symptoms
                listBox3.Items.AddRange(row.Cells["SymptomsNameGV"].Value.ToString().Split(','));

                checkipfeetxtBx.Text = Convert.ToDecimal(row.Cells["CheckupFeesGV"].Value).ToString("N0");
                testtxtBx.Text = Convert.ToDecimal(row.Cells["TotaltestFeesGV"].Value).ToString("N0");
                totalfeesTxTBx.Text = Convert.ToDecimal(row.Cells["TotalAmountGV"].Value).ToString("N0");
            }
        }
        private void AddPrintButtonToGrid()
        {
            if (!dataGridView1.Columns.Contains("PrintBtnGv"))
            {
                DataGridViewButtonColumn printBtn = new DataGridViewButtonColumn();
                printBtn.Name = "PrintBtnGv";  // This is the column name to match in CellClick
                printBtn.HeaderText = "Action";
                printBtn.Text = "Print";
                printBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(printBtn);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "PrintBtnGv")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string patient = row.Cells["patientGV"].Value?.ToString() ?? "";
                string Gender = row.Cells["genderGV"].Value?.ToString() ?? "";
                string age = row.Cells["ageGV"].Value?.ToString() ?? "";
                string doctor = row.Cells["DoctorGV"].Value?.ToString() ?? "";
                string test = row.Cells["TestNameGV"].Value?.ToString() ?? "";
                string disease = row.Cells["DiseaseNameGV"].Value?.ToString() ?? "";
                string symptoms = row.Cells["SymptomsNameGV"].Value?.ToString() ?? "";
                string InternalMedicine = row.Cells["InternalMedicineGV"].Value?.ToString() ?? "";
                string ExternalMedicine = row.Cells["ExternalMedicineGV"].Value?.ToString() ?? "";
                string remarks = row.Cells["RemarksGV"].Value?.ToString() ?? "";
                string checkup = row.Cells["CheckupFeesGV"].Value?.ToString() ?? "0";
                string testFees = row.Cells["TotaltestFeesGV"].Value?.ToString() ?? "0";
                string total = row.Cells["TotalAmountGV"].Value?.ToString() ?? "0";

                // Temporary debug log
                MessageBox.Show($"Test Print\nPatient: {patient}\nDoctor: {doctor}");

                Prescription_Report slip = new Prescription_Report(
                    patient, Gender, age, doctor, test, disease, symptoms, InternalMedicine, ExternalMedicine, remarks, checkup, testFees, total
                );
                slip.StartPosition = FormStartPosition.CenterScreen;
                slip.Show();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProccedBtn_Click(object sender, EventArgs e)
        {
            if (RcvdPaymentComBox.SelectedItem?.ToString() == "Received")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        int appointmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppIDGV"].Value);

                        // Step 2: Prepare parameter hashtable
                        Hashtable ht = new Hashtable();
                        ht.Add("@id", appointmentId);

                        int result = CrudClass.data_insert_update__delete("st_UpdatedPaymenRcvdtStatus", ht);

                        if (result > 0)
                        {
                            MainClass.showMessage("Appointment marked as Completed.", "Success");
                            loadcheckedPatient(); // Refresh grid
                        }
                        else
                        {
                            MainClass.showMessage("Failed to update appointment status.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MainClass.showMessage("Error: " + ex.Message, "Error");
                    }
                }
                else
                {
                    MainClass.showMessage("Please select a patient row to proceed.", "Warning");
                }
            }
            else
            {
                MainClass.showMessage("Please select 'Received' from the Payment dropdown before proceeding.", "Warning");
            }
        }

        private void RcvdPaymentComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

