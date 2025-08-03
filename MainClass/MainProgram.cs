using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Clinic_Managment_System
{
    public class MainClass
    {
        
        public static int LoggedInUserID;
        public static string LoggedInUserRole;

        public static void ApplyRoundedStyle(Button btn, int radius = 30, int borderWidth = 2, Color? borderColor = null)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;

            btn.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle bounds = new Rectangle(0, 0, btn.Width, btn.Height);
                GraphicsPath path = new GraphicsPath();

                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Top Left
                path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Top Right
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Bottom Right
                path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Bottom Left
                path.CloseFigure();

                btn.Region = new Region(path);

                using (Pen pen = new Pen(borderColor ?? Color.Black, borderWidth))
                {
                    g.DrawPath(pen, path);
                }
            };
        }
        public static void sno(DataGridView gv, string snoGV)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }
        private static string connectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CMS_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }
        public static SqlConnection con = new SqlConnection(connectionString());
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showMessage(string msg, string type)
        {
            if (type == "Success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "Error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void resetEnable(GroupBox p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    if (db.TabStop == false)
                    {

                    }
                    else
                    {
                        db.SelectedIndex = -1;
                        db.Enabled = true;
                        db.BackColor = Color.White;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Checked = false;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }

                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }

                }

                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = true;
                }
            }
        }
        public static void resetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false) 
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }
                    
                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    if (db.TabStop == false)
                    {

                    }
                    else
                    {
                        db.SelectedIndex = -1;
                        db.Enabled = true;
                        db.BackColor = Color.White;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Checked = false;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }
                    
                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                    
                }

                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = true;
                }
            }
        }
        public static void resetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    db.SelectedIndex = -1;
                    db.Enabled = false;
                    db.BackColor = Color.White;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                    rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                    cb.Value = 0;
                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }


                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false;
                }
            }
        }
        public static void EnableControls(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    if (db.TabStop == false)
                    {

                    }
                    else
                    {
                        db.Enabled = true;
                        db.BackColor = Color.White;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }

                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }

                }

                if (c is DateTimePicker)
                {
                    DateTimePicker dt = new DateTimePicker();
                    if (dt.TabStop == false)
                    {

                    }
                    else
                    {
                        dt.Enabled = true;
                    }
                }
            }
        }
        public static void DisableControls(Panel P)

        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false; 
                }
            }
        }
        public static ArrayList checkcontrols(Panel P)
        {
            ArrayList arr = new ArrayList();

            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                        cb.BackColor = cb.SelectedIndex == -1 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if (arr.Contains(rb))
                        {
                            arr.Remove(rb);
                        }
                    }
                    rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.Value == 0)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = cb.Value == 0 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                /*if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.AllowDrop == true)
                    {
                        arr.Add(dt);
                    }
                    else
                    {
                        if (dt.Value < DateTime.Today)
                        {
                            if (arr.Contains(dt))
                            {
                                arr.Remove(dt);
                            }
                        }
                        dt.BackColor = dt.Value <DateTime.Today ? dt.BackColor = Color.Firebrick : dt.BackColor = Color.White;

                    }
                }*/
            }
            return arr;
        }

        ////////////////////////////////////////////////////////

        public static void resetEnable(FlowLayoutPanel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;
                    tb.BackColor = Color.White;
                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    db.SelectedIndex = -1;
                    db.Enabled = true;
                    db.BackColor = Color.White;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                    rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                    cb.Value = 0;
                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }
        public static void resetDisable(FlowLayoutPanel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }

                if (c is ComboBox)
                {
                    ComboBox db = (ComboBox)c;
                    db.SelectedIndex = -1;
                    db.Enabled = false;
                    db.BackColor = Color.White;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                    rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                    cb.Value = 0;
                }

                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
            }
        }
        public static void EnableControls(FlowLayoutPanel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                }
            }
        }
        public static void DisableControls(FlowLayoutPanel P)

        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                }
            }
        }
        public static ArrayList checkcontrols(FlowLayoutPanel P)
        {
            ArrayList arr = new ArrayList();
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                        cb.BackColor = cb.SelectedIndex == -1 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if (arr.Contains(rb))
                        {
                            arr.Remove(rb);
                        }
                    }
                    rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.Value == 0)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = cb.Value == 0 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
            }
            return arr;
        }
    }
}