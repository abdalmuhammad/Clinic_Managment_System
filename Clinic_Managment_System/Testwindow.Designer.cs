namespace Clinic_Managment_System
{
    partial class Testwindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestScanXrayGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecautionsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestNameText = new System.Windows.Forms.TextBox();
            this.testlabel = new System.Windows.Forms.Label();
            this.PrecautionsTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestBackBtn = new System.Windows.Forms.Button();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(777, 394);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(290, 536);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.TestBackBtn);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Size = new System.Drawing.Size(797, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1067, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 483);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(290, 516);
            this.Bottompanel.Size = new System.Drawing.Size(777, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Size = new System.Drawing.Size(777, 463);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.PrecautionsTB);
            this.Left_panel.Controls.Add(this.label4);
            this.Left_panel.Controls.Add(this.PriceText);
            this.Left_panel.Controls.Add(this.label3);
            this.Left_panel.Controls.Add(this.TestNameText);
            this.Left_panel.Controls.Add(this.testlabel);
            this.Left_panel.Size = new System.Drawing.Size(290, 483);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(660, 0);
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
            this.testIDGV,
            this.TestScanXrayGV,
            this.PriceGV,
            this.PrecautionsGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 375);
            this.dataGridView1.TabIndex = 2;
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
            // testIDGV
            // 
            this.testIDGV.HeaderText = "TestID";
            this.testIDGV.Name = "testIDGV";
            this.testIDGV.ReadOnly = true;
            this.testIDGV.Visible = false;
            // 
            // TestScanXrayGV
            // 
            this.TestScanXrayGV.HeaderText = "Test / Scan / X-Ray";
            this.TestScanXrayGV.Name = "TestScanXrayGV";
            this.TestScanXrayGV.ReadOnly = true;
            // 
            // PriceGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.PriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PriceGV.HeaderText = "Price";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            // 
            // PrecautionsGV
            // 
            this.PrecautionsGV.HeaderText = "Precautions";
            this.PrecautionsGV.Name = "PrecautionsGV";
            this.PrecautionsGV.ReadOnly = true;
            // 
            // PriceText
            // 
            this.PriceText.Enabled = false;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PriceText.Location = new System.Drawing.Point(18, 141);
            this.PriceText.MaxLength = 80;
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(255, 24);
            this.PriceText.TabIndex = 7;
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // TestNameText
            // 
            this.TestNameText.Enabled = false;
            this.TestNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TestNameText.Location = new System.Drawing.Point(18, 88);
            this.TestNameText.MaxLength = 80;
            this.TestNameText.Name = "TestNameText";
            this.TestNameText.Size = new System.Drawing.Size(255, 24);
            this.TestNameText.TabIndex = 5;
            this.TestNameText.TextChanged += new System.EventHandler(this.TestNameText_TextChanged);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.testlabel.Location = new System.Drawing.Point(15, 69);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(72, 17);
            this.testlabel.TabIndex = 4;
            this.testlabel.Text = "Test Name";
            // 
            // PrecautionsTB
            // 
            this.PrecautionsTB.Enabled = false;
            this.PrecautionsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PrecautionsTB.Location = new System.Drawing.Point(18, 196);
            this.PrecautionsTB.MaxLength = 80;
            this.PrecautionsTB.Name = "PrecautionsTB";
            this.PrecautionsTB.Size = new System.Drawing.Size(255, 24);
            this.PrecautionsTB.TabIndex = 9;
            this.PrecautionsTB.TextChanged += new System.EventHandler(this.PrecautionsTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precautions";
            // 
            // TestBackBtn
            // 
            this.TestBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.TestBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.TestBackBtn.FlatAppearance.BorderSize = 0;
            this.TestBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.TestBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestBackBtn.Location = new System.Drawing.Point(0, 0);
            this.TestBackBtn.Name = "TestBackBtn";
            this.TestBackBtn.Size = new System.Drawing.Size(43, 53);
            this.TestBackBtn.TabIndex = 7;
            this.TestBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TestBackBtn.UseVisualStyleBackColor = false;
            this.TestBackBtn.Click += new System.EventHandler(this.TestBackBtn_Click);
            // 
            // Testwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 536);
            this.Name = "Testwindow";
            this.Text = "Testwindow";
            this.Load += new System.EventHandler(this.Testwindow_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PrecautionsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestNameText;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestScanXrayGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecautionsGV;
        protected System.Windows.Forms.Button TestBackBtn;
    }
}