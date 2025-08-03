using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using CRUD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Managment_System
{
    public partial class PatientRegistration : Sample2
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        Int64 appointmentID;
         private void LoadUser()
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
        private bool get_checkpatientRecord(string phone)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_CheckPatientRegistrationExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patientphone", phone);

                MainClass.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    check = true;
                    while (dr.Read())
                    {
                        // Populate values
                        pathID = Convert.ToInt64(dr["PatientID"].ToString());
                        PatientText.Text = dr["Patient"].ToString();
                        GendercomboBox.Text = dr["Gender"].ToString();
                        AgetextBox.Text = dr["Age"].ToString();

                        LastAppointdateTimePicker.Value = Convert.ToDateTime(dr["LastAppointment"].ToString());
                        ConsltedtextBox.Text = dr["Doctor/Dentist"].ToString();
                        StatustextBox.Text = dr["Status"].ToString();
                    }
                }
                else
                {
                    check = false;
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                throw;
            }
            return check;
        }
        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            CrudClass.loadList("st_getDoctors", AppointForcomboBox, "ID", "Doctor/Dentist", ht);
        }
        private void PhoneText_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneText.Text))
            {
                if (get_checkpatientRecord(PhoneText.Text))
                {
                    
                }
                else
                {
                    string phoneValue = PhoneText.Text; 
                    MainClass.resetEnable(Left_panel); 
                    PhoneText.Text = phoneValue;       
                }
            }
        }

        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        Int64 pathID;
        public override void Save_Btn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkcontrols(Left_panel).Count > 0)
            {
                MainClass.showMessage("fields with red are mandatory. ", "Error");
            }
            else
            {
                using (TransactionScope Sc = new TransactionScope()) 
                {
                    if (edit == 0) //code for save
                    {
                       
                            Hashtable ht = new Hashtable();
                            ht.Add("@Patientname", PatientText.Text);
                            ht.Add("@PatientGender", GendercomboBox.Text);
                            ht.Add("@Patientphone", PhoneText.Text);
                            ht.Add("@patientage", AgetextBox.Text);

                            if (CrudClass.data_insert_update__delete("st_insertpatientReg", ht) > 0)
                            {
                            Int64 patientID = Convert.ToInt64(CrudClass.getLastId("st_getLastPatientID"));

                            Hashtable htt = new Hashtable();
                                htt.Add("@date", AppointmentdateTimePicker.Value);
                                htt.Add("@doctorID", Convert.ToInt32(AppointForcomboBox.SelectedValue.ToString()));
                                htt.Add("@patientID", patientID);
                                htt.Add("@status", 0);
                                htt.Add("@day", AppointmentdateTimePicker.Value.Day);
                                htt.Add("@month", AppointmentdateTimePicker.Value.Month);
                                htt.Add("@year", AppointmentdateTimePicker.Value.Year);

                                if (CrudClass.data_insert_update__delete("st_insertAppointment", htt) > 0)
                                {
                                    MainClass.showMessage(PatientText.Text + " added successfully into system", "Success");
                                    MainClass.resetDisable(Left_panel);
                                    LoadUser();
                                }
                            } 
                        else
                        {
                                MainClass.showMessage("unable to save record.", "Error");
                        }
                    }
                    else if (edit == 1) // code for update
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@Patientname", PatientText.Text);
                        ht.Add("@PatientGender", GendercomboBox.Text);
                        ht.Add("@Patientphone", PhoneText.Text);
                        ht.Add("@patientage", AgetextBox.Text);
                        ht.Add("@id", pathID);
                        if (CrudClass.data_insert_update__delete("st_updatepatientReg", ht) > 0)
                        {
                            //Int64 patientID = Convert.ToInt64(CrudClass.getLastId("st_getLastPatientID"));
                                
                            Hashtable htt = new Hashtable();
                            htt.Add("@date", AppointmentdateTimePicker.Value);
                            htt.Add("@doctorID", Convert.ToInt32(AppointForcomboBox.SelectedValue.ToString()));
                            htt.Add("@patientID", pathID);
                            htt.Add("@status", 0);
                            htt.Add("@id", appointmentID);
                            if (CrudClass.data_insert_update__delete("st_updateAppointment", htt) > 0)
                            {
                                MainClass.showMessage(PatientText.Text + " updated successfully into system", "Success");
                                MainClass.resetDisable(Left_panel);
                                LoadUser();
                            }
                        }
                        else
                        {
                            MainClass.showMessage("unable to update record.", "Error");
                        }
                    }

                    else
                    {
                        MainClass.showMessage("unable to update record.", "Error");
                    }
                    Sc.Complete();
                }
            }
        }

        public override void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("are you sure?", "question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", pathID);

                    if (CrudClass.data_insert_update__delete("st_deletepatientReg", ht) > 0)
                    {
                        MainClass.showMessage(PatientText.Text + " delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadUser();
                    }
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                pathID = Convert.ToInt64(row.Cells["patientIDGV"].Value.ToString());
                appointmentID = Convert.ToInt64(row.Cells["AppIDGV"].Value.ToString());
                PhoneText.Text = row.Cells["phoneGV"].Value.ToString();
                PatientText.Text = row.Cells["patientGV"].Value.ToString();
                GendercomboBox.SelectedValue = row.Cells["genderGV"].Value.ToString();
                AppointmentdateTimePicker.Value =Convert.ToDateTime(row.Cells["appointdateGV"].Value.ToString());
                AppointForcomboBox.SelectedValue = row.Cells["doctorIDGV"].Value;
                AgetextBox.Text = row.Cells["ageGV"].Value.ToString();
                get_checkpatientRecord(PhoneText.Text);
            }
        }
        private void PatRegisBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }
        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }
        private void Left_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AppointmentdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AppointForcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
