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
    public partial class MedicinesWindow : Sample2
    {
        public MedicinesWindow()
        {
            InitializeComponent();
        }
        private void LoadMedicine()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(mediIDGV);
            LoadDa.Items.Add(medicineGV);
            LoadDa.Items.Add(CompanyGV);
            LoadDa.Items.Add(DosageGV);
            LoadDa.Items.Add(CategoryGV);
            LoadDa.Items.Add(TypeGV);
            CrudClass.LoadData("st_getMedicine", dataGridView1, LoadDa);
        }

        int medID = 0;
        public override void Save_Btn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkcontrols(Left_panel).Count > 0)
            {
               MainClass.showMessage("fields with red are mandatory. ", "Error");
            }
            else
            {
                if (edit == 0) //code for save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@Medicinename",MedicineText.Text);
                    if (CompanyText.Text == "")
                    {
                        ht.Add("@Compname", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@Compname", CompanyText.Text);
                    }
                    ht.Add("@Dosage", DosagecomboBox.SelectedItem?.ToString());
                    ht.Add("@Category", CategorycomboBox.SelectedItem);

                    ht.Add("@Type", TypecomboBox.SelectedIndex);

                    if (CrudClass.data_insert_update__delete("st_insertMedicine", ht) > 0)
                    {
                        MainClass.showMessage(MedicineText.Text + "added successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadMedicine();
                    }
                    else
                    {
                        MainClass.showMessage("unable to save record.", "Error");
                    }

                }

                else if (edit == 1) // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@Medicinename", MedicineText.Text);
                    if (CompanyText.Text == "")
                    {
                        ht.Add("@Compname", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@Compname", CompanyText.Text);
                    }
                    ht.Add("@Dosage", DosagecomboBox.SelectedItem);
                    ht.Add("@Category", CategorycomboBox.SelectedItem);

                    /*ht.Add("@Dosage", DosagecomboBox.SelectedIndex);
                    ht.Add("@Category", CategorycomboBox.SelectedIndex);*/
                    ht.Add("@Type", TypecomboBox.SelectedIndex);
                    ht.Add("@id", medID);

                    if (CrudClass.data_insert_update__delete("st_updateMedicine", ht) > 0)
                    {
                        MainClass.showMessage(MedicineText.Text + " added successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadMedicine();
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
                    ht.Add("@id", medID);

                    if (CrudClass.data_insert_update__delete("st_deleteMedicine", ht) > 0)
                    {
                        MainClass.showMessage(MedicineText.Text + "delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadMedicine();
                    }
                }
           
            }
        }

        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadMedicine();
        }

        private void MedicinesWindow_Load(object sender, EventArgs e)
        {

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Left_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicineText_TextChanged(object sender, EventArgs e)
        {
            if (MedicineText.Text == "") {MedicineText.BackColor = Color.Firebrick; }
            else { MedicineText.BackColor = Color.White; }
        }

        private void DosagecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DosagecomboBox.SelectedIndex == -1) { DosagecomboBox.BackColor = Color.Firebrick; }
            else { DosagecomboBox.BackColor = Color.White; }
        }

        private void CategorycomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CategorycomboBox.SelectedIndex == -1) { CategorycomboBox.BackColor = Color.Firebrick; }
            else { CategorycomboBox.BackColor = Color.White; }
        }

        private void TypecomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TypecomboBox.SelectedIndex == -1) { TypecomboBox.BackColor = Color.Firebrick; }
            else { TypecomboBox.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                medID = Convert.ToInt32(row.Cells["mediIDGV"].Value.ToString());
                MedicineText.Text = row.Cells["medicineGV"].Value.ToString();
                CompanyText.Text = row.Cells["CompanyGV"].Value.ToString();
                DosagecomboBox.SelectedItem = row.Cells["DosageGV"].Value.ToString();
                CategorycomboBox.SelectedItem = row.Cells["CategoryGV"].Value.ToString();
                TypecomboBox.SelectedItem = row.Cells["TypeGV"].Value.ToString();
            }
        }

        private void DiseaseBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
