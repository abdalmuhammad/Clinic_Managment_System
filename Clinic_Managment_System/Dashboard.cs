using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CRUD;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;
using SkiaSharp;

namespace Clinic_Managment_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TotalRevenueLB.Text = "Total Revenue:  0 PKR";
            TotalRevenueLB.ForeColor = Color.Green;
            TotalRevenueLB.Visible = true;

            patientConsultedLB.Text = "Consulted Patients:  0";
            patientConsultedLB.ForeColor = Color.DarkBlue;

            NotPatientConsultedLB.Text = "Not Consulted Patients:  0";
            NotPatientConsultedLB.ForeColor = Color.DarkBlue;

            DateTime fromDate = DateTime.Today.AddDays(-50);
            DateTime toDate = DateTime.Today;


            LoadConsultationStats0(fromDate, toDate);
            LoadConsultationStats1(fromDate, toDate);
            LoadTotalRevenueByFilter(fromDate, toDate);
            LoadGenderWiseConsultedPieChart(fromDate, toDate);
            LoadGenderWiseNotConsultedPieChart(fromDate, toDate);
            LoadMonthlyRevenueBarChart(fromDate, toDate);
            LoadGenderWiseDiseases_SymtomsConditionChart(fromDate, toDate, "Disease");
            LoadTopRecommendedTestsChart(fromDate, toDate);
            LoadDoctorConsultedPatientsTable(fromDate, toDate);
        }

        private void LoadConsultationStats1(DateTime from, DateTime to)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);
            ht.Add("@status", 2);

            object consulted = CrudClass.getLastId("st_getTotalPatientsByStatusCounts", ht);
            patientConsultedLB.Text = $"Consulted Patients:  {consulted}";
        }
        private void LoadConsultationStats0(DateTime from, DateTime to)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);
            ht.Add("@status", 0);

            object consulted = CrudClass.getLastId("st_getTotalPatientsByStatusCounts", ht);
            NotPatientConsultedLB.Text = $"Not Consulted Patients:  {consulted}";
        }

        private void LoadTotalRevenueByFilter(DateTime from, DateTime to)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);

            DataTable dt = CrudClass.getDataTable("st_getTotalRevenueByDate", ht);

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["TotalRevenue"] != DBNull.Value)
            {
                decimal revenue = Convert.ToDecimal(dt.Rows[0]["TotalRevenue"]);
                TotalRevenueLB.Text = $"Total Revenue: {revenue.ToString("N0")} PKR";
            }
            else
            {
                TotalRevenueLB.Text = "Total Revenue: 0 PKR";
            }
        }

        /* private void LoadTotalRevenueByFilter(DateTime from, DateTime to)
         {
             Hashtable ht = new Hashtable();
             ht.Add("@fromDate", from);
             ht.Add("@toDate", to);

             DataTable dt = CrudClass.getDataTable("st_getTotalRevenueByDate", ht);

             if (dt != null && dt.Rows.Count > 0)
             {
                 decimal revenue = Convert.ToDecimal(dt.Rows[0]["TotalRevenue"]);

                 TotalRevenueLB.Text = $"Total Revenue: {revenue.ToString("N0")} PKR";
             }
             else
             {
                 TotalRevenueLB.Text = "Total Revenue: 0 PKR";
             }
         }*/

        private void LoadGenderWiseConsultedPieChart(DateTime from, DateTime to)
        {
            // Clear old control at row 2, column 0
            Control existing = tableLayoutPanel1.GetControlFromPosition(0, 2);
            if (existing != null)
                tableLayoutPanel1.Controls.Remove(existing);

            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);

            // Get filtered data
            DataTable dt = CrudClass.getDataTable("st_getGenderWiseConsultationCounts", ht);

            bool hasData = dt.Rows.Count > 0;
            List<ISeries> pieSeries = new List<ISeries>();

            if (!hasData)
            {
               
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    string gender = row["Gender"].ToString();
                    double count = Convert.ToDouble(row["Count"]);
                    var color = gender == "Female" ? SKColors.DeepSkyBlue : SKColors.Orange;

                    pieSeries.Add(new PieSeries<double>
                    {
                        Name = gender,
                        Values = new[] { count },
                        DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = ctx => $"{ctx.Coordinate.PrimaryValue:N0}",
                        Fill = new SolidColorPaint(color),
                        Stroke = null
                    });
                }
            }

            Label title = new Label
            {
                Text = "Consulted Patients",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 35
            };

            // PieChart control (larger size)
            PieChart pieChart = new PieChart
            {
                Series = pieSeries,
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(10)
            };

            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            tableLayoutPanel1.RowStyles[2].Height = 300;
            tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;

            containerPanel.Controls.Add(pieChart);
            containerPanel.Controls.Add(title); // Title is on top because DockStyle.Top

            // Add panel to TableLayoutPanel
            tableLayoutPanel1.Controls.Add(containerPanel, 0, 2);
        }
        private void LoadGenderWiseNotConsultedPieChart(DateTime from, DateTime to)
        {
            Control existing = tableLayoutPanel1.GetControlFromPosition(1, 2);
            if (existing != null)
                tableLayoutPanel1.Controls.Remove(existing);

            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);

            DataTable dt = CrudClass.getDataTable("st_getGenderWiseNotConsultationCounts", ht);

            // Default fallback counts if no data
            bool hasData = dt.Rows.Count > 0;
            List<ISeries> pieSeries = new List<ISeries>();

            if (!hasData)
            {
               
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    string gender = row["Gender"].ToString();
                    double count = Convert.ToDouble(row["Count"]);
                    var color = gender == "Female" ? SKColors.MediumVioletRed : SKColors.MediumSlateBlue;

                    pieSeries.Add(new PieSeries<double>
                    {
                        Name = gender,
                        Values = new[] { count },
                        DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = ctx => $"{ctx.Coordinate.PrimaryValue:N0}",
                        Fill = new SolidColorPaint(color),
                        Stroke = null
                    });
                }
            }

            // Title Label
            Label title = new Label
            {
                Text = "Not Consulted Patients",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 35
            };

            // PieChart control (larger size)
            PieChart pieChart = new PieChart
            {
                Series = pieSeries,
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(10)
            };

            // Container panel for title + chart
            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            // Optional: increase height of the row in TableLayoutPanel
            tableLayoutPanel1.RowStyles[2].Height = 300;
            tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;

            // Add controls
            containerPanel.Controls.Add(pieChart);
            containerPanel.Controls.Add(title); // Title is on top because DockStyle.Top

            // Add panel to TableLayoutPanel
            tableLayoutPanel1.Controls.Add(containerPanel, 1, 2);
        }

        private void LoadMonthlyRevenueBarChart(DateTime from, DateTime to)
        {
            // Remove previous chart from position (2,2)
            Control existing = tableLayoutPanel1.GetControlFromPosition(2, 2);
            if (existing != null)
            {
                tableLayoutPanel1.Controls.Remove(existing);
            }

            // Prepare parameters
            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);

            DataTable dt = CrudClass.getDataTable("st_getMonthlyRevenueByDate", ht);

            // Prepare values
            List<double> revenues = new List<double>();
            List<string> months = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                revenues.Add(Convert.ToDouble(row["TotalRevenue"]));
                months.Add(Convert.ToDateTime(row["RevenueMonth"] + "-01").ToString("MMM yyyy"));
            }

            // Bar Series
            var revenueSeries = new ColumnSeries<double>
            {
                Name = "Monthly Revenue",
                Values = revenues,
                Fill = new SolidColorPaint(SKColors.MediumPurple),
                Stroke = null,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsSize = 14,
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue:N0} PKR"
            };

            // X-axis
            var xAxis = new Axis
            {
                Labels = months,
                LabelsRotation = 15,
                Name = "Month",
                TextSize = 10
            };

            // Y-axis
            var yAxis = new Axis
            {
                Name = "Revenue (PKR)",
                TextSize = 10
            };

            // Title
            Label title = new Label
            {
                Text = "Monthly Revenue",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Height = 30
            };

            // Chart control
            CartesianChart barChart = new CartesianChart
            {
                Series = new ISeries[] { revenueSeries },
                XAxes = new[] { xAxis },
                YAxes = new[] { yAxis },
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                BackColor = Color.Transparent
            };

            // Panel
            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            containerPanel.Controls.Add(barChart);
            containerPanel.Controls.Add(title);

            // Add to TableLayoutPanel (column 2, row 2)
            tableLayoutPanel1.Controls.Add(containerPanel, 2, 2);
        }
        private void LoadGenderWiseDiseases_SymtomsConditionChart(DateTime from, DateTime to, string type)
        {
            // Remove existing chart from Row 4 (index 3), Column 1 (index 0)
            Control existing = tableLayoutPanel1.GetControlFromPosition(0, 3);
            if (existing != null)
                tableLayoutPanel1.Controls.Remove(existing);

            // Fetch data from DB
            Hashtable ht = new Hashtable();
            ht.Add("@fromDate", from);
            ht.Add("@toDate", to);
            ht.Add("@type", type);

            DataTable dt = CrudClass.getDataTable("st_getGenderWisePatientCondition", ht);

            var grouped = dt.AsEnumerable()
                .GroupBy(r => r.Field<string>("Name"))
                .Select(g => new
                {
                    Name = g.Key,
                    Male = g.Where(x => x.Field<string>("Gender") == "Male").Sum(x => x.Field<int>("PatientCount")),
                    Female = g.Where(x => x.Field<string>("Gender") == "Female").Sum(x => x.Field<int>("PatientCount"))
                }).ToList();

            // Create chart series
            var maleSeries = new ColumnSeries<int>
            {
                Name = "Male",
                Values = grouped.Select(x => x.Male).ToList(),
                Fill = new SolidColorPaint(SKColors.Orange),
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsSize = 7
            };

            var femaleSeries = new ColumnSeries<int>
            {
                Name = "Female",
                Values = grouped.Select(x => x.Female).ToList(),
                Fill = new SolidColorPaint(SKColors.DeepSkyBlue),
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsSize = 7
            };

            var xAxisLabels = grouped.Select(x => x.Name).ToList();

            // Chart setup
            CartesianChart chart = new CartesianChart
            {
                Series = new ISeries[] { maleSeries, femaleSeries },
                XAxes = new Axis[]
                {
            new Axis
            {
                Labels = xAxisLabels,
                LabelsRotation = 5,
                Name = type + "s"
            }
                },
                YAxes = new Axis[]
                {
            new Axis
            {
                Name = "Patients Count"
            }
                },
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Top,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            // Title and buttons
            Label titleLabel = new Label();
            titleLabel.Text = "Gender Wise " + type + " Chart";
            titleLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.AutoSize = true;

            Button diseaseBtn = new Button();
            diseaseBtn.Text = "Diseases";
            diseaseBtn.Font = new Font("Segoe UI", 7);
            diseaseBtn.BackColor = Color.LightSteelBlue;
            diseaseBtn.FlatStyle = FlatStyle.Flat;
            diseaseBtn.Margin = new Padding(5);
            diseaseBtn.Click += (s, e) => LoadGenderWiseDiseases_SymtomsConditionChart(from, to, "Disease");

            Button symptomsBtn = new Button();
            symptomsBtn.Text = "Symptoms";
            symptomsBtn.Font = new Font("Segoe UI", 7);
            symptomsBtn.BackColor = Color.LightSteelBlue;
            symptomsBtn.FlatStyle = FlatStyle.Flat;
            symptomsBtn.Margin = new Padding(5);
            symptomsBtn.Click += (s, e) => LoadGenderWiseDiseases_SymtomsConditionChart(from, to, "Symptom");

            // Layout panel for top controls
            FlowLayoutPanel topPanel = new FlowLayoutPanel();
            topPanel.Dock = DockStyle.Top;
            topPanel.AutoSize = true;
            topPanel.Padding = new Padding(5);
            topPanel.BackColor = Color.Transparent;
            topPanel.Controls.Add(titleLabel);
            topPanel.Controls.Add(diseaseBtn);
            topPanel.Controls.Add(symptomsBtn);

            // Container panel with chart
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Padding = new Padding(5);
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.None;

            panel.Controls.Add(topPanel);
            panel.Controls.Add(chart);

            // Ensure chart is below the topPanel
            panel.Controls.SetChildIndex(chart, 1);

            // Adjust TableLayoutPanel Row Style to allow full height
            tableLayoutPanel1.RowStyles[3] = new RowStyle(SizeType.Percent, 165F); // adjust percent if needed
            tableLayoutPanel1.Controls.Add(panel, 0, 3); 
        }
        private void LoadTopRecommendedTestsChart(DateTime from, DateTime to)
        {
            // Remove existing control
            Control existing = tableLayoutPanel1.GetControlFromPosition(1, 3);
            if (existing != null) tableLayoutPanel1.Controls.Remove(existing);

            // SQL Parameters
            Hashtable ht = new Hashtable
    {
        { "@fromDate", from },
        { "@toDate", to }
    };

            DataTable dt = CrudClass.getDataTable("st_getTopRecommendedTestsByDate", ht);
            int totalCount = dt.AsEnumerable().Sum(row => row.Field<int>("TestCount"));
            if (totalCount == 0) return;

            // Series and labels
            List<ISeries> series = new List<ISeries>();
            List<string> labels = new List<string>();

            List<int> values = new List<int>();
            Random rand = new Random();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["TestName"].ToString();
                int count = Convert.ToInt32(row["TestCount"]);
                labels.Add(name);
                values.Add(count);
            }

            // Create Bar Series
            series.Add(new RowSeries<int>
            {
                Name = "Tests",
                Values = values,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsSize = 10,
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                DataLabelsFormatter = point =>
                {
                    float percent = (float)(Convert.ToInt32(point.Model)) / totalCount * 100;
                    return $"{Math.Round(percent, 1)}%";
                },
                Fill = new SolidColorPaint(SKColors.MediumPurple)
            });

            // Axis Labels
            var xAxis = new Axis
            {
                Labels = labels,
                LabelsRotation = 0,
                TextSize = 10,
                Name = "Test Name"
            };

            var yAxis = new Axis
            {
                Name = "Test Count"
            };

            // Create Chart
            CartesianChart chart = new CartesianChart
            {
                Series = series,
                XAxes = new List<Axis> { xAxis },
                YAxes = new List<Axis> { yAxis },
                LegendPosition = LegendPosition.Top,
                Dock = DockStyle.Fill
            };

            // Title Label
            Label title = new Label
            {
                Text = "Top Recommended Tests For Patients",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Height = 30
            };

            // Panel Container
            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            container.Controls.Add(chart);
            container.Controls.Add(title);

            tableLayoutPanel1.RowStyles[3] = new RowStyle(SizeType.Percent, 60F);
            tableLayoutPanel1.Controls.Add(container, 1, 3);
        }
        private void LoadDoctorConsultedPatientsTable(DateTime from, DateTime to)
        {
            Control oldControl = tableLayoutPanel1.GetControlFromPosition(2, 3);
            if (oldControl != null)
            {
                tableLayoutPanel1.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            Hashtable ht = new Hashtable();
            ht.Add("@FromDate", from);
            ht.Add("@ToDate", to);

            DataTable dt = CrudClass.getDataTable("st_getDoctorConsultedPatientCounts", ht);

            DataGridView dgv = new DataGridView();
            dgv.DataSource = dt;
            dgv.Dock = DockStyle.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ReadOnly = true;
            dgv.BorderStyle = BorderStyle.None;

            // 4. Add it to table
            tableLayoutPanel1.Controls.Add(dgv, 2, 3);
        }


        private void patientConsultedLB_Click(object sender, EventArgs e)
        {

        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date;
            LoadConsultationStats1(fromDate, toDate);
            LoadConsultationStats0(fromDate, toDate);
            LoadTotalRevenueByFilter(fromDate, toDate);
            LoadGenderWiseConsultedPieChart(fromDate, toDate);
            LoadGenderWiseNotConsultedPieChart(fromDate, toDate);
            LoadMonthlyRevenueBarChart(fromDate, toDate);
            LoadGenderWiseDiseases_SymtomsConditionChart(fromDate, toDate, "Disease");
            LoadTopRecommendedTestsChart(fromDate, toDate);
            LoadDoctorConsultedPatientsTable(fromDate, toDate);
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Today.AddDays(-70);
            DateTime toDate = DateTime.Today;


            LoadConsultationStats0(fromDate, toDate);
            LoadConsultationStats1(fromDate, toDate);
            LoadTotalRevenueByFilter(fromDate, toDate);
            LoadGenderWiseConsultedPieChart(fromDate, toDate);
            LoadGenderWiseNotConsultedPieChart(fromDate, toDate);
            LoadMonthlyRevenueBarChart(fromDate, toDate);
            LoadGenderWiseDiseases_SymtomsConditionChart(fromDate, toDate, "Disease");
            LoadTopRecommendedTestsChart(fromDate, toDate);
            LoadDoctorConsultedPatientsTable(fromDate, toDate);
        }
    }
}
