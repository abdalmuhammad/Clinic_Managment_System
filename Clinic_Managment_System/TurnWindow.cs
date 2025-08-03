using CRUD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class TurnWindow : Form
    {
        private static Queue<(string turnNo, string doctorName, string doctorRole)> TurnQueue = new Queue<(string, string, string)>();

        private string _turnNo;
        private string _doctorName;
        private string _doctorRole;

        public TurnWindow()
        {
            InitializeComponent();
        }

        int ticks = 0;
        int showAfter = 5; // 10 sec
        int clearAfter = 30; // total 15 sec

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ticks++;

            if (ticks == showAfter)
            {
                TokenLable.Text = "Token # " + _turnNo;
                Doctorlabel.Text = "    Doctor: " + _doctorName;
                DrRolelabel.Text = "Role: " + _doctorRole;
            }
            else if (ticks == clearAfter)
            {
                TokenLable.Text = "";
                Doctorlabel.Text = "";
                DrRolelabel.Text = "";
                ticks = 0;

                // ✅ Show next one in queue (if any)
                if (TurnQueue.Count > 0)
                {
                    var next = TurnQueue.Dequeue();
                    SetTurnInfo(next.turnNo, next.doctorName, next.doctorRole);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        public void SetTurnInfo(string turnNo, string doctorName, string doctorRole)
        {
            _turnNo = turnNo;
            _doctorName = doctorName;
            _doctorRole = doctorRole;
            ticks = 0; // reset timer
        }

        public static void EnqueueTurnInfo(string turnNo, string doctorName, string doctorRole)
        {
            // Push data into static queue so it's processed when form is opened
            TurnQueue.Enqueue((turnNo, doctorName, doctorRole));
        }

        private void TurnWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();

            // ✅ On load, show next in queue if available
            if (TurnQueue.Count > 0)
            {
                var data = TurnQueue.Dequeue();
                SetTurnInfo(data.turnNo, data.doctorName, data.doctorRole);
            }
        }

        private void TurnWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        /* public static TurnWindow Instance;

         private string _turnNo;
         private string _doctorName;
         private string _doctorRole;

         public TurnWindow()
         {
             InitializeComponent();
             Instance = this; // Make instance available globally
         }

         int ticks = 0;
         int showAfter = 5; // show after 10 sec
         int clearAfter = 15; // clear after 5 more sec (total 15 sec)

         private void timer1_Tick(object sender, EventArgs e)
         {
             ticks++;
             if (ticks == showAfter)
             {
                 // Show data
                 TokenLable.Text = "Token # " + _turnNo;
                 Doctorlabel.Text = "Doctor: " + _doctorName;
                 DrRolelabel.Text = "Role: " + _doctorRole;
             }
             else if (ticks == clearAfter)
             {
                 // Clear data
                 TokenLable.Text = "";
                 Doctorlabel.Text = "";
                 DrRolelabel.Text = "";
                 ticks = 0;
             }
         }

         public void SetTurnInfo(string turnNo, string doctorName, string doctorRole)
         {
             _turnNo = turnNo;
             _doctorName = doctorName;
             _doctorRole = doctorRole;
             ticks = 0; // reset timer
             MessageBox.Show($"SetTurnInfo Called!\nTurn: {_turnNo}\nDoctor: {_doctorName}\nRole: {_doctorRole}", "Debug Info");

         }

         private void TurnWindow_Load(object sender, EventArgs e)
         {
             timer1.Start();
         }

         private void TurnWindow_FormClosing(object sender, FormClosingEventArgs e)
         {
             timer1.Stop();

         }*/
        private void Backbtn2_Click(object sender, EventArgs e)
        {
            HomeScreen HM = new HomeScreen();
            MainClass.showWindow(HM, this, MDI.ActiveForm);
        }

        private void TokenLable_Click(object sender, EventArgs e)
        {

        }

       
    }
}
