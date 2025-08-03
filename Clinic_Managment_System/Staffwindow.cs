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
    public partial class Staffwindow : Sample2
    {
        public Staffwindow()
        {
            InitializeComponent();
        }
        private void LoadUser()
        {
            ListBox LoadDa = new ListBox();
            LoadDa.Items.Add(userIDGV);
            LoadDa.Items.Add(nameGV);
            LoadDa.Items.Add(UsernameGV);
            LoadDa.Items.Add(PasswordGV);
            LoadDa.Items.Add(PhoneGV);
            LoadDa.Items.Add(addressGV);
            LoadDa.Items.Add(roleIDGV);
            LoadDa.Items.Add(RoleGV);
            CrudClass.LoadData("st_getUsers", dataGridView1, LoadDa);
        }

        private void Staffwindow_Load_1(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            CrudClass.loadList("st_getRoles", Role_ComboBox, "ID", "Role", ht); 
        }
        private void Staffwindow_Load(object sender, EventArgs e)
        {

        }
        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {
            if(Name_textBox.Text == "") { Name_textBox.BackColor = Color.Firebrick; }
            else { Name_textBox.BackColor = Color.White;}
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_textBox.Text == "") { Name_textBox.BackColor = Color.Firebrick; }
            else { Name_textBox.BackColor = Color.White; }
        }

        private void Pass_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_textBox.Text == "") { Name_textBox.BackColor = Color.Firebrick; }
            else { Name_textBox.BackColor = Color.White; }
        }

        private void Phone_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Phone_textBox.Text == "") { Phone_textBox.BackColor = Color.Firebrick; }
            else { Phone_textBox.BackColor = Color.White; }
        }

        private void Address_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Address_textBox.Text == "") { Address_textBox.BackColor = Color.Firebrick; }
            else { Address_textBox.BackColor = Color.White; }
        }
        private void Role_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role_ComboBox.SelectedIndex == -1) { Role_ComboBox.BackColor = Color.Firebrick; }
            else { Role_ComboBox.BackColor = Color.White; }
        }

        int UserID = 0;
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
                    ht.Add("@name", Name_textBox.Text);
                    ht.Add("@uname", Username_textBox.Text);
                    ht.Add("@password", Pass_textBox.Text);
                    ht.Add("@phone", Phone_textBox.Text);
                    ht.Add("@address", Address_textBox.Text);
                    ht.Add("@roleID", Convert.ToInt32(Role_ComboBox.SelectedValue.ToString()));

                    if (CrudClass.data_insert_update__delete("st_insertUsers", ht) > 0)
                    {
                        MainClass.showMessage(Name_textBox.Text + "added successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadUser();
                    }
                    else
                    {
                        MainClass.showMessage("unable to save record.", "Error");
                    }

                }

                else if (edit == 1) // code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", Name_textBox.Text);
                    ht.Add("@uname", Username_textBox.Text);
                    ht.Add("@password", Pass_textBox.Text);
                    ht.Add("@phone", Phone_textBox.Text);
                    ht.Add("@address", Address_textBox.Text);
                    ht.Add("@roleID", Convert.ToInt32(Role_ComboBox.SelectedValue.ToString()));
                    ht.Add("@id", UserID);

                    if (CrudClass.data_insert_update__delete("st_updatedUsers", ht) > 0)
                    {
                        MainClass.showMessage(Name_textBox.Text + " updated successfully into system", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadUser();
                    }

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
                    ht.Add("@id", UserID);

                    if (CrudClass.data_insert_update__delete("st_deleteUser", ht) > 0)
                    {
                        MainClass.showMessage(Name_textBox.Text + "delete successfully from the system.", "Success");
                        MainClass.resetDisable(Left_panel);
                        LoadUser();
                    }
                }
            }
        }
        public override void View_Btn_Click(object sender, EventArgs e)
        {
            LoadUser();
        }
        private void da(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClicks(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["useridgv"].Value.ToString());
                Name_textBox.Text = row.Cells["namegv"].Value.ToString();
                Username_textBox.Text = row.Cells["namegv"].Value.ToString();
                Phone_textBox.Text = row.Cells["namegv"].Value.ToString();
                Address_textBox.Text = row.Cells["namegv"].Value.ToString();
                Pass_textBox.Text = row.Cells["namegv"].Value.ToString();
                Role_ComboBox.SelectedValue = row.Cells["roleidgv"].Value.ToString();
            }
        }

        private void StaffWinBackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(Left_panel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                Name_textBox.Text = row.Cells["nameGV"].Value.ToString();
                Username_textBox.Text = row.Cells["UsernameGV"].Value.ToString();
                Pass_textBox.Text = row.Cells["PasswordGV"].Value.ToString();
                Phone_textBox.Text = row.Cells["PhoneGV"].Value.ToString();
                Address_textBox.Text = row.Cells["addressGV"].Value.ToString();
                Role_ComboBox.Text = row.Cells["RoleGV"].Value.ToString();
            }
        }
    }
}
