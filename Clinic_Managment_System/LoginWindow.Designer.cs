namespace Clinic_Managment_System
{
    partial class LoginWindow
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonloginBtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.krptoncancelbtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLable = new System.Windows.Forms.Label();
            this.username = new Krypton.Toolkit.KryptonTextBox();
            this.Paswordlabel = new System.Windows.Forms.Label();
            this.kryptonpaswrdbtn = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonloginBtn
            // 
            this.kryptonloginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonloginBtn.Location = new System.Drawing.Point(34, 440);
            this.kryptonloginBtn.Name = "kryptonloginBtn";
            this.kryptonloginBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.GhostWhite;
            this.kryptonloginBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.kryptonloginBtn.Size = new System.Drawing.Size(165, 52);
            this.kryptonloginBtn.StateCommon.Back.Color1 = System.Drawing.Color.GhostWhite;
            this.kryptonloginBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.kryptonloginBtn.StateCommon.Back.ColorAngle = -2F;
            this.kryptonloginBtn.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonloginBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonloginBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonloginBtn.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonloginBtn.StateCommon.Border.Rounding = 20F;
            this.kryptonloginBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonloginBtn.StateDisabled.Back.Color1 = System.Drawing.Color.GhostWhite;
            this.kryptonloginBtn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.kryptonloginBtn.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonloginBtn.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonloginBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonloginBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kryptonloginBtn.StatePressed.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonloginBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonloginBtn.TabIndex = 11;
            this.kryptonloginBtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonloginBtn.Values.Text = "Login";
            this.kryptonloginBtn.Click += new System.EventHandler(this.kryptonloginBtn_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.kryptonLabel1.Location = new System.Drawing.Point(347, 225);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(444, 119);
            this.kryptonLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "Welcome !";
            // 
            // krptoncancelbtn
            // 
            this.krptoncancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krptoncancelbtn.Location = new System.Drawing.Point(248, 440);
            this.krptoncancelbtn.Name = "krptoncancelbtn";
            this.krptoncancelbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.GhostWhite;
            this.krptoncancelbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.krptoncancelbtn.Size = new System.Drawing.Size(165, 52);
            this.krptoncancelbtn.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.krptoncancelbtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.krptoncancelbtn.StateCommon.Back.ColorAngle = -2F;
            this.krptoncancelbtn.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.krptoncancelbtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.krptoncancelbtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.krptoncancelbtn.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.krptoncancelbtn.StateCommon.Border.Rounding = 20F;
            this.krptoncancelbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krptoncancelbtn.StateDisabled.Back.Color1 = System.Drawing.Color.GhostWhite;
            this.krptoncancelbtn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.krptoncancelbtn.StateDisabled.Border.Rounding = 20F;
            this.krptoncancelbtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.krptoncancelbtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.krptoncancelbtn.StatePressed.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.krptoncancelbtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.krptoncancelbtn.TabIndex = 12;
            this.krptoncancelbtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.krptoncancelbtn.Values.Text = "Cancel";
            this.krptoncancelbtn.Click += new System.EventHandler(this.krptoncancelbtn_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(96, 87);
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
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "HealWell Clinic";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.kryptonloginBtn);
            this.LoginPanel.Controls.Add(this.kryptonLabel2);
            this.LoginPanel.Controls.Add(this.usernameLable);
            this.LoginPanel.Controls.Add(this.username);
            this.LoginPanel.Controls.Add(this.Paswordlabel);
            this.LoginPanel.Controls.Add(this.kryptonpaswrdbtn);
            this.LoginPanel.Controls.Add(this.krptoncancelbtn);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginPanel.Location = new System.Drawing.Point(791, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(513, 595);
            this.LoginPanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Clinic_Managment_System.Properties.Resources.safe__2_2;
            this.pictureBox1.Location = new System.Drawing.Point(342, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.BackColor = System.Drawing.Color.White;
            this.usernameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLable.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLable.Image = global::Clinic_Managment_System.Properties.Resources.username_48__1_;
            this.usernameLable.Location = new System.Drawing.Point(393, 225);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(18, 30);
            this.usernameLable.TabIndex = 0;
            this.usernameLable.Text = ".";
            // 
            // username
            // 
            this.username.CueHint.Padding = new System.Windows.Forms.Padding(-6, -1, -6, -1);
            this.username.Location = new System.Drawing.Point(34, 221);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(390, 39);
            this.username.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.username.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.username.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.username.StateCommon.Border.Rounding = 10F;
            this.username.StateCommon.Border.Width = 1;
            this.username.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.username.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // Paswordlabel
            // 
            this.Paswordlabel.AutoSize = true;
            this.Paswordlabel.BackColor = System.Drawing.Color.White;
            this.Paswordlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paswordlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paswordlabel.ForeColor = System.Drawing.Color.Transparent;
            this.Paswordlabel.Image = global::Clinic_Managment_System.Properties.Resources.password_48__1_;
            this.Paswordlabel.Location = new System.Drawing.Point(395, 340);
            this.Paswordlabel.Name = "Paswordlabel";
            this.Paswordlabel.Size = new System.Drawing.Size(18, 30);
            this.Paswordlabel.TabIndex = 10;
            this.Paswordlabel.Text = ".";
            // 
            // kryptonpaswrdbtn
            // 
            this.kryptonpaswrdbtn.CueHint.Padding = new System.Windows.Forms.Padding(6, -1, 6, -1);
            this.kryptonpaswrdbtn.Location = new System.Drawing.Point(34, 336);
            this.kryptonpaswrdbtn.Name = "kryptonpaswrdbtn";
            this.kryptonpaswrdbtn.Size = new System.Drawing.Size(390, 39);
            this.kryptonpaswrdbtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonpaswrdbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kryptonpaswrdbtn.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.kryptonpaswrdbtn.StateCommon.Border.Rounding = 10F;
            this.kryptonpaswrdbtn.StateCommon.Border.Width = 1;
            this.kryptonpaswrdbtn.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonpaswrdbtn.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonpaswrdbtn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonpaswrdbtn.TabIndex = 2;
            this.kryptonpaswrdbtn.Text = "**********";
            this.kryptonpaswrdbtn.TextChanged += new System.EventHandler(this.kryptonpaswrdbtn_TextChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.LoginPanel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render365;
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(1304, 595);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(200)))));
            this.kryptonPanel1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPanel1.TabIndex = 2;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(771, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 70);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(791, 463);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 595);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "LoginWindow";
            this.Text = "Login...";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label usernameLable;
        private Krypton.Toolkit.KryptonButton kryptonloginBtn;
        private System.Windows.Forms.Label Paswordlabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton krptoncancelbtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.Panel LoginPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox username;
        private Krypton.Toolkit.KryptonTextBox kryptonpaswrdbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        /*        private Krypton.Toolkit.KryptonButton kryptonloginBtn;
*/
    }
}