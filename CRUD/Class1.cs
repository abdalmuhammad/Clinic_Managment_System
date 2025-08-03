using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Managment_System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace CRUD
{
    public class CrudClass
    {
        public static DataTable getDataTable(string proc, Hashtable ht)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(proc, MainClass.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MainClass.showMessage("Data loading error: " + ex.Message, "Error");
            }
            return dt;
        }
        public static object getLastId(string proc)
        {
            object O = null;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                O = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
            return O;
        }

        // 2 para meters  pass 
        public static object getLastId(string proc, Hashtable ht)
        {
            object O = null;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                MainClass.con.Open();
                O = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
            return O;
        }

        public static void loadList(string proc, ComboBox cb, String ValueMember, String DisplayMember, Hashtable ht = null)
        {
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
                cb.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }

        public static bool checkExistance(string proc, Hashtable ht)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                MainClass.con.Open();
                object result = cmd.ExecuteScalar(); 
                MainClass.con.Close();

                check = (result != null && Convert.ToInt32(result) > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking existence: " + ex.Message);
                MainClass.con.Close();
            }
            return check;
        }

        public static int getTurnNumber(string proc, Hashtable ht)
        {
            int turnNo = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                turnNo = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
            return turnNo;
        }

        public static int data_insert_update__delete(string proc, Hashtable ht)
        {
            int res = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(proc, MainClass.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    MainClass.con.Open();
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MainClass.showMessage("Database operation failed: " + ex.Message, "Error");
            }
            finally
            {
                // Ensure the connection is closed
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }
            }

            return res;
        }
        public static void LoadData(string proc, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 4 parameter Pass in this class
        public static void LoadData(string proc, DataGridView gv, ListBox lb, Hashtable ht)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);    
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
