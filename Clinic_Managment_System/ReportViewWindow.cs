using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class ReportViewWindow : Form
    {
        private string pdfFilePath = Path.Combine(Path.GetTempPath(), "ReportView.pdf");

        public ReportViewWindow()
        {
            InitializeComponent();
        }
        public ReportViewWindow(DataGridView dataGridView)
        {
            InitializeComponent();
            GeneratePDF(dataGridView);
            LoadPDF();
        }
        private void GeneratePDF(DataGridView dataGridView)
        {
            try
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(pdfDoc, new FileStream(pdfFilePath, FileMode.Create));
                pdfDoc.Open();

                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                Paragraph title = new Paragraph("Report", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20f
                };
                pdfDoc.Add(title);

                PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count)
                {
                    WidthPercentage = 100
                };

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPDF()
        {
            if (File.Exists(pdfFilePath))
            {
                axAcroPDF1.LoadFile(pdfFilePath);
            }
            else
            {
                MessageBox.Show("PDF file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportViewWindow_Load(object sender, EventArgs e)
        {
         
        }
    }
}
