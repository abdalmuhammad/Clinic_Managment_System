namespace Clinic_Managment_System
{
    partial class ButtonWindow
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.View_Btn = new System.Windows.Forms.Button();
            this.Pdf_Btn = new System.Windows.Forms.Button();
            this.Dwn_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(110)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.View_Btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Pdf_Btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dwn_Btn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.02439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.73171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.7561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 410);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 36);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select view && download format";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Toppanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 15;
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Toppanel.Controls.Add(this.button1);
            this.Toppanel.Controls.Add(this.label1);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(800, 40);
            this.Toppanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download && View";
            // 
            // View_Btn
            // 
            this.View_Btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.View_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View_Btn.FlatAppearance.BorderSize = 0;
            this.View_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(250)))));
            this.View_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.View_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Btn.Image = global::Clinic_Managment_System.Properties.Resources.report_44;
            this.View_Btn.Location = new System.Drawing.Point(3, 290);
            this.View_Btn.Name = "View_Btn";
            this.View_Btn.Size = new System.Drawing.Size(794, 117);
            this.View_Btn.TabIndex = 14;
            this.View_Btn.Text = "&View.pdf";
            this.View_Btn.UseVisualStyleBackColor = false;
            this.View_Btn.Click += new System.EventHandler(this.View_Btn_Click_1);
            // 
            // Pdf_Btn
            // 
            this.Pdf_Btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pdf_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pdf_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pdf_Btn.FlatAppearance.BorderSize = 0;
            this.Pdf_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(250)))));
            this.Pdf_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Pdf_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdf_Btn.Image = global::Clinic_Managment_System.Properties.Resources.export_pdf_45;
            this.Pdf_Btn.Location = new System.Drawing.Point(3, 164);
            this.Pdf_Btn.Name = "Pdf_Btn";
            this.Pdf_Btn.Size = new System.Drawing.Size(794, 120);
            this.Pdf_Btn.TabIndex = 12;
            this.Pdf_Btn.Text = "&Download.pdf";
            this.Pdf_Btn.UseVisualStyleBackColor = false;
            this.Pdf_Btn.Click += new System.EventHandler(this.Pdf_Btn_Click);
            // 
            // Dwn_Btn
            // 
            this.Dwn_Btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dwn_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dwn_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dwn_Btn.FlatAppearance.BorderSize = 0;
            this.Dwn_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(250)))));
            this.Dwn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dwn_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dwn_Btn.Image = global::Clinic_Managment_System.Properties.Resources.export_excel_451;
            this.Dwn_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dwn_Btn.Location = new System.Drawing.Point(3, 45);
            this.Dwn_Btn.Name = "Dwn_Btn";
            this.Dwn_Btn.Size = new System.Drawing.Size(794, 113);
            this.Dwn_Btn.TabIndex = 11;
            this.Dwn_Btn.Text = "&Download.xlx";
            this.Dwn_Btn.UseVisualStyleBackColor = false;
            this.Dwn_Btn.Click += new System.EventHandler(this.Dwn_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Clinic_Managment_System.Properties.Resources.Round__12_;
            this.button1.Location = new System.Drawing.Point(762, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonWindow";
            this.Text = "ButtonWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dwn_Btn;
        private System.Windows.Forms.Button Pdf_Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button View_Btn;
    }
}