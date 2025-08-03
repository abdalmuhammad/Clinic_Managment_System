namespace Clinic_Managment_System
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.backbtn_panel1 = new System.Windows.Forms.Panel();
            this.heading_Panel = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.Right_panel = new System.Windows.Forms.Panel();
            this.Bottompanel = new System.Windows.Forms.Panel();
            this.Fill_Panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.heading_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.Left_panel);
            this.panel1.Controls.Add(this.backbtn_panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 566);
            this.panel1.TabIndex = 0;
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Left_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left_panel.ForeColor = System.Drawing.Color.Transparent;
            this.Left_panel.Location = new System.Drawing.Point(0, 214);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(293, 352);
            this.Left_panel.TabIndex = 1;
            // 
            // backbtn_panel1
            // 
            this.backbtn_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.backbtn_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.backbtn_panel1.ForeColor = System.Drawing.Color.Transparent;
            this.backbtn_panel1.Location = new System.Drawing.Point(0, 0);
            this.backbtn_panel1.Name = "backbtn_panel1";
            this.backbtn_panel1.Size = new System.Drawing.Size(293, 214);
            this.backbtn_panel1.TabIndex = 0;
            // 
            // heading_Panel
            // 
            this.heading_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.heading_Panel.Controls.Add(this.userlabel);
            this.heading_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.heading_Panel.ForeColor = System.Drawing.Color.Transparent;
            this.heading_Panel.Location = new System.Drawing.Point(293, 0);
            this.heading_Panel.Name = "heading_Panel";
            this.heading_Panel.Size = new System.Drawing.Size(840, 51);
            this.heading_Panel.TabIndex = 1;
            // 
            // userlabel
            // 
            this.userlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Image = global::Clinic_Managment_System.Properties.Resources.UserWhite;
            this.userlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userlabel.Location = new System.Drawing.Point(703, 0);
            this.userlabel.Name = "userlabel";
            this.userlabel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.userlabel.Size = new System.Drawing.Size(137, 51);
            this.userlabel.TabIndex = 4;
            this.userlabel.Text = "User";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Right_panel
            // 
            this.Right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_panel.Location = new System.Drawing.Point(1113, 51);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Size = new System.Drawing.Size(20, 515);
            this.Right_panel.TabIndex = 2;
            // 
            // Bottompanel
            // 
            this.Bottompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottompanel.Location = new System.Drawing.Point(293, 546);
            this.Bottompanel.Name = "Bottompanel";
            this.Bottompanel.Size = new System.Drawing.Size(820, 20);
            this.Bottompanel.TabIndex = 3;
            // 
            // Fill_Panel
            // 
            this.Fill_Panel.BackColor = System.Drawing.Color.Ivory;
            this.Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_Panel.Location = new System.Drawing.Point(293, 51);
            this.Fill_Panel.Name = "Fill_Panel";
            this.Fill_Panel.Size = new System.Drawing.Size(820, 495);
            this.Fill_Panel.TabIndex = 4;
            this.Fill_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Fill_Panel_Paint);
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1133, 566);
            this.Controls.Add(this.Fill_Panel);
            this.Controls.Add(this.Bottompanel);
            this.Controls.Add(this.Right_panel);
            this.Controls.Add(this.heading_Panel);
            this.Controls.Add(this.panel1);
            this.Name = "Sample";
            this.Text = "           ";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.panel1.ResumeLayout(false);
            this.heading_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel backbtn_panel1;
        protected System.Windows.Forms.Panel heading_Panel;
        protected System.Windows.Forms.Panel Right_panel;
        protected System.Windows.Forms.Panel Bottompanel;
        protected System.Windows.Forms.Panel Fill_Panel;
        protected System.Windows.Forms.Panel Left_panel;
        protected System.Windows.Forms.Label userlabel;
    }
}

