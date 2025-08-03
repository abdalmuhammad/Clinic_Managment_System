using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class MainMenuecs : Form
    {

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
        public MainMenuecs()
        {
            InitializeComponent();
        }

        private async void MainMenuecs_Load(object sender, EventArgs e)
        {
            AdjustButtonsBasedOnRole(Authenticaion.login.ROLE);
            MainClass.ApplyRoundedStyle(Rolebutton, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(Testbtn, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(Staffbtn, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(MedicinesBtn, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(PatientBtn, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(Diseasesbutton, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(Symptombutton, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(CheckUpbutton, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(TurnScreenbutton, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(Reportsbtn, 35, 3, Color.Black);
            MainClass.ApplyRoundedStyle(button3, 35, 3, Color.Black);

            /*await Task.Delay(10000); // 10 seconds delay

            string update = await HealthAlertService.GetHealthUpdateAsync();

            notificationWindow notification = new notificationWindow(update);
            notification.StartPosition = FormStartPosition.CenterScreen;
            notification.Show();*/
        }
        //private async void HomeScreen_Load(object sender, EventArgs e)
        //{
            
        //}
        
        private List<Button> buttonsToAnimate = new List<Button>(); // List to store buttons
        private int currentButtonIndex = 0; // Track which button to show next

        private void AdjustButtonsBasedOnRole(string role)
        {
            HomeScreentableLayoutPanel.Controls.Clear(); // Clear previous controls

            HomeScreentableLayoutPanel.RowCount = 5;
            HomeScreentableLayoutPanel.ColumnCount = 3;

            // Populate buttons based on role
            if (role == "Admin")
            {
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
                buttonsToAnimate.Add(button3);
            }
            else if (role == "Doctor")
            {
                buttonsToAnimate.Add(CheckUpbutton);

            }

            else if (role == "Dentist")
            {
                buttonsToAnimate.Add(CheckUpbutton);
               
            }
            else if (role == "Receptionist")
            {
                buttonsToAnimate.Add(MedicinesBtn);
                buttonsToAnimate.Add(Diseasesbutton);
                buttonsToAnimate.Add(Symptombutton);
                buttonsToAnimate.Add(TurnScreenbutton);
                buttonsToAnimate.Add(Reportsbtn);
                buttonsToAnimate.Add(PatientBtn);
                buttonsToAnimate.Add(button3);
            }

            // Start Timer for animation
            currentButtonIndex = 0;
            buttonAnimationTimer.Interval = 280; // 300 milliseconds delay
            buttonAnimationTimer.Start(); // Start the timer
        }

        private void buttonAnimationTimer_Tick(object sender, EventArgs e)
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
                // Stop the timer when all buttons are added
                buttonAnimationTimer.Stop();
                buttonsToAnimate.Clear(); // Clear the list
            }

        }
        private void buttonAnimationTimer_Tick_1(object sender, EventArgs e)
        {
        }

        private void AddButtonToPanel(Button button, int row, int column)
        {
            button.Visible = true;
            HomeScreentableLayoutPanel.Controls.Add(button, column, row); // Add button to specific row and column
        }

        private void Rolebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void MedicinesBtn_Click(object sender, EventArgs e)
        {
           
        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {
            
        }*/
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void HomeScreentableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Staffbtn_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Rolebutton_Click_1(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            PaymentWindow PW = new PaymentWindow();
            MainClass.showWindow(PW, this, MDI.ActiveForm);
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            Staffwindow SF = new Staffwindow();
            MainClass.showWindow(SF, this, MDI.ActiveForm);
        }

        private void CheckUpbutton_Click_1(object sender, EventArgs e)
        {
            CheckUpWindow cp = new CheckUpWindow();
            MainClass.showWindow(cp, this, MDI.ActiveForm);
        }
        private void Reportsbtn_Click_1(object sender, EventArgs e)
        {
            Reports RT = new Reports();
            MainClass.showWindow(RT, this, MDI.ActiveForm);
        }

        private void Testbtn_Click_1(object sender, EventArgs e)
        {
            Testwindow TW = new Testwindow();
            MainClass.showWindow(TW, this, MDI.ActiveForm);
        }

        private void Diseasesbutton_Click_1(object sender, EventArgs e)
        {
            Diseases D = new Diseases();
            MainClass.showWindow(D, this, MDI.ActiveForm);
        }

        private void Symptombutton_Click_1(object sender, EventArgs e)
        {
            Symptoms smp = new Symptoms();
            MainClass.showWindow(smp, this, MDI.ActiveForm);
        }

        private void TurnScreenbutton_Click_1(object sender, EventArgs e)
        {
            TurnWindow TW = new TurnWindow();
            MainClass.showWindow(TW, this, MDI.ActiveForm);
        }

        private void MedicinesBtn_Click_1(object sender, EventArgs e)
        {
            MedicinesWindow SF = new MedicinesWindow();
            MainClass.showWindow(SF, this, MDI.ActiveForm);
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            PatientRegistration PR = new PatientRegistration();
            MainClass.showWindow(PR, this, MDI.ActiveForm);
        }
    }
}
