namespace Clinic_Managment_System
{
    partial class Diseases
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
            this.DiseaseLabel = new System.Windows.Forms.Label();
            this.DiseasestextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseasesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseasesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(759, 318);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 460);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.DiseaseBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(779, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1021, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 407);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 440);
            this.Bottompanel.Size = new System.Drawing.Size(759, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(759, 387);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.DiseaseLabel);
            this.Left_panel.Controls.Add(this.DiseasestextBox);
            this.Left_panel.Size = new System.Drawing.Size(262, 407);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(642, 0);
            // 
            // DiseaseLabel
            // 
            this.DiseaseLabel.AutoSize = true;
            this.DiseaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiseaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DiseaseLabel.Location = new System.Drawing.Point(12, 69);
            this.DiseaseLabel.Name = "DiseaseLabel";
            this.DiseaseLabel.Size = new System.Drawing.Size(53, 17);
            this.DiseaseLabel.TabIndex = 16;
            this.DiseaseLabel.Text = "Disease";
            // 
            // DiseasestextBox
            // 
            this.DiseasestextBox.Enabled = false;
            this.DiseasestextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DiseasestextBox.Location = new System.Drawing.Point(15, 88);
            this.DiseasestextBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.DiseasestextBox.Name = "DiseasestextBox";
            this.DiseasestextBox.Size = new System.Drawing.Size(227, 24);
            this.DiseasestextBox.TabIndex = 17;
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
            this.DiseasesIDGV,
            this.DiseasesGV});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.AppStarting;
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
            this.dataGridView1.Size = new System.Drawing.Size(753, 299);
            this.dataGridView1.TabIndex = 2;
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
            // DiseasesIDGV
            // 
            this.DiseasesIDGV.HeaderText = "DiseasesID";
            this.DiseasesIDGV.Name = "DiseasesIDGV";
            this.DiseasesIDGV.ReadOnly = true;
            this.DiseasesIDGV.Visible = false;
            // 
            // DiseasesGV
            // 
            this.DiseasesGV.HeaderText = "Diseases";
            this.DiseasesGV.Name = "DiseasesGV";
            this.DiseasesGV.ReadOnly = true;
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
            this.DiseaseBackBtn.Location = new System.Drawing.Point(0, 0);
            this.DiseaseBackBtn.Name = "DiseaseBackBtn";
            this.DiseaseBackBtn.Size = new System.Drawing.Size(43, 53);
            this.DiseaseBackBtn.TabIndex = 5;
            this.DiseaseBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DiseaseBackBtn.UseVisualStyleBackColor = false;
            this.DiseaseBackBtn.Click += new System.EventHandler(this.DiseaseBackBtn_Click);
            // 
            // Diseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 460);
            this.Name = "Diseases";
            this.Text = "Diseases";
            this.Load += new System.EventHandler(this.Diseases_Load);
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
        private System.Windows.Forms.TextBox DiseasestextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseasesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseasesGV;
        protected System.Windows.Forms.Button DiseaseBackBtn;
    }
}