namespace Clinic_Managment_System
{
    partial class RoleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Role_textBox = new System.Windows.Forms.TextBox();
            this.RoleBackBtn = new System.Windows.Forms.Button();
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
            this.DetailgroupBox.Size = new System.Drawing.Size(795, 425);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(262, 567);
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.Controls.Add(this.RoleBackBtn);
            this.backbtn_panel1.Size = new System.Drawing.Size(262, 53);
            // 
            // heading_Panel
            // 
            this.heading_Panel.Location = new System.Drawing.Point(262, 0);
            this.heading_Panel.Size = new System.Drawing.Size(815, 53);
            // 
            // Right_panel
            // 
            this.Right_panel.Location = new System.Drawing.Point(1057, 53);
            this.Right_panel.Size = new System.Drawing.Size(20, 514);
            // 
            // Bottompanel
            // 
            this.Bottompanel.Location = new System.Drawing.Point(262, 547);
            this.Bottompanel.Size = new System.Drawing.Size(795, 20);
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.Location = new System.Drawing.Point(262, 53);
            this.Fill_Panel.Size = new System.Drawing.Size(795, 494);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.label2);
            this.Left_panel.Controls.Add(this.Role_textBox);
            this.Left_panel.Size = new System.Drawing.Size(262, 514);
            // 
            // userlabel
            // 
            this.userlabel.Location = new System.Drawing.Point(678, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.roleIDGV,
            this.RoleGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 45;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Role";
            // 
            // Role_textBox
            // 
            this.Role_textBox.Enabled = false;
            this.Role_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Role_textBox.Location = new System.Drawing.Point(14, 89);
            this.Role_textBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.Role_textBox.Name = "Role_textBox";
            this.Role_textBox.Size = new System.Drawing.Size(232, 24);
            this.Role_textBox.TabIndex = 15;
            this.Role_textBox.TextChanged += new System.EventHandler(this.Role_textBox_TextChanged);
            // 
            // RoleBackBtn
            // 
            this.RoleBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.RoleBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoleBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.RoleBackBtn.FlatAppearance.BorderSize = 0;
            this.RoleBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleBackBtn.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.RoleBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoleBackBtn.Location = new System.Drawing.Point(0, 0);
            this.RoleBackBtn.Name = "RoleBackBtn";
            this.RoleBackBtn.Size = new System.Drawing.Size(43, 53);
            this.RoleBackBtn.TabIndex = 5;
            this.RoleBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RoleBackBtn.UseVisualStyleBackColor = false;
            this.RoleBackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 567);
            this.Name = "RoleWindow";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RoleWindow_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Role_textBox;
        protected System.Windows.Forms.Button RoleBackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
    }
}