namespace Clinic_Managment_System
{
    partial class SecondReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker_TO = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportHeaderpanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointdateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorRoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkupfeeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltestfeesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.View_Btn = new System.Windows.Forms.Button();
            this.filter_btn = new System.Windows.Forms.Button();
            this.Dwn_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.ReportHeaderpanel.SuspendLayout();
            this.DetailroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.View_Btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.filter_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePicker_TO, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePicker_From, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dwn_Btn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1329, 52);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // DateTimePicker_TO
            // 
            this.DateTimePicker_TO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_TO.Location = new System.Drawing.Point(268, 30);
            this.DateTimePicker_TO.Name = "DateTimePicker_TO";
            this.DateTimePicker_TO.Size = new System.Drawing.Size(259, 20);
            this.DateTimePicker_TO.TabIndex = 3;
            this.DateTimePicker_TO.ValueChanged += new System.EventHandler(this.DateTimePicker_TO_ValueChanged);
            // 
            // DateTimePicker_From
            // 
            this.DateTimePicker_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_From.Location = new System.Drawing.Point(3, 30);
            this.DateTimePicker_From.Name = "DateTimePicker_From";
            this.DateTimePicker_From.Size = new System.Drawing.Size(259, 20);
            this.DateTimePicker_From.TabIndex = 1;
            this.DateTimePicker_From.ValueChanged += new System.EventHandler(this.DateTimePicker_From_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // ReportHeaderpanel
            // 
            this.ReportHeaderpanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportHeaderpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReportHeaderpanel.Controls.Add(this.label4);
            this.ReportHeaderpanel.Controls.Add(this.textBox1);
            this.ReportHeaderpanel.Controls.Add(this.label1);
            this.ReportHeaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportHeaderpanel.ForeColor = System.Drawing.Color.White;
            this.ReportHeaderpanel.Location = new System.Drawing.Point(0, 52);
            this.ReportHeaderpanel.Name = "ReportHeaderpanel";
            this.ReportHeaderpanel.Size = new System.Drawing.Size(1329, 43);
            this.ReportHeaderpanel.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1105, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search.....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(543, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTED PATIENT\'S RECORD";
            // 
            // DetailroupBox
            // 
            this.DetailroupBox.Controls.Add(this.dataGridView1);
            this.DetailroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailroupBox.Location = new System.Drawing.Point(0, 95);
            this.DetailroupBox.Name = "DetailroupBox";
            this.DetailroupBox.Size = new System.Drawing.Size(1329, 426);
            this.DetailroupBox.TabIndex = 9;
            this.DetailroupBox.TabStop = false;
            this.DetailroupBox.Text = "Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.TurnGV,
            this.patientIDGV,
            this.AppIDGV,
            this.appointdateGV,
            this.patientGV,
            this.genderGV,
            this.ageGV,
            this.doctorIDGV,
            this.DoctorGV,
            this.DoctorRoleGV,
            this.checkupfeeGV,
            this.totaltestfeesGV,
            this.totalamountGV,
            this.statusGV,
            this.phoneGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1323, 407);
            this.dataGridView1.TabIndex = 2;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 41;
            // 
            // TurnGV
            // 
            this.TurnGV.HeaderText = "Turn";
            this.TurnGV.Name = "TurnGV";
            this.TurnGV.ReadOnly = true;
            // 
            // patientIDGV
            // 
            this.patientIDGV.HeaderText = "ID";
            this.patientIDGV.Name = "patientIDGV";
            this.patientIDGV.ReadOnly = true;
            this.patientIDGV.Visible = false;
            // 
            // AppIDGV
            // 
            this.AppIDGV.HeaderText = "AppID";
            this.AppIDGV.Name = "AppIDGV";
            this.AppIDGV.ReadOnly = true;
            this.AppIDGV.Visible = false;
            // 
            // appointdateGV
            // 
            this.appointdateGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointdateGV.HeaderText = "Appointment For";
            this.appointdateGV.Name = "appointdateGV";
            this.appointdateGV.ReadOnly = true;
            // 
            // patientGV
            // 
            this.patientGV.HeaderText = "Patient";
            this.patientGV.Name = "patientGV";
            this.patientGV.ReadOnly = true;
            // 
            // genderGV
            // 
            this.genderGV.HeaderText = "Gender";
            this.genderGV.Name = "genderGV";
            this.genderGV.ReadOnly = true;
            // 
            // ageGV
            // 
            this.ageGV.HeaderText = "Age";
            this.ageGV.Name = "ageGV";
            this.ageGV.ReadOnly = true;
            // 
            // doctorIDGV
            // 
            this.doctorIDGV.HeaderText = "Doctor ID";
            this.doctorIDGV.Name = "doctorIDGV";
            this.doctorIDGV.ReadOnly = true;
            this.doctorIDGV.Visible = false;
            // 
            // DoctorGV
            // 
            this.DoctorGV.HeaderText = "Doctor";
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.ReadOnly = true;
            // 
            // DoctorRoleGV
            // 
            this.DoctorRoleGV.HeaderText = "Doctor Role";
            this.DoctorRoleGV.Name = "DoctorRoleGV";
            this.DoctorRoleGV.ReadOnly = true;
            // 
            // checkupfeeGV
            // 
            this.checkupfeeGV.HeaderText = "Checkup Fees";
            this.checkupfeeGV.Name = "checkupfeeGV";
            this.checkupfeeGV.ReadOnly = true;
            // 
            // totaltestfeesGV
            // 
            this.totaltestfeesGV.HeaderText = "T.Test Fees";
            this.totaltestfeesGV.Name = "totaltestfeesGV";
            this.totaltestfeesGV.ReadOnly = true;
            // 
            // totalamountGV
            // 
            this.totalamountGV.HeaderText = "Total Amount";
            this.totalamountGV.Name = "totalamountGV";
            this.totalamountGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::Clinic_Managment_System.Properties.Resources.Search__1_;
            this.label4.Location = new System.Drawing.Point(1268, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = ".....";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View_Btn
            // 
            this.View_Btn.BackColor = System.Drawing.Color.Transparent;
            this.View_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.View_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.View_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Btn.Image = global::Clinic_Managment_System.Properties.Resources.ALDATA2;
            this.View_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.View_Btn.Location = new System.Drawing.Point(798, 3);
            this.View_Btn.Name = "View_Btn";
            this.View_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.tableLayoutPanel1.SetRowSpan(this.View_Btn, 2);
            this.View_Btn.Size = new System.Drawing.Size(259, 46);
            this.View_Btn.TabIndex = 13;
            this.View_Btn.Text = "&View All";
            this.View_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View_Btn.UseVisualStyleBackColor = false;
            this.View_Btn.Click += new System.EventHandler(this.View_Btn_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.Transparent;
            this.filter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filter_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.filter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_btn.Image = global::Clinic_Managment_System.Properties.Resources.filter3;
            this.filter_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filter_btn.Location = new System.Drawing.Point(533, 3);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.tableLayoutPanel1.SetRowSpan(this.filter_btn, 2);
            this.filter_btn.Size = new System.Drawing.Size(259, 46);
            this.filter_btn.TabIndex = 12;
            this.filter_btn.Text = "&Filter";
            this.filter_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filter_btn.UseVisualStyleBackColor = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // Dwn_Btn
            // 
            this.Dwn_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Dwn_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dwn_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dwn_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dwn_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.Dwn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dwn_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dwn_Btn.Image = global::Clinic_Managment_System.Properties.Resources.Menu1;
            this.Dwn_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dwn_Btn.Location = new System.Drawing.Point(1063, 3);
            this.Dwn_Btn.Name = "Dwn_Btn";
            this.Dwn_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.tableLayoutPanel1.SetRowSpan(this.Dwn_Btn, 2);
            this.Dwn_Btn.Size = new System.Drawing.Size(263, 46);
            this.Dwn_Btn.TabIndex = 10;
            this.Dwn_Btn.Text = "&Action";
            this.Dwn_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dwn_Btn.UseVisualStyleBackColor = false;
            this.Dwn_Btn.Click += new System.EventHandler(this.Dwn_Btn_Click);
            // 
            // SecondReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 521);
            this.Controls.Add(this.DetailroupBox);
            this.Controls.Add(this.ReportHeaderpanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondReport";
            this.Text = "SecondReport";
            this.Load += new System.EventHandler(this.SecondReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ReportHeaderpanel.ResumeLayout(false);
            this.ReportHeaderpanel.PerformLayout();
            this.DetailroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button View_Btn;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimePicker_TO;
        private System.Windows.Forms.DateTimePicker DateTimePicker_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dwn_Btn;
        private System.Windows.Forms.Panel ReportHeaderpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DetailroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointdateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorRoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkupfeeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltestfeesGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}