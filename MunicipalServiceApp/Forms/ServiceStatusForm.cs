using System;
using System.Windows.Forms;
using MunicipalServicesApp.Models;
using MunicipalServicesApp.Helpers;

namespace MunicipalServicesApp.Forms
{
    public partial class ServiceStatusForm : Form
    {
        private List<Issue> issues;
        private BST bst;

        public ServiceStatusForm()
        {
            InitializeComponent();
            issues = DataManager.Load<Issue>("issues.json");
            bst = new BST();
            foreach (var issue in issues) bst.Insert(issue);
            dgvAll.DataSource = issues;

            UI.ApplyModernStyle(this);
            this.Text = "Service Request Status";
            this.Size = new Size(950, 700);

            tableLayoutPanel1.Padding = new Padding(40);
            dgvAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string id = txtId.Text;
            if (string.IsNullOrEmpty(id)) return;

            var issue = bst.Search(id);
            if (issue != null)
            {
                lblResult.Text = $"Status: {issue.Status}\nLocation: {issue.Location}\nSubmitted: {issue.Submitted.ToString("yyyy-MM-dd")}\nDescription: {issue.Description}";
            }
            else
            {
                lblResult.Text = "No matching request found.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class BSTNode
    {
        public Issue Issue { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
    }

    public class BST
    {
        private BSTNode root;

        public void Insert(Issue issue)
        {
            root = InsertRec(root, issue);
        }

        private BSTNode InsertRec(BSTNode node, Issue issue)
        {
            if (node == null)
            {
                return new BSTNode { Issue = issue };
            }

            if (string.Compare(issue.Id, node.Issue.Id) < 0)
                node.Left = InsertRec(node.Left, issue);
            else if (string.Compare(issue.Id, node.Issue.Id) > 0)
                node.Right = InsertRec(node.Right, issue);

            return node;
        }

        public Issue Search(string id)
        {
            return SearchRec(root, id);
        }

        private Issue SearchRec(BSTNode node, string id)
        {
            if (node == null) return null;
            if (node.Issue.Id == id) return node.Issue;

            if (string.Compare(id, node.Issue.Id) < 0)
                return SearchRec(node.Left, id);
            return SearchRec(node.Right, id);
        }
    }
}
