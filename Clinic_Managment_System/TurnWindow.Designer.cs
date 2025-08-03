namespace Clinic_Managment_System
{
    partial class TurnWindow
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
            this.components = new System.ComponentModel.Container();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.Backbtn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Doctorlabel = new System.Windows.Forms.Label();
            this.TokenLable = new System.Windows.Forms.Label();
            this.DrRolelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.leftpanel.Controls.Add(this.Backbtn2);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(87, 548);
            this.leftpanel.TabIndex = 0;
            // 
            // Backbtn2
            // 
            this.Backbtn2.BackColor = System.Drawing.Color.Transparent;
            this.Backbtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Backbtn2.FlatAppearance.BorderSize = 0;
            this.Backbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn2.Image = global::Clinic_Managment_System.Properties.Resources.arrow;
            this.Backbtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Backbtn2.Location = new System.Drawing.Point(0, 0);
            this.Backbtn2.Name = "Backbtn2";
            this.Backbtn2.Size = new System.Drawing.Size(46, 53);
            this.Backbtn2.TabIndex = 5;
            this.Backbtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Backbtn2.UseVisualStyleBackColor = false;
            this.Backbtn2.Click += new System.EventHandler(this.Backbtn2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(1028, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 548);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(87, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 89);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(87, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 89);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(87, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 370);
            this.panel4.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Doctorlabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TokenLable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DrRolelabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.36103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.63897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Doctorlabel
            // 
            this.Doctorlabel.AutoSize = true;
            this.Doctorlabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Doctorlabel.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorlabel.Image = global::Clinic_Managment_System.Properties.Resources.MedicalPersons;
            this.Doctorlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Doctorlabel.Location = new System.Drawing.Point(629, 153);
            this.Doctorlabel.Name = "Doctorlabel";
            this.Doctorlabel.Size = new System.Drawing.Size(194, 217);
            this.Doctorlabel.TabIndex = 1;
            this.Doctorlabel.Text = "    Doctor:";
            this.Doctorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TokenLable
            // 
            this.TokenLable.AutoSize = true;
            this.TokenLable.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenLable.Location = new System.Drawing.Point(316, 40);
            this.TokenLable.Name = "TokenLable";
            this.TokenLable.Size = new System.Drawing.Size(273, 86);
            this.TokenLable.TabIndex = 0;
            this.TokenLable.Text = "Token #";
            this.TokenLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TokenLable.Click += new System.EventHandler(this.TokenLable_Click);
            // 
            // DrRolelabel
            // 
            this.DrRolelabel.AutoSize = true;
            this.DrRolelabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrRolelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrRolelabel.Image = global::Clinic_Managment_System.Properties.Resources.Role45;
            this.DrRolelabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrRolelabel.Location = new System.Drawing.Point(3, 153);
            this.DrRolelabel.Name = "DrRolelabel";
            this.DrRolelabel.Size = new System.Drawing.Size(162, 217);
            this.DrRolelabel.TabIndex = 2;
            this.DrRolelabel.Text = "     Role:";
            this.DrRolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // TurnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1098, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftpanel);
            this.Name = "TurnWindow";
            this.Text = "Turn Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurnWindow_FormClosing);
            this.Load += new System.EventHandler(this.TurnWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TokenLable;
        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Button Backbtn2;
        private System.Windows.Forms.Label Doctorlabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DrRolelabel;
    }
}