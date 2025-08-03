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
using CRUD;

namespace Clinic_Managment_System
{
    public partial class Symptoms : Sample2
    {
        public Symptoms()
        {
            InitializeComponent();
        }

        private void Symptoms_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadSymptom()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(symptomIDGV);
            LoadDa.Items.Add(SymtomsGV);
            CrudClass.LoadData("st_getSymptoms", dataGridView1, LoadDa);
        }
        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadSymptom();
        }

        int SymptomsID;
        public override void Save_Btn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkcontrols(Left_panel).Count > 0)
            {
                MainClass.showMessage("Fields highlighted in red are mandatory.", "Error");
            }
            else
            {
                if (edit == 0) // For Save
                {
                    // Create parameter hashtable
                    Hashtable ht = new Hashtable();
                    ht.Add("@symptom", Symptomstext.Text);
                    Console.WriteLine("Performing Save Operation");
                    if (CrudClass.data_insert_update__delete("st_insertSymptoms", ht) > 0)
                    {
                        MainClass.showMessage($"{Symptomstext.Text} added successfully into the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadSymptom();
                    }
                    else
                    {
                        MainClass.showMessage("Failed to save the record. Please try again.", "Error");
                    }
                }
                else if (edit == 1) // For Update
                {
                    // Create parameter hashtable
                    Hashtable ht = new Hashtable();
                    ht.Add("@symtom", Symptomstext.Text);
                    ht.Add("@sid", SymptomsID);

                    Console.WriteLine("Performing Save Operation");
                    if (CrudClass.data_insert_update__delete("st_updateSymtom", ht) > 0)
                    {
                        MainClass.showMessage($"{Symptomstext.Text} updated successfully into the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadSymptom();
                    }
                    else
                    {
                        MainClass.showMessage("Failed to updated the record. Please try again.", "Error");
                    }
                }
            }
        }

        public override void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@sid", SymptomsID);

                    if (CrudClass.data_insert_update__delete("st_deleteSymtom", ht) > 0)
                    {
                        MainClass.showMessage(Symptomstext.Text + "delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadSymptom();
                    }
                }
            }
        }
        public override void Search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SymptomsID = Convert.ToInt32(row.Cells["symptomIDGV"].Value.ToString());
                Symptomstext.Text = row.Cells["SymtomsGV"].Value.ToString();
            }
        }

        private void SympBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }
    }
}
