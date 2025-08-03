using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class ButtonWindow : Form
    {
        private DataGridView _dataGridView;

        public ButtonWindow(DataGridView dataGridView)
        {
            InitializeComponent();
            _dataGridView = dataGridView;
        }
        private void Dwn_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn column in _dataGridView.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < _dataGridView.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
                        }
                        dt.Rows.Add(dataRow);
                    }
                }

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(dt, "Patient Reports");

                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Save Excel File",
                        FileName = "PatientReports.xlsx"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Data successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        /* private void Pdf_Btn_Click(object sender, EventArgs e)
         {
             try
             {
                 SaveFileDialog saveFileDialog = new SaveFileDialog
                 {
                     Filter = "PDF Files|*.pdf",
                     Title = "Save as PDF"
                 };

                 if (saveFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     string filePath = saveFileDialog.FileName;
                     Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                     PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                     pdfDoc.Open();

                     iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                     Paragraph title = new Paragraph("CMS_Report", titleFont)
                     {
                         Alignment = Element.ALIGN_CENTER,
                         SpacingAfter = 20f
                     };
                     pdfDoc.Add(title);

                     PdfPTable pdfTable = new PdfPTable(_dataGridView.Columns.Count)
                     {
                         WidthPercentage = 100
                     };

                     foreach (DataGridViewColumn column in _dataGridView.Columns)
                     {
                         PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                         {
                             BackgroundColor = BaseColor.LIGHT_GRAY
                         };
                         pdfTable.AddCell(cell);
                     }

                     foreach (DataGridViewRow row in _dataGridView.Rows)
                     {
                         foreach (DataGridViewCell cell in row.Cells)
                         {
                             if (cell.Value != null)
                             {
                                 pdfTable.AddCell(cell.Value.ToString());
                             }
                         }
                     }

                     pdfDoc.Add(pdfTable);
                     pdfDoc.Close();

                     MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error exporting to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             this.Close();
         }*/
        private void Pdf_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Save as PDF"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f); // Landscape + margins
                    PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                    pdfDoc.Open();

                    // Title
                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18f, iTextSharp.text.Font.BOLD);
                    Paragraph title = new Paragraph("Patient Report", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 20f
                    };
                    pdfDoc.Add(title);

                    // Table setup
                    PdfPTable pdfTable = new PdfPTable(_dataGridView.Columns.Count)
                    {
                        WidthPercentage = 100
                    };
                    pdfTable.SetWidths(GetColumnWidths(_dataGridView));

                    // Header font
                    iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                    iTextSharp.text.Font cellFont = FontFactory.GetFont("Arial", 9);

                    // Add headers
                    foreach (DataGridViewColumn column in _dataGridView.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                        {
                            BackgroundColor = new BaseColor(0, 102, 204), // Navy blue
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5
                        };
                        pdfTable.AddCell(headerCell);
                    }

                    // Add rows
                    bool alternate = false;
                    foreach (DataGridViewRow row in _dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellText = cell.Value != null ? cell.Value.ToString() : "";
                                PdfPCell dataCell = new PdfPCell(new Phrase(cellText, cellFont))
                                {
                                    NoWrap = false,
                                    MinimumHeight = 20f,
                                    Padding = 4f,
                                    BackgroundColor = alternate ? new BaseColor(240, 240, 240) : BaseColor.WHITE,
                                    VerticalAlignment = Element.ALIGN_MIDDLE
                                };
                                pdfTable.AddCell(dataCell);
                            }
                            alternate = !alternate; // alternate row color
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();

                    MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private float[] GetColumnWidths(DataGridView dgv)
        {
            float[] widths = new float[dgv.Columns.Count];
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                widths[i] = (float)dgv.Columns[i].Width;
            }
            return widths;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void View_Btn_Click_1(object sender, EventArgs e)
        {
            ReportViewWindow reportView = new ReportViewWindow(_dataGridView);
            reportView.StartPosition = FormStartPosition.CenterScreen;
            reportView.Show();
            this.Close();
        }
    }
}
