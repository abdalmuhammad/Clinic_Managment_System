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
    public partial class Diseases : Sample2
    {
        public Diseases()
        {
            InitializeComponent();
        }
        private void Diseases_Load(object sender, EventArgs e)
        {

        }
        private void LoadDisease()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(DiseasesIDGV);
            LoadDa.Items.Add(DiseasesGV);
            CrudClass.LoadData("st_getDiseases", dataGridView1, LoadDa);
        }
        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadDisease();
        }

        int DiseaseID;
        public override void Save_Btn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkcontrols(Left_panel).Count>0)
            {
                MainClass.showMessage("Fields highlighted in red are mandatory.", "Error");
            }
            else
            {
                if (edit == 0) // For Save
                {
                    // Create parameter hashtable
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", DiseasestextBox.Text);

                    Console.WriteLine("Performing Save Operation");
                    if (CrudClass.data_insert_update__delete("st_insertDisease", ht) > 0)
                    {
                        MainClass.showMessage($"{DiseasestextBox.Text} added successfully into the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadDisease();
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
                    ht.Add("@disease", DiseasestextBox.Text);
                    ht.Add("@did", DiseaseID);


                    Console.WriteLine("Performing Save Operation");
                    if (CrudClass.data_insert_update__delete("st_updateDisease", ht) > 0)
                    {
                        MainClass.showMessage($"{DiseasestextBox.Text} updated successfully into the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadDisease();
                    }
                    else
                    {
                        MainClass.showMessage("Failed to save the record. Please try again.", "Error");
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
                    ht.Add("@did", DiseaseID);

                    if (CrudClass.data_insert_update__delete("st_deleteDisease", ht) > 0)
                    {
                        MainClass.showMessage(DiseasestextBox.Text + "delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadDisease();
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
                DiseaseID = Convert.ToInt32(row.Cells["DiseasesIDGV"].Value.ToString());
                DiseasestextBox.Text = row.Cells["DiseasesGV"].Value.ToString();
            }
        }

        private void DiseaseBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }
    }
}
