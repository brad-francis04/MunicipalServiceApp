using System;
using System.Windows.Forms;
using MunicipalServicesApp.Models;
using MunicipalServicesApp.Helpers;

namespace MunicipalServicesApp.Forms
{
    public partial class ReportIssuesForm : Form
    {
        private List<Issue> issues;

        public ReportIssuesForm()
        {
            InitializeComponent();
            issues = DataManager.Load<Issue>("issues.json");

            // Populate ComboBox
            if (cmbCategory.Items.Count == 0)
                cmbCategory.Items.AddRange(new[] { "Water", "Electricity", "Roads", "Sanitation" });

            UI.ApplyModernStyle(this);
            this.Text = "Report Municipal Issue";
            this.Size = new Size(850, 700);

            // Fix layout
            tableLayoutPanel1.Padding = new Padding(40);
            tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
            rtbDescription.Height = 120;
        }
        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg|All files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblMedia.Text = ofd.FileName;
                }
            }
        }

        // SUBMIT BUTTON — FULLY WORKING
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill all required fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new issue
            var issue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.Text,
                Description = rtbDescription.Text.Trim(),
                MediaPath = lblMedia.Text == "(No file)" ? null : lblMedia.Text
            };

            // Add to list and save
            issues.Add(issue);
            DataManager.Save(issues, "issues.json");

            // Show success + ID
            pbEngagement.Value = 100;
            lblFeedback.Text = "Thank you! Your report helps improve our community.";
            MessageBox.Show($"Report submitted successfully!\n\nYour ID: {issue.Id}\n\nUse this ID to track status.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblMedia.Text = "(No file)";
            pbEngagement.Value = 0;
            lblFeedback.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}