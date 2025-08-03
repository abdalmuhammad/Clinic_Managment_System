using CRUD;
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class Testwindow : Sample2
    {
        public Testwindow()
        {
            InitializeComponent();
        }

        private void LoadTest()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(testIDGV);
            LoadDa.Items.Add(TestScanXrayGV);
            LoadDa.Items.Add(PriceGV);
            LoadDa.Items.Add(PrecautionsGV);
            CrudClass.LoadData("st_getTests", dataGridView1, LoadDa);
        }

        int TestID = 0;
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
                    ht.Add("@name", TestNameText.Text);
                    ht.Add("@price", Convert.ToDecimal(PriceText.Text));
                    ht.Add("@prec", PrecautionsTB.Text);

                    if (CrudClass.data_insert_update__delete("st_insertTests", ht) > 0)
                    {
                        MainClass.showMessage(TestNameText.Text + "added successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadTest();
                    }
                    else
                    {
                        MainClass.showMessage("unable to save record.", "Error");
                    }

                }

                else if (edit == 1) // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", TestNameText.Text);
                    ht.Add("@price", Convert.ToDecimal(PriceText.Text));
                    ht.Add("@prec", PrecautionsTB.Text);
                    ht.Add("@id", TestID);

                    if (CrudClass.data_insert_update__delete("st_updateTests", ht) > 0)
                    {
                        MainClass.showMessage(TestNameText.Text + "update successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadTest();
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
                    ht.Add("@id", TestID);

                    if (CrudClass.data_insert_update__delete("st_deleteMedicine", ht) > 0)
                    {
                        MainClass.showMessage(TestNameText.Text + "delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadTest();
                    }
                }

            }
        }

        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadTest();
        }
        private void Testwindow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TestID = Convert.ToInt32(row.Cells["testIDGV"].Value.ToString());
                TestNameText.Text = row.Cells["TestScanXrayGV"].Value.ToString();
                PriceText.Text = Math.Round(Convert.ToDouble(row.Cells["PriceGV"].Value.ToString()),0).ToString();
                PrecautionsTB.Text = row.Cells["PrecautionsGV"].Value.ToString();
            }
        }

        private void TestNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecautionsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }
    }
}
