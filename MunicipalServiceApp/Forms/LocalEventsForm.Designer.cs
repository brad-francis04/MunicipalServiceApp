namespace MunicipalServicesApp.Forms
{
    partial class LocalEventsForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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


        private void InitializeComponent()
        {
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvEvents = new DataGridView();
            lblRecommendations = new Label();
            lbRecommendations = new ListBox();
            btnBack = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(229, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(718, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Dock = DockStyle.Fill;
            dgvEvents.Location = new Point(3, 41);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(220, 581);
            dgvEvents.TabIndex = 2;
            // 
            // lblRecommendations
            // 
            lblRecommendations.AutoSize = true;
            lblRecommendations.Font = new Font("Microsoft Sans Serif", 10F);
            lblRecommendations.Location = new Point(3, 625);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(129, 17);
            lblRecommendations.TabIndex = 3;
            lblRecommendations.Text = "Recommendations:";
            // 
            // lbRecommendations
            // 
            lbRecommendations.Dock = DockStyle.Fill;
            lbRecommendations.FormattingEnabled = true;
            lbRecommendations.Location = new Point(229, 628);
            lbRecommendations.Name = "lbRecommendations";
            lbRecommendations.Size = new Size(718, 22);
            lbRecommendations.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(229, 656);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(718, 41);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8655453F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.13445F));
            tableLayoutPanel1.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvEvents, 0, 1);
            tableLayoutPanel1.Controls.Add(lblRecommendations, 0, 2);
            tableLayoutPanel1.Controls.Add(lbRecommendations, 1, 2);
            tableLayoutPanel1.Controls.Add(btnBack, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(950, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 700);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 600);
            Name = "LocalEventsForm";
            Text = "Local Events & Announcements";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.ListBox lbRecommendations;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}