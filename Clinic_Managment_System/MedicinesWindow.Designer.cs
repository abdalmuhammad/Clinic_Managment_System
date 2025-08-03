namespace Clinic_Managment_System
{
    partial class MedicinesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicineText = new System.Windows.Forms.TextBox();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DosagecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseBackBtn = new System.Windows.Forms.Button();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(777, 308);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 450);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.DiseaseBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(797, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1039, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 397);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 430);
            this.Bottompanel.Size = new System.Drawing.Size(777, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(777, 377);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.TypecomboBox);
            this.Left_panel.Controls.Add(this.label6);
            this.Left_panel.Controls.Add(this.CategorycomboBox);
            this.Left_panel.Controls.Add(this.label5);
            this.Left_panel.Controls.Add(this.DosagecomboBox);
            this.Left_panel.Controls.Add(this.label4);
            this.Left_panel.Controls.Add(this.CompanyText);
            this.Left_panel.Controls.Add(this.label3);
            this.Left_panel.Controls.Add(this.MedicineText);
            this.Left_panel.Controls.Add(this.label2);
            this.Left_panel.Size = new System.Drawing.Size(262, 397);
            this.Left_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Left_panel_Paint);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(660, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicine";
            // 
            // MedicineText
            // 
            this.MedicineText.Enabled = false;
            this.MedicineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MedicineText.Location = new System.Drawing.Point(15, 88);
            this.MedicineText.MaxLength = 80;
            this.MedicineText.Name = "MedicineText";
            this.MedicineText.Size = new System.Drawing.Size(227, 24);
            this.MedicineText.TabIndex = 1;
            this.MedicineText.TextChanged += new System.EventHandler(this.MedicineText_TextChanged);
            // 
            // CompanyText
            // 
            this.CompanyText.Enabled = false;
            this.CompanyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CompanyText.Location = new System.Drawing.Point(15, 141);
            this.CompanyText.MaxLength = 80;
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(227, 24);
            this.CompanyText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company";
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.AllowDrop = true;
            this.CategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorycomboBox.Enabled = false;
            this.CategorycomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CategorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Syrup",
            "Injection",
            "Ointment",
            "Powder",
            "Drops",
            "Lozenges"});
            this.CategorycomboBox.Location = new System.Drawing.Point(15, 246);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(227, 26);
            this.CategorycomboBox.TabIndex = 11;
            this.CategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.CategorycomboBox_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category";
            // 
            // DosagecomboBox
            // 
            this.DosagecomboBox.AllowDrop = true;
            this.DosagecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DosagecomboBox.Enabled = false;
            this.DosagecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DosagecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DosagecomboBox.FormattingEnabled = true;
            this.DosagecomboBox.Items.AddRange(new object[] {
            "0 mg",
            "25 mg",
            "50 mg",
            "200 mg",
            "1 ml",
            "2.5 ml",
            "150 ml",
            "200 ml"});
            this.DosagecomboBox.Location = new System.Drawing.Point(15, 193);
            this.DosagecomboBox.Name = "DosagecomboBox";
            this.DosagecomboBox.Size = new System.Drawing.Size(227, 26);
            this.DosagecomboBox.TabIndex = 9;
            this.DosagecomboBox.SelectedIndexChanged += new System.EventHandler(this.DosagecomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dosage Strength";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.AllowDrop = true;
            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypecomboBox.Enabled = false;
            this.TypecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.TypecomboBox.Location = new System.Drawing.Point(14, 300);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(227, 26);
            this.TypecomboBox.TabIndex = 15;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Type";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.mediIDGV,
            this.medicineGV,
            this.CompanyGV,
            this.DosageGV,
            this.CategoryGV,
            this.TypeGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 289);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 44;
            // 
            // mediIDGV
            // 
            this.mediIDGV.HeaderText = "MediID";
            this.mediIDGV.Name = "mediIDGV";
            this.mediIDGV.ReadOnly = true;
            this.mediIDGV.Visible = false;
            // 
            // medicineGV
            // 
            this.medicineGV.HeaderText = "Medicine";
            this.medicineGV.Name = "medicineGV";
            this.medicineGV.ReadOnly = true;
            // 
            // CompanyGV
            // 
            this.CompanyGV.HeaderText = "Company";
            this.CompanyGV.Name = "CompanyGV";
            this.CompanyGV.ReadOnly = true;
            // 
            // DosageGV
            // 
            this.DosageGV.HeaderText = "Dosage Strength";
            this.DosageGV.Name = "DosageGV";
            this.DosageGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            this.CategoryGV.HeaderText = "Category";
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.ReadOnly = true;
            // 
            // TypeGV
            // 
            this.TypeGV.HeaderText = "Type";
            this.TypeGV.Name = "TypeGV";
            this.TypeGV.ReadOnly = true;
            // 
            // DiseaseBackBtn
            // 
            this.DiseaseBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.DiseaseBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiseaseBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.DiseaseBackBtn.FlatAppearance.BorderSize = 0;
            this.DiseaseBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiseaseBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.DiseaseBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiseaseBackBtn.Location = new System.Drawing.Point(-1, 0);
            this.DiseaseBackBtn.Name = "DiseaseBackBtn";
            this.DiseaseBackBtn.Size = new System.Drawing.Size(43, 53);
            this.DiseaseBackBtn.TabIndex = 6;
            this.DiseaseBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DiseaseBackBtn.UseVisualStyleBackColor = false;
            this.DiseaseBackBtn.Click += new System.EventHandler(this.DiseaseBackBtn_Click);
            // 
            // MedicinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Name = "MedicinesWindow";
            this.Text = "MedicinesWindow";
            this.Load += new System.EventHandler(this.MedicinesWindow_Load);
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

        private System.Windows.Forms.TextBox MedicineText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DosagecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeGV;
        protected System.Windows.Forms.Button DiseaseBackBtn;
    }
}