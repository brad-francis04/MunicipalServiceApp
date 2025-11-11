using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MunicipalServicesApp.Models;
using MunicipalServicesApp.Helpers;

namespace MunicipalServicesApp.Forms
{
    public partial class LocalEventsForm : Form
    {
        private List<Event> events;
        private List<string> searchHistory = new List<string>();

        public LocalEventsForm()
        {
            InitializeComponent();
            events = DataManager.Load<Event>("events.json");
            LoadSampleData();
            RefreshGrid(); // NOW WORKS!

            // APPLY STYLE
            UI.ApplyModernStyle(this);
            this.Text = "Local Events & Announcements";
            this.Size = new Size(950,700);
            tableLayoutPanel1.Padding = new Padding(40);
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            if (events.Count == 0)
            {
                events.AddRange(new[]
                {
                    new Event { Title = "Water Shutdown Notice", Date = DateTime.Today.AddDays(2), Location = "Pretoria", Category = "Water" },
                    new Event { Title = "Road Repair Update", Date = DateTime.Today.AddDays(5), Location = "Johannesburg", Category = "Roads" },
                    new Event { Title = "Community Event", Date = DateTime.Today.AddDays(1), Location = "Cape Town", Category = "Community" }
                });
                DataManager.Save(events, "events.json");
            }
        }

        // FIXED METHOD
        private void RefreshGrid()
        {
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = events.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            var results = events.Where(x =>
                (x.Title?.ToLower().Contains(query) ?? false) ||
                (x.Location?.ToLower().Contains(query) ?? false)).ToList();

            dgvEvents.DataSource = results;

            if (!string.IsNullOrEmpty(query) && !searchHistory.Contains(query))
            {
                searchHistory.Add(query);
                UpdateRecommendations(query);
            }
        }

        private void UpdateRecommendations(string query)
        {
            var recs = events
                .Where(x => x.Category?.ToLower().Contains(query) == true)
                .Take(3)
                .Select(x => x.Title)
                .ToList();

            lbRecommendations.DataSource = recs.Any() ? recs : new List<string> { "No recommendations" };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}