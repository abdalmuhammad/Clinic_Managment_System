using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;

namespace Clinic_Managment_System
{
    public partial class Prescription_Report : Form
    {
        public Prescription_Report()
        {
            InitializeComponent();
        }
        private void Prescription_Report_Load(object sender, EventArgs e)
        {

        }

        string patientName, gender, age, doctor, test, disease, symptom, InternalMedicine, ExternalMedicine, remarks, checkupFees, testFees, totalFees;
        public Prescription_Report(string _patientName, string _gender, string _age, string _doctor, string _test, string _disease,
                          string _symptom, string _InternalMedicine, string _ExternalMedicine, string _remarks, string _checkupFees, string _testFees, string _totalFees)
        {
            InitializeComponent();

            // Assign values
            patientName = _patientName;
            gender = _gender;
            age = _age; 
            doctor = _doctor;
            test = _test;
            disease = _disease;
            symptom = _symptom;
            InternalMedicine = _InternalMedicine;
            ExternalMedicine = _ExternalMedicine;
            remarks = _remarks;
            checkupFees = _checkupFees;
            testFees = _testFees;
            totalFees = _totalFees;

            GenerateReport(); 
        }
        private void GenerateReport()
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            page.Size = PdfSharp.PageSize.A5;
            page.Width = XUnit.FromMillimeter(148);
            page.Height = XUnit.FromMillimeter(210);

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            XFont titleFont = new XFont("Arial", 18, XFontStyle.Bold);
            XFont headerFont = new XFont("Arial", 14, XFontStyle.Bold);
            XFont normalFont = new XFont("Arial", 12, XFontStyle.Regular);
            XFont smallFont = new XFont("Arial", 8, XFontStyle.Italic);

            double y = 30;

            // Title Bar
            gfx.DrawRectangle(new XSolidBrush(XColor.FromArgb(0, 102, 204)), new XRect(0, y, page.Width, 45));
            tf.Alignment = XParagraphAlignment.Center;
            tf.DrawString("HellWell Clinic - Patient Report", titleFont, XBrushes.White, new XRect(0, y + 10, page.Width, 25));
            tf.Alignment = XParagraphAlignment.Right;
            tf.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), smallFont, XBrushes.White, new XRect(0, y + 5, page.Width - 10, 10));
            y += 60;

            // Patient Info Box
            gfx.DrawRectangle(XBrushes.LightSkyBlue, new XRect(20, y, page.Width - 40, 80));
            tf.Alignment = XParagraphAlignment.Left;
            tf.DrawString($"Patient: {patientName}                    Gender: {gender}", normalFont, XBrushes.Black, new XRect(25, y + 10, page.Width - 50, 20));
            tf.DrawString($"Age: {age}                          Consulted To: {doctor}", normalFont, XBrushes.Black, new XRect(25, y + 35, page.Width - 50, 20));
            y += 90;

            // Disease & Symptoms
            gfx.DrawRectangle(XBrushes.Beige, new XRect(20, y, page.Width - 40, 60));
            tf.DrawString($"Disease: {disease}", normalFont, XBrushes.Black, new XRect(25, y + 10, page.Width - 50, 20));
            tf.DrawString($"Symptoms: {symptom}", normalFont, XBrushes.Black, new XRect(25, y + 30, page.Width - 50, 20));
            y += 70;

            // Tests
            gfx.DrawRectangle(XBrushes.LightYellow, new XRect(20, y, page.Width - 40, 40));
            tf.DrawString($"Recommended Tests: {test}", normalFont, XBrushes.Black, new XRect(25, y + 10, page.Width - 50, 20));
            y += 50;

            // Medicines Section
            gfx.DrawRectangle(XBrushes.Lavender, new XRect(20, y, page.Width - 40, 100));
            tf.DrawString("Internal Medicines", headerFont, XBrushes.DarkBlue, new XRect(25, y + 5, page.Width - 50, 20));
            tf.DrawString(InternalMedicine, normalFont, XBrushes.Black, new XRect(25, y + 25, page.Width - 50, 20));
            tf.DrawString("External Medicines", headerFont, XBrushes.DarkBlue, new XRect(25, y + 50, page.Width - 50, 20));
            tf.DrawString(ExternalMedicine, normalFont, XBrushes.Black, new XRect(25, y + 70, page.Width - 50, 20));
            y += 110;

            // Remarks Section
            gfx.DrawRectangle(XBrushes.MistyRose, new XRect(20, y, page.Width - 40, 60));
            tf.DrawString("Doctor's Remarks:", headerFont, XBrushes.Black, new XRect(25, y + 5, page.Width - 50, 20));
            tf.DrawString(remarks, normalFont, XBrushes.Black, new XRect(25, y + 25, page.Width - 50, 30));
            y += 70;

            // Fees Summary
            gfx.DrawRectangle(XBrushes.LightGreen, new XRect(20, y, page.Width - 40, 75));
            tf.DrawString($"Checkup: {FormatCurrency(checkupFees)}", normalFont, XBrushes.Black, new XRect(25, y + 10, page.Width - 50, 20));
            tf.DrawString($"Test: {FormatCurrency(testFees)}", normalFont, XBrushes.Black, new XRect(25, y + 30, page.Width - 50, 20));
            tf.DrawString($"Total: {FormatCurrency(totalFees)}", normalFont, XBrushes.DarkRed, new XRect(25, y + 50, page.Width - 50, 20));
            y += 85;

            // Signature
            tf.Alignment = XParagraphAlignment.Right;
            tf.DrawString("Doctor's Signature", normalFont, XBrushes.Black, new XRect(0, y + 10, page.Width - 40, 20));
            gfx.DrawLine(XPens.Black, page.Width - 120, y + 30, page.Width - 40, y + 30);
            y += 50;

            // Footer
            tf.Alignment = XParagraphAlignment.Center;
            gfx.DrawRectangle(XBrushes.Gainsboro, new XRect(0, page.Height - 40, page.Width, 30));
            tf.DrawString("CAA Aviation near Star Gate Karachi | +92 375839823", smallFont, XBrushes.Black, new XRect(0, page.Height - 35, page.Width, 20));

            // Save & Load
            using (var stream = new MemoryStream())
            {
                doc.Save(stream, false);
                string filePath = $"PrescriptionReport_{patientName}.pdf";
                File.WriteAllBytes(filePath, stream.ToArray());
                axAcroPDF1.LoadFile(filePath);
                axAcroPDF1.setView("Fit");
            }

            /*MessageBox.Show("Stylish full prescription PDF generated successfully.");*/
        }

        // Helper to format currency values with commas and 0 decimals
        private string FormatCurrency(string amount)
        {
            if (decimal.TryParse(amount, out decimal value))
            {
                return string.Format("{0:N0}", value); // e.g., 1,000
            }
            return amount;
        }
    }
}
