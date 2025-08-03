namespace Clinic_Managment_System
{
    partial class Symptoms
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
            this.DiseaseLabel = new System.Windows.Forms.Label();
            this.Symptomstext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SympBackBtn = new System.Windows.Forms.Button();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymtomsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(768, 301);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 443);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.SympBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(788, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1030, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 390);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 423);
            this.Bottompanel.Size = new System.Drawing.Size(768, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(768, 370);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.DiseaseLabel);
            this.Left_panel.Controls.Add(this.Symptomstext);
            this.Left_panel.Size = new System.Drawing.Size(262, 390);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(651, 0);
            // 
            // DiseaseLabel
            // 
            this.DiseaseLabel.AutoSize = true;
            this.DiseaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiseaseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseLabel.Location = new System.Drawing.Point(12, 69);
            this.DiseaseLabel.Name = "DiseaseLabel";
            this.DiseaseLabel.Size = new System.Drawing.Size(69, 17);
            this.DiseaseLabel.TabIndex = 18;
            this.DiseaseLabel.Text = "Symptoms";
            // 
            // Symptomstext
            // 
            this.Symptomstext.Enabled = false;
            this.Symptomstext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptomstext.Location = new System.Drawing.Point(15, 88);
            this.Symptomstext.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.Symptomstext.Name = "Symptomstext";
            this.Symptomstext.Size = new System.Drawing.Size(232, 29);
            this.Symptomstext.TabIndex = 19;
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
            this.symptomIDGV,
            this.SymtomsGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(762, 282);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SympBackBtn
            // 
            this.SympBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.SympBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SympBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.SympBackBtn.FlatAppearance.BorderSize = 0;
            this.SympBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SympBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.SympBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SympBackBtn.Location = new System.Drawing.Point(0, 0);
            this.SympBackBtn.Name = "SympBackBtn";
            this.SympBackBtn.Size = new System.Drawing.Size(43, 53);
            this.SympBackBtn.TabIndex = 5;
            this.SympBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SympBackBtn.UseVisualStyleBackColor = false;
            this.SympBackBtn.Click += new System.EventHandler(this.SympBackBtn_Click);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 48;
            // 
            // symptomIDGV
            // 
            this.symptomIDGV.HeaderText = "SymptomsID";
            this.symptomIDGV.Name = "symptomIDGV";
            this.symptomIDGV.ReadOnly = true;
            this.symptomIDGV.Visible = false;
            // 
            // SymtomsGV
            // 
            this.SymtomsGV.HeaderText = "Symptoms";
            this.SymtomsGV.Name = "SymtomsGV";
            this.SymtomsGV.ReadOnly = true;
            // 
            // Symptoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 443);
            this.Name = "Symptoms";
            this.Text = "Symptoms";
            this.Load += new System.EventHandler(this.Symptoms_Load);
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
        private System.Windows.Forms.Label DiseaseLabel;
        private System.Windows.Forms.TextBox Symptomstext;
        protected System.Windows.Forms.Button SympBackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymtomsGV;
    }
}