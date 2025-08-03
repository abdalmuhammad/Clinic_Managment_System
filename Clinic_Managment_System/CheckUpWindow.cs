using CRUD;
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
using System.Globalization;
using System.Transactions;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class CheckUpWindow : Sample2
    {
        public CheckUpWindow()
        {
            InitializeComponent();
        }
        private void getPatientINfo()
        {
            /* try
             {
                 SqlCommand cmd = new SqlCommand("st_getPatientsForDoctor", MainClass.con);
                 cmd.CommandType = CommandType.StoredProcedure;

                 // Check role: Only Admin should see all patients
                 bool isAdmin = MainClass.LoggedInUserRole == "Admin";
                 cmd.Parameters.AddWithValue("@doctorID", MainClass.LoggedInUserID);
                 cmd.Parameters.AddWithValue("@isAdmin", isAdmin ? 1 : 0);

                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 if (dt.Rows.Count > 0)
                 {
                     PatientDD.DataSource = dt;
                     PatientDD.DisplayMember = "pr_name";
                     PatientDD.ValueMember = "pa_id";
                 }
                 else
                 {
                     PatientDD.DataSource = null;
                     MessageBox.Show("No patients found for this doctor.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error in getPatientINfo: " + ex.Message);
                 MainClass.con.Close();
             }*/
            try
            {
                SqlCommand cmd = new SqlCommand("St_getPatientGenderAndAge", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(PatientDD.SelectedValue.ToString()));
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gendertext.Text = dr[0].ToString();
                        agetext.Text = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                MainClass.con.Close();

            }
        }
        private Int64 getPatientAppointmentID()
        {
            Int64 appointmentID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPatientAppointmentID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patID", Convert.ToInt64(PatientDD.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@day", dateTimePicker1.Value.Day);
                cmd.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                cmd.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

                MainClass.con.Open();
                appointmentID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception )
            {
                MainClass.con.Close();
            }
            return appointmentID;
        
        }
        private int getDiseaseID(string name)
        {
            int did = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("st_getDiseaseIDWRTName", MainClass.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name); 

                    MainClass.con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null) 
                    {
                        did = Convert.ToInt32(result);
                    }
                    MainClass.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching disease ID: " + ex.Message);
                MainClass.con.Close();
            }
            return did;
        }
        private Int64 getSymtomID(string name)
        {
            Int64 sid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSymtomIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    sid = Convert.ToInt64(result);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching symptom ID: " + ex.Message);
                MainClass.con.Close();
            }
            return sid;
        }
        
        private int getTestID(string name)
        {
            int tid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTestIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tid = Convert.ToInt32(result);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching test ID: " + ex.Message);
                MainClass.con.Close();
            }
            return tid;
        }
        private int getMedicineID(string name)
        {
            int mid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMedicineIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                mid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return mid;
        }
    
        private void LoadtodayPatients()
        {
            try
            {
                PatientDD.DataSource = null;

                Hashtable ht = new Hashtable();
                ht.Add("@day", dateTimePicker1.Value.Day);
                ht.Add("@month", dateTimePicker1.Value.Month);
                ht.Add("@year", dateTimePicker1.Value.Year);
                ht.Add("@phoneNumber", DBNull.Value);
                ht.Add("@doctorID", MainClass.LoggedInUserID);
                ht.Add("@isAdmin", MainClass.LoggedInUserRole == "Admin" ? 1 : 0);

                CrudClass.loadList("st_getTodaysPatients", PatientDD, "Patient ID", "Patient", ht);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in LoadtodayPatients: " + ex.Message);
            }

                  }
        private void CheckUpWindow_Load(object sender, EventArgs e)
        {
            LoadtodayPatients();
            Hashtable ht = new Hashtable();
            CrudClass.loadList("st_getDiseases", diseasecomboBox, "ID", "Disease", ht);
            CrudClass.loadList("st_getSymptoms", SympCB, "SymptomID", "Symptom", ht);
            CrudClass.loadList("st_getTests", TestCB, "ID", "Test", ht);

            Hashtable ht1 = new Hashtable();
            ht1.Add("@Type", 0);
            CrudClass.loadList("st_getMedicineWRTType", PreInternalCB, "ID", "Medicine", ht1);

            Hashtable ht2 = new Hashtable();
            ht2.Add("@Type", 1);
            CrudClass.loadList("st_getMedicineWRTType", PreExternalCB, "ID", "Medicine", ht2);

        }

        public static int turnNo;

        Int64 patientAppID = 0;
        public void getLastMedicine(ListBox lb, Int64 appID, Int16 type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastPrescribedMedicine",MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type",type);
                cmd.Parameters.AddWithValue("@appID",appID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lb.DisplayMember = "Medicine";
                lb.ValueMember = "ID";
                lb.DataSource =dt;

            }
            catch (Exception)
            {

            }
        }
        public void getLastDetails(string proc, ListBox lb, string param, object val, string dMember, string vMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, val);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lb.DataSource = dt;
                    lb.DisplayMember = dMember; 
                    lb.ValueMember = vMember;
                }
                else
                {
                    lb.DataSource = null;
                    lb.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void getLastRemarks()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastRemarks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@appID", patientAppID);

                MainClass.con.Open();
                object result = cmd.ExecuteScalar(); // Pehlay result ko object variable me store karein
                MainClass.con.Close();

                if (result != null && result != DBNull.Value)
                {
                    PrevRemTxt1.Text = result.ToString(); // Safe conversion
                }
                else
                {
                    PrevRemTxt1.Text = "No Remarks"; // Default value if no data found
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show("Error: " + ex.Message); // Exception ko print karein
            }
        }

        public void getLastCheckupDetails(Int16 status, Int64 PatientID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastCheckupDetails1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@patientID", PatientID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())  // Check if there is at least one row
                    {
                        string appointmentDateStr = dr["AppointmentDate"] != DBNull.Value ? dr["AppointmentDate"].ToString() : "NULL";
                        MessageBox.Show("Raw AppointmentDate: " + appointmentDateStr, "Debug Info");

                        if (dr["AppointmentDate"] != DBNull.Value &&
                            DateTime.TryParseExact(dr["AppointmentDate"].ToString(), "dd-MMM-yyyy hh:mm tt",
                                                   CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                        {
                            LastAppointdateTimePicker.Value = parsedDate;
                            MessageBox.Show("Parsed Date: " + parsedDate.ToString("yyyy-MM-dd HH:mm:ss"), "Success");
                        }
                        else
                        {
                            MessageBox.Show("Invalid or NULL Date! Setting to current date.", "Warning");
                            LastAppointdateTimePicker.Value = DateTime.Now;
                        }

                        // Assign values safely
                        ConsultoText.Text = dr["Doctor"] != DBNull.Value ? dr["Doctor"].ToString() : "N/A";
                        Ptxt.Text = dr["Pulse"] != DBNull.Value ? dr["Pulse"].ToString() : "N/A";
                        Btxt.Text = dr["Glucose"] != DBNull.Value ? dr["Glucose"].ToString() : "N/A";
                        T_txt.Text = dr["Temperature"] != DBNull.Value ? dr["Temperature"].ToString() : "N/A";
                        // Convert AppointID safely
                        patientAppID = dr["AppointID"] != DBNull.Value && long.TryParse(dr["AppointID"].ToString(), out long appID) ? appID : 0;
                    }
                    else
                    {
                        MessageBox.Show("No data found for this patient!", "Error");
                    }

                    while (dr.Read())
                    {
                        string appointmentDateStr = dr["AppointmentDate"] != DBNull.Value ? dr["AppointmentDate"].ToString() : "NULL";
                        MessageBox.Show("Raw AppointmentDate: " + appointmentDateStr, "Debug Info");

                        if (dr["AppointmentDate"] != DBNull.Value && DateTime.TryParse(dr["AppointmentDate"].ToString(), out DateTime parsedDate))
                        {
                            LastAppointdateTimePicker.Value = parsedDate;
                            MessageBox.Show("Parsed Date: " + parsedDate.ToString("yyyy-MM-dd HH:mm:ss"), "Success");
                        }
                        else
                        {
                            MessageBox.Show("Invalid or NULL Date! Setting to current date.", "Warning");
                            LastAppointdateTimePicker.Value = DateTime.Now;
                        }

                        ConsultoText.Text = dr["Doctor"] != DBNull.Value ? dr["Doctor"].ToString() : "N/A";
                        Ptxt.Text = dr["Pulse"] != DBNull.Value ? dr["Pulse"].ToString() : "N/A";
                        Btxt.Text = dr["Glucose"] != DBNull.Value ? dr["Glucose"].ToString() : "N/A";
                        T_txt.Text = dr["Temperature"] != DBNull.Value ? dr["Temperature"].ToString() : "N/A";  // Corrected Spelling
                        patientAppID = dr["AppointID"] != DBNull.Value ? Convert.ToInt64(dr["AppointID"]) : 0;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }
        private void Call_PTN_BTN_Click(object sender, EventArgs e)
        {
            if (PatientDD.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            ht.Add("@patID", Convert.ToInt64(PatientDD.SelectedValue.ToString()));

            DataTable dt = CrudClass.getDataTable("st_getTurnDoctorInfoWRTPatientWRTToday", ht);
            string turnNo = "", doctorName = "", doctorRole = "";

            if (dt.Rows.Count > 0)
            {
                turnNo = dt.Rows[0]["TurnNumber"].ToString();
                doctorName = dt.Rows[0]["DoctorName"].ToString();
                doctorRole = dt.Rows[0]["DoctorRole"].ToString();

                TurnWindow.EnqueueTurnInfo(turnNo, doctorName, doctorRole);
            }
            else
            {
                MessageBox.Show("No data found in DataTable!", "DEBUG");
            }

            getPatientINfo();
            patientAppID = Convert.ToInt64(PatientDD.SelectedValue.ToString());
            getLastCheckupDetails(1, Convert.ToInt64(PatientDD.SelectedValue.ToString()));
            getLastMedicine(listBox1, patientAppID, 0);
            getLastMedicine(listBox2, patientAppID, 1);
            getLastDetails("St_getLastTests", listBox5, "@appID", patientAppID, "Test", "ID");
            getLastDetails("St_getLastSymptoms", listBox4, "@appID", patientAppID, "Symptom", "ID");
            getLastDetails("St_getLastDisease", listBox3, "@appID", patientAppID, "Disease", "ID");
            getLastRemarks();
        }

        private void PatientDD_Enter_1(object sender, EventArgs e)
        {
            LoadtodayPatients(); // Show all today's patients for Admin

        }
        private void DiseaseAddBtn_Click(object sender, EventArgs e)
        {
            if (diseasecomboBox.Text != "")
            {
                if (!DiseaseLB.Items.Contains(diseasecomboBox.Text))
                {
                    DiseaseLB.Items.Add(diseasecomboBox.Text);
                }
            }
        }

        Hashtable htInternal = new Hashtable();
        Hashtable htExternal = new Hashtable();
        private void InternalAddBtn_Click(object sender, EventArgs e)
        {
            if (PreInternalCB.Text != "")
            {
                if (!MorningRB.Checked && !MorEveningRB.Checked && !MorAfternoonNightRB.Checked && !BeforeMealRB.Checked && !BeforeSleepRB.Checked && !OnceaDayRB.Checked && !OtherRB.Checked)
                {
                    MainClass.showMessage("Please select dosage of this medicine. ", "Error");
                }
                else
                {
                    if (!InternalLB.Items.Contains(PreInternalCB.Text))
                    {
                        if (MorningRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 0);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + MorningRB.Text);
                        }
                        else if (MorEveningRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 1);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + MorEveningRB.Text);
                        }
                        else if (MorAfternoonNightRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 2);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + MorAfternoonNightRB.Text);
                        }
                        else if (BeforeMealRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 3);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + BeforeMealRB.Text);
                        }
                        else if (BeforeSleepRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 4);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + BeforeSleepRB.Text);
                        }
                        else if (OnceaDayRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 5);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + OnceaDayRB.Text);
                        }
                        else if (OtherRB.Checked)
                        {
                            htInternal.Add(PreInternalCB.Text, 6);
                            InternalLB.Items.Add(PreInternalCB.Text + "|" + othertext.Text);
                        }
                        MorningRB.Checked = false;
                        MorEveningRB.Checked = false;
                        MorAfternoonNightRB.Checked = false;
                        BeforeMealRB.Checked = false;
                        BeforeSleepRB.Checked = false;
                        OnceaDayRB.Checked = false;
                        OtherRB.Checked = false;
                    }
                }
            }
        }

        private void ExternalAddBtn_Click(object sender, EventArgs e)
        {
            if (PreExternalCB.Text != "")
            {
                if (!Mor2RB.Checked && !MorEve2RB.Checked && !MorAfterNight2RB.Checked && !BeforeMeal2RB.Checked && !BeforeSleep2RB.Checked && !OnceaDay2RB.Checked && !Other2RB.Checked)
                {
                    MainClass.showMessage("Please select dosage of this medicine. ", "Error");
                }
                else
                {
                    if (!ExternalLB.Items.Contains(PreExternalCB.Text))
                    {
                        if (Mor2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 0);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + Mor2RB.Text);
                        }
                        else if (MorEve2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 1);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + MorEve2RB.Text);
                        }
                        else if (MorAfterNight2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 2);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + MorAfterNight2RB.Text);
                        }
                        else if (BeforeMeal2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 3);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + BeforeMeal2RB.Text);
                        }
                        else if (BeforeSleep2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 4);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + BeforeSleep2RB.Text);
                        }
                        else if (OnceaDay2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 5);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + OnceaDay2RB.Text);
                        }
                        else if (Other2RB.Checked)
                        {
                            htExternal.Add(PreExternalCB.Text, 6);
                            ExternalLB.Items.Add(PreExternalCB.Text + "|" + Other2Text.Text);
                        }
                        Mor2RB.Checked = false;
                        MorEve2RB.Checked = false;
                        MorAfterNight2RB.Checked = false;
                        BeforeMeal2RB.Checked = false;
                        BeforeSleep2RB.Checked = false;
                        OnceaDay2RB.Checked = false;
                        Other2RB.Checked = false;
                    }
                }
            }
        }
        private void TestAddBtn_Click(object sender, EventArgs e)
        {
            if (TestCB.Text != "")
            {
                if (!TestLB.Items.Contains(TestCB.Text))
                {
                    TestLB.Items.Add(TestCB.Text);
                }
            }
        }
        private void SympAddBtn_Click(object sender, EventArgs e)
        {
            if (SympCB.Text != "")
            {
                if (!SympLB.Items.Contains(SympCB.Text))
                {
                    SympLB.Items.Add(SympCB.Text);
                }
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OtherRB_CheckedChanged(object sender, EventArgs e)
        {
            if (OtherRB.Checked) 
            {
                othertext.Enabled = true;
            }
            else
            {
                othertext.Enabled = false;
            }
        }
        private void Other2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Other2RB.Checked)
            {
                Other2Text.Enabled = true;
            }
            else
            {
                Other2Text.Enabled = false;
            }
        }
        private void checkupBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void InternalRemBtn_Click(object sender, EventArgs e)
        {
            if (InternalLB.SelectedItem != null) 
            {
                char[] delim = { '|' };
                string[] arr = InternalLB.SelectedItem.ToString().Split(delim);
                htInternal.Remove(arr[0]); 
                InternalLB.Items.Remove(InternalLB.SelectedItem); // Remove the selected item
            }
            else
            {
                MessageBox.Show("No item selected to remove.");
            }
        }

        private void ExternalRemBtn_Click(object sender, EventArgs e)
        {
            if (ExternalLB.SelectedItem != null) // Check if an item is selected
            {
                char[] delim = { '|' };
                string[] arr = ExternalLB.SelectedItem.ToString().Split(delim);
                htExternal.Remove(arr[0]); // Remove the corresponding key from the Hashtable
                ExternalLB.Items.Remove(ExternalLB.SelectedItem); // Remove the selected item
            }
            else
            {
                MessageBox.Show("No item selected to remove.");
            }
        }

        private void DiseaseRemBtn_Click(object sender, EventArgs e)
        {
            if (DiseaseLB.SelectedItems.Count > 0)
            {
                DiseaseLB.Items.Remove(DiseaseLB.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected to remove.");
            }
        }

        private void SympRemBtn_Click(object sender, EventArgs e)
        {
            if (SympLB.SelectedItems.Count > 0)
            {
                SympLB.Items.Remove(SympLB.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected to remove.");
            }
        }
        public override void View_Btn_Click(object sender, EventArgs e)
        {

        }
        public override void Save_Btn_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope())
            {
                Int64 patientAppointmentID = getPatientAppointmentID();
                ///////////////////////////////// DISEASE CODE //////////////////////////////////////////
                if (DiseaseLB.Items.Count > 0) 
                {
                    foreach (string item in DiseaseLB.Items)
                    {
                       

                        Hashtable h = new Hashtable();
                        h.Add("@disease", item);
                        int diseaseID;

                        if (!CrudClass.checkExistance("st_checkDisease", h))
                        {
                            CrudClass.data_insert_update__delete("st_insertDisease", h);
                            diseaseID = Convert.ToInt32(CrudClass.getLastId("st_getLastDiseaseID"));
                        }
                        else
                        {
                            diseaseID = getDiseaseID(item);

                        }
                        if (diseaseID > 0)
                        {
                            Hashtable PatientDiseaseHT = new Hashtable();
                            PatientDiseaseHT.Add("@appID", patientAppointmentID);
                            PatientDiseaseHT.Add("@diseaseID", diseaseID);

                            bool exists = CrudClass.checkExistance("st_checkPatientDisease", PatientDiseaseHT);

                            if (!exists)
                            {
                                try
                                {
                                    CrudClass.data_insert_update__delete("st_insertPatientDisease", PatientDiseaseHT);
                                  
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("❌ Error inserting into PatientDisease:\n" + ex.Message, "DB Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Skipped insertion — DiseaseID {diseaseID} already exists for AppointmentID {patientAppointmentID}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: diseaseID is 0, cannot insert into PatientDisease.", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

                if (SympLB.Items.Count > 0)
                {
                    foreach (string item in SympLB.Items)
                    {
                        Int64 symptomID;
                        Hashtable h = new Hashtable();
                        h.Add("@symptom", item);

                        if (!CrudClass.checkExistance("st_checkSymptomExists2", h))
                        {
                            CrudClass.data_insert_update__delete("st_insertSymptoms", h);
                            symptomID = Convert.ToInt64(CrudClass.getLastId("st_getLastSymptomID"));
                        }
                        else
                        {
                            symptomID = getSymtomID(item);
                            MessageBox.Show($"Debug: Symptom ID for '{item}' = {symptomID}");
                        }

                        if (symptomID > 0)
                        {
                            Hashtable PatientSymptomHT = new Hashtable();
                            PatientSymptomHT.Add("@appID", patientAppointmentID);
                            PatientSymptomHT.Add("@symID", symptomID);

                            bool alreadyLinked = CrudClass.checkExistance("st_checkPatientSymptomExists", PatientSymptomHT);

                            if (!alreadyLinked) 
                            {
                                CrudClass.data_insert_update__delete("st_insertPatientSymptoms", PatientSymptomHT);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Error: symptomID is 0, cannot insert into PatientSymptoms.", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                ///////////////////////////////// TEST CODE //////////////////////////////////////////
                if (TestLB.Items.Count > 0)
                {
                    foreach (string item in TestLB.Items)
                    {
                        Hashtable h = new Hashtable();
                        h.Add("@name", item);
                        int testID;
                        if (!CrudClass.checkExistance("st_checkTestsExists", h))
                        {
                            CrudClass.data_insert_update__delete("st_insertTests2", h);
                            testID = Convert.ToInt32(CrudClass.getLastId("st_getLastTestID"));
                        }
                        else
                        {
                            testID = getTestID(item);
                        }
                        Hashtable PatientTestHT = new Hashtable();
                        PatientTestHT.Add("@appID", patientAppointmentID);
                        PatientTestHT.Add("@testID", testID);
                        CrudClass.data_insert_update__delete("st_insertPatientTests", PatientTestHT);
                    }
                }
                ///////////////////////////////// INTERNAL MEDICINE CODE //////////////////////////////////////////
                if (InternalLB.Items.Count > 0)
                {
                    char[] delim = { '|' };

                    foreach (string item in InternalLB.Items)
                    {
                        string[] med = item.Split(delim);
                        Hashtable h = new Hashtable();
                        h.Add("@name", med[0]);
                        h.Add("@type", 0);
                        int medicineID;
                        if (!CrudClass.checkExistance("st_checkMedicineExists", h))
                        {
                            CrudClass.data_insert_update__delete("st_insertMedicine2", h);
                            medicineID = Convert.ToInt32(CrudClass.getLastId("st_getLastMedicineID"));
                        }
                        else
                        {
                            medicineID = getMedicineID(med[0]);
                        }
                        Hashtable PatientInternalHT = new Hashtable();
                        PatientInternalHT.Add("@appID", patientAppointmentID);
                        PatientInternalHT.Add("@medicineID", medicineID);
                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if(med[1] == "Morning + Evening") 
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + Afternoon + Night")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "At night before Sleep")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Once a day")
                        {
                            dosageID = 5;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 6;
                        }

                        PatientInternalHT.Add("@dosage",dosageID);
                        if (OtherRB.Checked) 
                        {
                            PatientInternalHT.Add("@other",othertext.Text);
                            CrudClass.data_insert_update__delete("st_insertPatientMedicineALL", PatientInternalHT);
                        }
                        else
                        {
                            CrudClass.data_insert_update__delete("st_insertPatientMedicine", PatientInternalHT);
                        }
                    }
                }
                ///////////////////////////////// EXTERNAL MEDICINE CODE //////////////////////////////////////////
                if (ExternalLB.Items.Count > 0)
                {
                    char[] delim = { '|' };

                    foreach (string item in ExternalLB.Items)
                    {
                        string[] med = item.Split(delim);

                        Hashtable h = new Hashtable();
                        h.Add("@name", med[0]);
                        h.Add("@type", 1);
                        int medicineID;
                        if (!CrudClass.checkExistance("st_checkMedicineExists", h))
                        {
                            CrudClass.data_insert_update__delete("st_insertMedicine2", h);
                            medicineID = Convert.ToInt32(CrudClass.getLastId("st_getLastMedicineID"));
                        }
                        else
                        {
                            medicineID = getMedicineID(med[0]);
                        }
                        Hashtable PatientExternallHT = new Hashtable();
                        PatientExternallHT.Add("@appID", patientAppointmentID);
                        PatientExternallHT.Add("@medicineID", medicineID);
                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if (med[1] == "Morning + Evening")
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + Afternoon + Night")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "At night before Sleep")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Once a day")
                        {
                            dosageID = 5;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 6;
                        }
                        PatientExternallHT.Add("@dosage", dosageID);
                        if (Other2RB.Checked)
                        {
                            PatientExternallHT.Add("@other", Other2Text.Text); 
                            CrudClass.data_insert_update__delete("st_insertPatientMedicineAll", PatientExternallHT);
                        }
                        else
                        {
                            CrudClass.data_insert_update__delete("st_insertPatientMedicine", PatientExternallHT);
                        }
                    }
                }
                ///////////////////////////////// PULSE GLUCOSE AND TEMPERATURE CODE //////////////////////////////
                Hashtable htPGT = new Hashtable();
                htPGT.Add("@appID", patientAppointmentID);
                htPGT.Add("@pulse",PulseTextBox.Text);
                htPGT.Add("@temp",TempTextBox.Text);
                htPGT.Add("@glucose",BloodTextBx.Text);
                CrudClass.data_insert_update__delete("st_insertPulseGlucoseTemp", htPGT);

                ///////////////////////////////// REMARKS AND FEES CODE //////////////////////////////////////////
                Hashtable htRemFees = new Hashtable();
                htRemFees.Add("@appID", patientAppointmentID);
                htRemFees.Add("@rem", RemarksTextBox.Text);
                htRemFees.Add("@fees", FeestextBox.Text);
                CrudClass.data_insert_update__delete("st_insertpatientCheckup", htRemFees);
                /////////////////////////////////////////////////////////////////////////////////////////////////

                Hashtable htStatus = new Hashtable();
                htStatus.Add("@appID", patientAppointmentID);
                htStatus.Add("@status", 1);
                CrudClass.data_insert_update__delete("st_updatePatientStatus", htStatus);
                /////////////////////////////////////////////////////////////////////////////////////////////////

                MainClass.showMessage("Patient Checkup Sucessfully", "Success");
                sc.Complete();
            }
        }

        public override void Delete_Btn_Click(object sender, EventArgs e)
        {

        }
        public override void Search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SympCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void PulseTextBox_Enter(object sender, EventArgs e)
        {
            PulseTextBox.SelectAll();
        }

        private void TestCB_Leave(object sender, EventArgs e)
        {

        }

        private void SympCB_Enter(object sender, EventArgs e)
        {
            SympCB.SelectAll();
        }

        private void PreExternalCB_Enter(object sender, EventArgs e)
        {
            PreExternalCB.SelectAll();
        }

        private void PreInternalCB_Enter(object sender, EventArgs e)
        {
            PreInternalCB.SelectAll();
        }

        private void diseasecomboBox_Enter(object sender, EventArgs e)
        {
            diseasecomboBox.SelectAll();
        }

        private void BloodTextBx_Enter(object sender, EventArgs e)
        {
            BloodTextBx.SelectAll();
        }

        private void PulseTextBox_Leave(object sender, EventArgs e)
        {
            if (PulseTextBox.Text == "")
            {
                PulseTextBox.Text = "-";
            }
        }

        private void TempTextBox_Enter(object sender, EventArgs e)
        {
            TempTextBox.SelectAll();
        }

        private void TempTextBox_Leave(object sender, EventArgs e)
        {
            if (TempTextBox.Text == "")
            {
                TempTextBox.Text = "-";
            }
        }
        private void BloodTextBx_Leave(object sender, EventArgs e)
        {
            if (BloodTextBx.Text == "")
            {
                BloodTextBx.Text = "-";
            }
        }

        private void agetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrevRemTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mor2RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gendertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
