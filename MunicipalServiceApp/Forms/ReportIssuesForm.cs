using System;
using System.Collections.Generic;
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

            // Populate Category ComboBox
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new[] { "Water", "Electricity", "Roads", "Sanitation" });
            }

            // Apply UI style
            UI.ApplyModernStyle(this);
            this.Text = "Report Municipal Issue";
        }

        // ATTACH MEDIA 
        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
                ofd.Title = "Select Media File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblMedia.Text = ofd.FileName;
                }
            }
        }

        // SUBMIT REPORT 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill all required fields!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create issue
            var issue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.Text,
                Description = rtbDescription.Text.Trim(),
                MediaPath = lblMedia.Text == "(No file)" ? null : lblMedia.Text
            };

            // Save
            issues.Add(issue);
            DataManager.Save(issues, "issues.json");

            // Feedback
            MessageBox.Show($"Report submitted!\n\nID: {issue.Id}\n\nUse this to track status.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblMedia.Text = "(No file)";
        }

        // BACK BUTTON 
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes form and returns to Main Menu
        }
    }
}