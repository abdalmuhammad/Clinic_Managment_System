using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class notificationWindow : Form
    {
        public notificationWindow(string message)
        {
            InitializeComponent();
            this.Text = "Notification";
            this.Size = new Size(500, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.ForeColor = Color.DarkRed;
            lbl.Text = message;
            lbl.Padding = new Padding(20);
            lbl.AutoSize = false;

            this.Controls.Add(lbl);
        }

        public static class HealthAlertService
        {
            private const string ApiKey = "pub_8586e45f862f4717a8a56df277213467&";

            public static async Task<string> GetHealthNewsAsync()
            {
                string url = $"https://newsdata.io/api/1/latest?apikey=pub_8586e45f862f4717a8a56df277213467&q=medicaly={ApiKey}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        var resp = await client.GetStringAsync(url);
                        var json = JObject.Parse(resp);
                        var articles = json["results"];

                        if (articles != null && articles.HasValues)
                        {
                            foreach (var article in articles)
                            {
                                string title = article["title"]?.ToString()?.Trim() ?? "";
                                string desc = article["description"]?.ToString()?.Trim() ?? "";

                                if (string.IsNullOrEmpty(title)) continue;

                                string titleLower = title.ToLower();
                                string descLower = desc.ToLower();

                                bool isRelevant = titleLower.Contains("medical") || titleLower.Contains("virus") || titleLower.Contains("pandemic") ||
                                                  descLower.Contains("Medical") || descLower.Contains("virus") || descLower.Contains("pandemic");

                                if (isRelevant)
                                {
                                    string cleanedTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());

                                    if (string.IsNullOrWhiteSpace(desc) || descLower.Contains(titleLower))
                                    {
                                        return cleanedTitle;
                                    }
                                    else
                                    {
                                        var snippet = string.Join(" ", desc.Split(' ').Take(50));
                                        return $"{cleanedTitle}\n\n{snippet}";
                                    }
                                }
                            }
                        }

                        return "No relevant health or pandemic alerts.";
                    }
                    catch (Exception ex)
                    {
                        return $"Error fetching news: {ex.Message}";
                    }
                }
            }

        }
    }
}
