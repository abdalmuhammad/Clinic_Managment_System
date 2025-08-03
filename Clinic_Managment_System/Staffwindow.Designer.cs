namespace Clinic_Managment_System
{
    partial class Staffwindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_ComboBox = new System.Windows.Forms.ComboBox();
            this.StaffWinBackBtn = new System.Windows.Forms.Button();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(784, 416);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 558);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.StaffWinBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(804, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1046, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 505);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 538);
            this.Bottompanel.Size = new System.Drawing.Size(784, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(784, 485);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.Role_ComboBox);
            this.Left_panel.Controls.Add(this.label7);
            this.Left_panel.Controls.Add(this.Address_textBox);
            this.Left_panel.Controls.Add(this.label5);
            this.Left_panel.Controls.Add(this.Phone_textBox);
            this.Left_panel.Controls.Add(this.label4);
            this.Left_panel.Controls.Add(this.Pass_textBox);
            this.Left_panel.Controls.Add(this.label3);
            this.Left_panel.Controls.Add(this.Username_textBox);
            this.Left_panel.Controls.Add(this.label2);
            this.Left_panel.Controls.Add(this.Name_textBox);
            this.Left_panel.Controls.Add(this.label1);
            this.Left_panel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Left_panel.Size = new System.Drawing.Size(262, 505);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(667, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Enabled = false;
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Name_textBox.Location = new System.Drawing.Point(15, 87);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(232, 24);
            this.Name_textBox.TabIndex = 1;
            this.Name_textBox.TextChanged += new System.EventHandler(this.Name_textBox_TextChanged);
            // 
            // Username_textBox
            // 
            this.Username_textBox.Enabled = false;
            this.Username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Username_textBox.Location = new System.Drawing.Point(15, 134);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(232, 24);
            this.Username_textBox.TabIndex = 3;
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Enabled = false;
            this.Pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Pass_textBox.Location = new System.Drawing.Point(15, 182);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '+';
            this.Pass_textBox.Size = new System.Drawing.Size(232, 24);
            this.Pass_textBox.TabIndex = 5;
            this.Pass_textBox.UseSystemPasswordChar = true;
            this.Pass_textBox.TextChanged += new System.EventHandler(this.Pass_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Enabled = false;
            this.Phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Phone_textBox.Location = new System.Drawing.Point(15, 230);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(232, 24);
            this.Phone_textBox.TabIndex = 7;
            this.Phone_textBox.TextChanged += new System.EventHandler(this.Phone_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Enabled = false;
            this.Address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Address_textBox.Location = new System.Drawing.Point(15, 278);
            this.Address_textBox.MaxLength = 150;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(232, 24);
            this.Address_textBox.TabIndex = 9;
            this.Address_textBox.TextChanged += new System.EventHandler(this.Address_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.userIDGV,
            this.nameGV,
            this.UsernameGV,
            this.PasswordGV,
            this.PhoneGV,
            this.addressGV,
            this.roleIDGV,
            this.RoleGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 48;
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.HeaderText = "Username";
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Password";
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "RoleID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            this.roleIDGV.Visible = false;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // Role_ComboBox
            // 
            this.Role_ComboBox.Enabled = false;
            this.Role_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Role_ComboBox.FormattingEnabled = true;
            this.Role_ComboBox.Location = new System.Drawing.Point(15, 323);
            this.Role_ComboBox.Name = "Role_ComboBox";
            this.Role_ComboBox.Size = new System.Drawing.Size(232, 26);
            this.Role_ComboBox.TabIndex = 15;
            this.Role_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Role_ComboBox_SelectedIndexChanged);
            // 
            // StaffWinBackBtn
            // 
            this.StaffWinBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.StaffWinBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffWinBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.StaffWinBackBtn.FlatAppearance.BorderSize = 0;
            this.StaffWinBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffWinBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.StaffWinBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffWinBackBtn.Location = new System.Drawing.Point(2, 0);
            this.StaffWinBackBtn.Name = "StaffWinBackBtn";
            this.StaffWinBackBtn.Size = new System.Drawing.Size(43, 53);
            this.StaffWinBackBtn.TabIndex = 5;
            this.StaffWinBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StaffWinBackBtn.UseVisualStyleBackColor = false;
            this.StaffWinBackBtn.Click += new System.EventHandler(this.StaffWinBackBtn_Click);
            // 
            // Staffwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 558);
            this.Name = "Staffwindow";
            this.Text = "StaffWindow";
            this.Load += new System.EventHandler(this.Staffwindow_Load_1);
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
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Role_ComboBox;
        protected System.Windows.Forms.Button StaffWinBackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
    }
}