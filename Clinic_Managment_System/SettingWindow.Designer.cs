namespace Clinic_Managment_System
{
    partial class SettingWindow
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
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Settingpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Save_button = new System.Windows.Forms.Button();
            this.IScheckBox = new System.Windows.Forms.CheckBox();
            this.Paswordlabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.userIDlabel = new System.Windows.Forms.Label();
            this.userIDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databasetextBox = new System.Windows.Forms.TextBox();
            this.DataSourcetextBox = new System.Windows.Forms.TextBox();
            this.DataSource = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.panel2.SuspendLayout();
            this.Settingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.Settingpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 567);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(98, 57);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel2.Size = new System.Drawing.Size(250, 51);
            this.kryptonLabel2.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonLabel2.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "HealWell Clinic";
            // 
            // Settingpanel
            // 
            this.Settingpanel.BackColor = System.Drawing.Color.Transparent;
            this.Settingpanel.Controls.Add(this.panel3);
            this.Settingpanel.Controls.Add(this.Save_button);
            this.Settingpanel.Controls.Add(this.IScheckBox);
            this.Settingpanel.Controls.Add(this.Paswordlabel);
            this.Settingpanel.Controls.Add(this.passwordtextBox);
            this.Settingpanel.Controls.Add(this.userIDlabel);
            this.Settingpanel.Controls.Add(this.userIDtextBox);
            this.Settingpanel.Controls.Add(this.label3);
            this.Settingpanel.Controls.Add(this.databasetextBox);
            this.Settingpanel.Controls.Add(this.DataSourcetextBox);
            this.Settingpanel.Controls.Add(this.DataSource);
            this.Settingpanel.Location = new System.Drawing.Point(71, 114);
            this.Settingpanel.Name = "Settingpanel";
            this.Settingpanel.Size = new System.Drawing.Size(319, 416);
            this.Settingpanel.TabIndex = 1;
            this.Settingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Clinic_Managment_System.Properties.Resources.icons8_settings;
            this.panel3.Location = new System.Drawing.Point(142, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 26);
            this.panel3.TabIndex = 12;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Save_button.FlatAppearance.BorderSize = 2;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(27, 332);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(266, 48);
            this.Save_button.TabIndex = 11;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // IScheckBox
            // 
            this.IScheckBox.AutoSize = true;
            this.IScheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IScheckBox.Location = new System.Drawing.Point(27, 274);
            this.IScheckBox.Name = "IScheckBox";
            this.IScheckBox.Size = new System.Drawing.Size(125, 19);
            this.IScheckBox.TabIndex = 0;
            this.IScheckBox.Text = "Integrated Security";
            this.IScheckBox.UseVisualStyleBackColor = true;
            this.IScheckBox.CheckedChanged += new System.EventHandler(this.IScheckBox_CheckedChanged);
            // 
            // Paswordlabel
            // 
            this.Paswordlabel.AutoSize = true;
            this.Paswordlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paswordlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paswordlabel.Location = new System.Drawing.Point(24, 217);
            this.Paswordlabel.Name = "Paswordlabel";
            this.Paswordlabel.Size = new System.Drawing.Size(64, 17);
            this.Paswordlabel.TabIndex = 10;
            this.Paswordlabel.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordtextBox.Location = new System.Drawing.Point(27, 238);
            this.passwordtextBox.MaxLength = 12;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(266, 29);
            this.passwordtextBox.TabIndex = 9;
            // 
            // userIDlabel
            // 
            this.userIDlabel.AutoSize = true;
            this.userIDlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDlabel.Location = new System.Drawing.Point(24, 165);
            this.userIDlabel.Name = "userIDlabel";
            this.userIDlabel.Size = new System.Drawing.Size(51, 17);
            this.userIDlabel.TabIndex = 8;
            this.userIDlabel.Text = "User ID";
            // 
            // userIDtextBox
            // 
            this.userIDtextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userIDtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDtextBox.ForeColor = System.Drawing.Color.Black;
            this.userIDtextBox.Location = new System.Drawing.Point(27, 186);
            this.userIDtextBox.MaxLength = 20;
            this.userIDtextBox.Name = "userIDtextBox";
            this.userIDtextBox.Size = new System.Drawing.Size(266, 29);
            this.userIDtextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database";
            // 
            // databasetextBox
            // 
            this.databasetextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.databasetextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databasetextBox.ForeColor = System.Drawing.Color.Black;
            this.databasetextBox.Location = new System.Drawing.Point(27, 134);
            this.databasetextBox.MaxLength = 100;
            this.databasetextBox.Name = "databasetextBox";
            this.databasetextBox.Size = new System.Drawing.Size(266, 29);
            this.databasetextBox.TabIndex = 3;
            // 
            // DataSourcetextBox
            // 
            this.DataSourcetextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DataSourcetextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSourcetextBox.ForeColor = System.Drawing.Color.Black;
            this.DataSourcetextBox.Location = new System.Drawing.Point(27, 82);
            this.DataSourcetextBox.MaxLength = 200;
            this.DataSourcetextBox.Name = "DataSourcetextBox";
            this.DataSourcetextBox.Size = new System.Drawing.Size(266, 29);
            this.DataSourcetextBox.TabIndex = 0;
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataSource.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSource.Location = new System.Drawing.Point(24, 59);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(79, 17);
            this.DataSource.TabIndex = 0;
            this.DataSource.Text = "Data Source";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Clinic_Managment_System.Properties.Resources.pngegg__1_;
            this.panel1.Location = new System.Drawing.Point(498, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 100);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render365;
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(580, 567);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(200)))));
            this.kryptonPanel1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPanel1.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.kryptonLabel1.Location = new System.Drawing.Point(346, 288);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(356, 96);
            this.kryptonLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "Welcome !";
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "SettingWindow";
            this.Text = "Settings.....";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Settingpanel.ResumeLayout(false);
            this.Settingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Settingpanel;
        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.TextBox DataSourcetextBox;
        private System.Windows.Forms.Label Paswordlabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label userIDlabel;
        private System.Windows.Forms.TextBox userIDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox databasetextBox;
        private System.Windows.Forms.CheckBox IScheckBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}