using System;
using System.Windows.Forms;
using MunicipalServicesApp.Forms;



namespace MunicipalServicesApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            UI.ApplyModernStyle(this);
            this.Text = "Municipal Services - Home";
            this.Size = new Size(800, 600);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new ReportIssuesForm().ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            new LocalEventsForm().ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            new ServiceStatusForm().ShowDialog();
        }
    }
}