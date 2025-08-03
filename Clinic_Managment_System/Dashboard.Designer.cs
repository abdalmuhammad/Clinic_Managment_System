namespace Clinic_Managment_System
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalRevenueLB = new System.Windows.Forms.Label();
            this.patientConsultedLB = new System.Windows.Forms.Label();
            this.NotPatientConsultedLB = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TotalRevenueLB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientConsultedLB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NotPatientConsultedLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.9845F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.25323F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TotalRevenueLB
            // 
            this.TotalRevenueLB.AutoSize = true;
            this.TotalRevenueLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalRevenueLB.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenueLB.Location = new System.Drawing.Point(535, 63);
            this.TotalRevenueLB.Name = "TotalRevenueLB";
            this.TotalRevenueLB.Size = new System.Drawing.Size(262, 60);
            this.TotalRevenueLB.TabIndex = 5;
            this.TotalRevenueLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientConsultedLB
            // 
            this.patientConsultedLB.AutoSize = true;
            this.patientConsultedLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientConsultedLB.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientConsultedLB.Location = new System.Drawing.Point(3, 63);
            this.patientConsultedLB.Name = "patientConsultedLB";
            this.patientConsultedLB.Size = new System.Drawing.Size(260, 60);
            this.patientConsultedLB.TabIndex = 2;
            this.patientConsultedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientConsultedLB.Click += new System.EventHandler(this.patientConsultedLB_Click);
            // 
            // NotPatientConsultedLB
            // 
            this.NotPatientConsultedLB.AutoSize = true;
            this.NotPatientConsultedLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotPatientConsultedLB.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotPatientConsultedLB.Location = new System.Drawing.Point(269, 63);
            this.NotPatientConsultedLB.Name = "NotPatientConsultedLB";
            this.NotPatientConsultedLB.Size = new System.Drawing.Size(260, 60);
            this.NotPatientConsultedLB.TabIndex = 3;
            this.NotPatientConsultedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ViewAllBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilterBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 57);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ViewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Image = global::Clinic_Managment_System.Properties.Resources.ALDATA5;
            this.ViewAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewAllBtn.Location = new System.Drawing.Point(134, 3);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ViewAllBtn.Size = new System.Drawing.Size(125, 51);
            this.ViewAllBtn.TabIndex = 1;
            this.ViewAllBtn.Text = "View All";
            this.ViewAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FilterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.Image = global::Clinic_Managment_System.Properties.Resources.filter6;
            this.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterBtn.Location = new System.Drawing.Point(3, 3);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.FilterBtn.Size = new System.Drawing.Size(125, 51);
            this.FilterBtn.TabIndex = 0;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.46154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.53846F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerTo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerFrom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 57);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTo.Location = new System.Drawing.Point(51, 34);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(51, 3);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label patientConsultedLB;
        private System.Windows.Forms.Label NotPatientConsultedLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Label TotalRevenueLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}