using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CRUD;

namespace Clinic_Managment_System
{
    public partial class RoleWindow : Sample2
    {
        public RoleWindow()
        {
            InitializeComponent();
        }

        private void RoleWindow_Load(object sender, EventArgs e)
        {

        }
        int roleID;
        private void LoadRoles()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(roleIDGV);
            LoadDa.Items.Add(RoleGV);
            CrudClass.LoadData("st_getRoles", dataGridView1, LoadDa);  
        }

     public override void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var invalidFields = MainClass.checkcontrols(Left_panel);
                if (invalidFields.Count > 0)
                {
                    MainClass.showMessage("Fields highlighted in red are mandatory.", "Error");
                    return;
                }

                Hashtable ht = new Hashtable();
                ht.Add("@Rolename", Role_textBox.Text?.Trim());
                if (edit == 0)
                {
                    Console.WriteLine("Performing Save Operation");
                    if (CrudClass.data_insert_update__delete("st_insertRoles", ht) > 0)
                    {
                        MainClass.showMessage($"{Role_textBox.Text} added successfully into the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadRoles();
                    }
                    else
                    {
                        MainClass.showMessage("Failed to save the record. Please try again.", "Error");
                    }
                }
                else if (edit == 1)
                {
                    Console.WriteLine("Performing Update Operation");
                    ht.Add("@id", roleID);
                    if (CrudClass.data_insert_update__delete("st_updateRoles", ht) > 0)
                    {
                        MainClass.showMessage($"{Role_textBox.Text} updated successfully in the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadRoles();
                    }
                    else
                    {
                        MainClass.showMessage("Failed to update the record. Please try again.", "Error");
                    }
                }
                else
                {
                    MainClass.showMessage("Invalid operation mode. Please check your code.", "Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                MainClass.showMessage($"An error occurred: {ex.Message}. Please contact support.", "Error");
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
                    ht.Add("@id", roleID);

                    if (CrudClass.data_insert_update__delete("st_deleteRoles", ht) > 0)
                    {
                        MainClass.showMessage(Role_textBox.Text+ "delete successfully from the system.", "success");
                        MainClass.resetDisable(Left_panel);
                        LoadRoles();
                    }
                }
            }
        }
        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }
        private void Role_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Role_textBox.Text == "")
            {
                Role_textBox.BackColor = Color.Firebrick;
            }
            else
            {
                Role_textBox.BackColor= Color.White;
            }
        }

        private void Dept_textBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) 
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                Role_textBox.Text = row.Cells["RoleGV"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }
    }
}
