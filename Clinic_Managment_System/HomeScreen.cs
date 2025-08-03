using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Clinic_Managment_System.notificationWindow;

namespace Clinic_Managment_System
{
    public partial class HomeScreen : Sample
    {
       /* this.FormBorderStyle = FormBorderStyle.None;*/

        private void ApplyRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top Left
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90); // Top Right
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90); // Bottom Right
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90); // Bottom Left
            path.CloseFigure();
            this.Region = new Region(path);
        }
        public HomeScreen()
        {
            InitializeComponent();
            this.Load += HomeScreen_Load;
        }

        private void HomeScreen_Load(object Form)
        {
            if (this.Fill_Panel.Controls.Count > 0)
                this.Fill_Panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Fill_Panel.Controls.Add(f);
            this.Fill_Panel.Tag = f;
            f.Show();
           
        }


        private List<Button> buttonsToAnimate = new List<Button>(); 
        private int currentButtonIndex = 0; 

        private void AdjustButtonsBasedOnRole(string role)
        {
           /* HomeScreentableLayoutPanel.Controls.Clear(); // Clear previous controls

            HomeScreentableLayoutPanel.RowCount = 5;
            HomeScreentableLayoutPanel.ColumnCount = 3;*/

            // Populate buttons based on role
            if (role == "Admin")
            {/*
                buttonsToAnimate.Add(Rolebutton);
                buttonsToAnimate.Add(Staffbtn);
                buttonsToAnimate.Add(MedicinesBtn);
                buttonsToAnimate.Add(PatientBtn);
                buttonsToAnimate.Add(Diseasesbutton);
                buttonsToAnimate.Add(Symptombutton);
                buttonsToAnimate.Add(CheckUpbutton);
                buttonsToAnimate.Add(TurnScreenbutton);
                buttonsToAnimate.Add(Reportsbtn);
                buttonsToAnimate.Add(Testbtn);
                buttonsToAnimate.Add(button3);*/
            }
            else if (role == "Doctor")
            {
                /*buttonsToAnimate.Add(Reportsbtn);
                buttonsToAnimate.Add(CheckUpbutton);
                buttonsToAnimate.Add(Reportsbtn);*/
            }

            else if (role == "Dentist")
            {
                /*buttonsToAnimate.Add(Reportsbtn);
                buttonsToAnimate.Add(CheckUpbutton);
                buttonsToAnimate.Add(Reportsbtn);*/
            }
            else if (role == "Receptionist")
            {
                /*buttonsToAnimate.Add(MedicinesBtn);
                buttonsToAnimate.Add(Diseasesbutton);
                buttonsToAnimate.Add(Symptombutton);
                buttonsToAnimate.Add(TurnScreenbutton);
                buttonsToAnimate.Add(Reportsbtn);
                buttonsToAnimate.Add(PatientBtn);
                buttonsToAnimate.Add(button3);*/
            }

            // Start Timer for animation
            currentButtonIndex = 0;
            buttonAnimationTimer.Interval = 280; // 300 milliseconds delay
            buttonAnimationTimer.Start(); // Start the timer
        }

        private void buttonAnimationTimer_Tick_1(object sender, EventArgs e)
        {
            if (currentButtonIndex < buttonsToAnimate.Count)
            {
                int row = currentButtonIndex / 3; 
                int column = currentButtonIndex % 2;

                // Add the button to the panel
                AddButtonToPanel(buttonsToAnimate[currentButtonIndex], row, column);

                currentButtonIndex++; // Move to the next button
            }
            else
            {
                buttonAnimationTimer.Stop();
                buttonsToAnimate.Clear(); 
            }
        }
       
        private void AddButtonToPanel(Button button, int row, int column)
        {
            button.Visible = true;
        }

        private void Rolebutton_Click(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staffwindow SF = new Staffwindow();
            MainClass.showWindow(SF, this, MDI.ActiveForm);
        }

        private void MedicinesBtn_Click(object sender, EventArgs e)
        {
            MedicinesWindow SF = new MedicinesWindow();
            MainClass.showWindow(SF, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientRegistration PR = new PatientRegistration();
            MainClass.showWindow(PR, this, MDI.ActiveForm);
        }

        private void Diseasesbutton_Click(object sender, EventArgs e)
        {
            Diseases D = new Diseases();
            MainClass.showWindow(D, this, MDI.ActiveForm);
        }

        private void Symptombutton_Click(object sender, EventArgs e)
        {
            Symptoms smp = new Symptoms ();
            MainClass.showWindow(smp, this, MDI.ActiveForm);
        }

        private void CheckUpbutton_Click(object sender, EventArgs e)
        {
            CheckUpWindow cp = new CheckUpWindow();
            MainClass.showWindow(cp, this, MDI.ActiveForm);
        }

        private void TurnScreenbutton_Click(object sender, EventArgs e)
        {
            TurnWindow TW = new TurnWindow();
            MainClass.showWindow(TW, this, MDI.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            Reports RT = new Reports();
            MainClass.showWindow(RT, this, MDI.ActiveForm);
        }

        private void ExistBtn_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog before exiting
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void HomeScreentableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            Testwindow TW = new Testwindow();
            MainClass.showWindow(TW,this, MDI.ActiveForm);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PaymentWindow PW = new PaymentWindow();
            MainClass.showWindow(PW,this, MDI.ActiveForm);
        }

        private void Rolebutton_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Staffbtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeScreen_Load(new Dashboard());
            
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeScreen_Load(new MainMenuecs());
        }

        private async void HomeScreen_Load(object sender, EventArgs e)
        {
            HomeScreen_Load(new Dashboard());
            await Task.Delay(10000);

            string message = await HealthAlertService.GetHealthNewsAsync();
            notificationWindow alert = new notificationWindow(message);
            alert.StartPosition = FormStartPosition.CenterScreen;
            alert.ShowDialog();
        }
    }
}
