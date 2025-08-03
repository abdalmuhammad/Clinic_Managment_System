namespace Clinic_Managment_System
{
    partial class PatientRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AppointmentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.AppointForcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastAppointdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ConsltedtextBox = new System.Windows.Forms.TextBox();
            this.StatustextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointdateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatRegisBackBtn = new System.Windows.Forms.Button();
            this.DetailgroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.backbtn_panel1.SuspendLayout();
            this.heading_Panel.SuspendLayout();
            this.Fill_Panel.SuspendLayout();
            this.Left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailgroupBox
            // 
            this.DetailgroupBox.Controls.Add(this.dataGridView1);
            this.DetailgroupBox.Size = new System.Drawing.Size(772, 566);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 708);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.PatRegisBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(792, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1034, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 655);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 688);
            this.Bottompanel.Size = new System.Drawing.Size(772, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(772, 635);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.AgetextBox);
            this.Left_panel.Controls.Add(this.AgeLabel);
            this.Left_panel.Controls.Add(this.StatustextBox);
            this.Left_panel.Controls.Add(this.label10);
            this.Left_panel.Controls.Add(this.ConsltedtextBox);
            this.Left_panel.Controls.Add(this.label9);
            this.Left_panel.Controls.Add(this.LastAppointdateTimePicker);
            this.Left_panel.Controls.Add(this.label8);
            this.Left_panel.Controls.Add(this.label7);
            this.Left_panel.Controls.Add(this.AppointForcomboBox);
            this.Left_panel.Controls.Add(this.label6);
            this.Left_panel.Controls.Add(this.AppointmentdateTimePicker);
            this.Left_panel.Controls.Add(this.label5);
            this.Left_panel.Controls.Add(this.GendercomboBox);
            this.Left_panel.Controls.Add(this.label4);
            this.Left_panel.Controls.Add(this.PatientText);
            this.Left_panel.Controls.Add(this.label3);
            this.Left_panel.Controls.Add(this.PhoneText);
            this.Left_panel.Controls.Add(this.label2);
            this.Left_panel.Size = new System.Drawing.Size(262, 655);
            this.Left_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Left_panel_Paint);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(655, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // PhoneText
            // 
            this.PhoneText.Enabled = false;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(15, 88);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(232, 24);
            this.PhoneText.TabIndex = 1;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            this.PhoneText.Leave += new System.EventHandler(this.PhoneText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient";
            // 
            // PatientText
            // 
            this.PatientText.Enabled = false;
            this.PatientText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientText.Location = new System.Drawing.Point(15, 138);
            this.PatientText.Name = "PatientText";
            this.PatientText.Size = new System.Drawing.Size(232, 24);
            this.PatientText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.Enabled = false;
            this.GendercomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GendercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(15, 189);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(232, 26);
            this.GendercomboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appointment Date ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AppointmentdateTimePicker
            // 
            this.AppointmentdateTimePicker.CustomFormat = "dd-MMM-yyyy hh:mm tt";
            this.AppointmentdateTimePicker.Enabled = false;
            this.AppointmentdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentdateTimePicker.Location = new System.Drawing.Point(15, 291);
            this.AppointmentdateTimePicker.Name = "AppointmentdateTimePicker";
            this.AppointmentdateTimePicker.ShowUpDown = true;
            this.AppointmentdateTimePicker.Size = new System.Drawing.Size(232, 24);
            this.AppointmentdateTimePicker.TabIndex = 10;
            this.AppointmentdateTimePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            this.AppointmentdateTimePicker.ValueChanged += new System.EventHandler(this.AppointmentdateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Appointment for";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AppointForcomboBox
            // 
            this.AppointForcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppointForcomboBox.Enabled = false;
            this.AppointForcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppointForcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointForcomboBox.FormattingEnabled = true;
            this.AppointForcomboBox.Location = new System.Drawing.Point(15, 342);
            this.AppointForcomboBox.Name = "AppointForcomboBox";
            this.AppointForcomboBox.Size = new System.Drawing.Size(232, 26);
            this.AppointForcomboBox.TabIndex = 9;
            this.AppointForcomboBox.SelectedIndexChanged += new System.EventHandler(this.AppointForcomboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Patient History";
            // 
            // LastAppointdateTimePicker
            // 
            this.LastAppointdateTimePicker.AllowDrop = true;
            this.LastAppointdateTimePicker.Enabled = false;
            this.LastAppointdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastAppointdateTimePicker.Location = new System.Drawing.Point(15, 475);
            this.LastAppointdateTimePicker.Name = "LastAppointdateTimePicker";
            this.LastAppointdateTimePicker.Size = new System.Drawing.Size(232, 24);
            this.LastAppointdateTimePicker.TabIndex = 12;
            this.LastAppointdateTimePicker.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Last Appointment Date ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Consulted to";
            // 
            // ConsltedtextBox
            // 
            this.ConsltedtextBox.AllowDrop = true;
            this.ConsltedtextBox.Enabled = false;
            this.ConsltedtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsltedtextBox.Location = new System.Drawing.Point(15, 529);
            this.ConsltedtextBox.Name = "ConsltedtextBox";
            this.ConsltedtextBox.Size = new System.Drawing.Size(232, 24);
            this.ConsltedtextBox.TabIndex = 14;
            this.ConsltedtextBox.TabStop = false;
            // 
            // StatustextBox
            // 
            this.StatustextBox.AllowDrop = true;
            this.StatustextBox.Enabled = false;
            this.StatustextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatustextBox.Location = new System.Drawing.Point(15, 580);
            this.StatustextBox.Name = "StatustextBox";
            this.StatustextBox.Size = new System.Drawing.Size(232, 24);
            this.StatustextBox.TabIndex = 16;
            this.StatustextBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Status";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Enabled = false;
            this.AgetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgetextBox.Location = new System.Drawing.Point(15, 241);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(232, 24);
            this.AgetextBox.TabIndex = 18;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(13, 220);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(32, 17);
            this.AgeLabel.TabIndex = 17;
            this.AgeLabel.Text = "Age";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.patientGV,
            this.genderGV,
            this.ageGV,
            this.phoneGV,
            this.appointdateGV,
            this.DoctorGV,
            this.doctorIDGV,
            this.AppIDGV,
            this.statusGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(766, 547);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 44;
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
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // appointdateGV
            // 
            this.appointdateGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointdateGV.HeaderText = "Appointment For";
            this.appointdateGV.Name = "appointdateGV";
            this.appointdateGV.ReadOnly = true;
            // 
            // DoctorGV
            // 
            this.DoctorGV.HeaderText = "Doctor";
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.ReadOnly = true;
            // 
            // doctorIDGV
            // 
            this.doctorIDGV.HeaderText = "Doctor ID";
            this.doctorIDGV.Name = "doctorIDGV";
            this.doctorIDGV.ReadOnly = true;
            this.doctorIDGV.Visible = false;
            // 
            // AppIDGV
            // 
            this.AppIDGV.HeaderText = "AppID";
            this.AppIDGV.Name = "AppIDGV";
            this.AppIDGV.ReadOnly = true;
            this.AppIDGV.Visible = false;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // PatRegisBackBtn
            // 
            this.PatRegisBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.PatRegisBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatRegisBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.PatRegisBackBtn.FlatAppearance.BorderSize = 0;
            this.PatRegisBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatRegisBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.PatRegisBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatRegisBackBtn.Location = new System.Drawing.Point(0, 0);
            this.PatRegisBackBtn.Name = "PatRegisBackBtn";
            this.PatRegisBackBtn.Size = new System.Drawing.Size(43, 53);
            this.PatRegisBackBtn.TabIndex = 5;
            this.PatRegisBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PatRegisBackBtn.UseVisualStyleBackColor = false;
            this.PatRegisBackBtn.Click += new System.EventHandler(this.PatRegisBackBtn_Click);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 708);
            this.Name = "PatientRegistration";
            this.Text = "PatientRegistration";
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            this.DetailgroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.backbtn_panel1.ResumeLayout(false);
            this.heading_Panel.ResumeLayout(false);
            this.Fill_Panel.ResumeLayout(false);
            this.Left_panel.ResumeLayout(false);
            this.Left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AppointForcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker AppointmentdateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker LastAppointdateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StatustextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ConsltedtextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button PatRegisBackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointdateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}