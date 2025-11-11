namespace MunicipalServicesApp
{
    partial class MainMenu   // ← CHANGED FROM Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      
        
            
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnReport = new Button();
            btnEvents = new Button();
            btnStatus = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(262, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Municipal Services App";
            // 
            // btnReport
            // 
            btnReport.Location = new Point(60, 136);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(132, 23);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Issues";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnEvents
            // 
            btnEvents.Location = new Point(262, 136);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(251, 23);
            btnEvents.TabIndex = 2;
            btnEvents.Text = "Local Events and Announcements";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(565, 136);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(157, 23);
            btnStatus.TabIndex = 3;
            btnStatus.Text = "Service Request Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);  // ← NEW SIZE
            this.MinimumSize = new System.Drawing.Size(800, 600);
            Controls.Add(btnStatus);
            Controls.Add(btnEvents);
            Controls.Add(btnReport);
            Controls.Add(lblTitle);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnReport;
        private Button btnEvents;
        private Button btnStatus;
    }
}