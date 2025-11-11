namespace MunicipalServicesApp.Forms
{
    partial class ReportIssuesForm
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
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDesc = new Label();
            rtbDescription = new RichTextBox();
            btnAttach = new Button();
            lblMedia = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            pbEngagement = new ProgressBar();
            lblFeedback = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Microsoft Sans Serif", 10F);
            lblLocation.Location = new Point(3, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(66, 17);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Dock = DockStyle.Fill;
            txtLocation.Location = new Point(258, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(589, 23);
            txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 10F);
            lblCategory.Location = new Point(3, 38);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 17);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Water", "Electricity", "Roads", "Sanitation" });
            cmbCategory.Location = new Point(258, 41);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(362, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Microsoft Sans Serif", 10F);
            lblDesc.Location = new Point(3, 76);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(83, 17);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.Dock = DockStyle.Fill;
            rtbDescription.Location = new Point(258, 79);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(589, 88);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(258, 173);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(105, 28);
            btnAttach.TabIndex = 6;
            btnAttach.Text = "Attach Media";
            btnAttach.UseVisualStyleBackColor = true;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(258, 208);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(50, 15);
            lblMedia.TabIndex = 7;
            lblMedia.Text = "(No file)";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(258, 239);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(362, 38);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit Report";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(258, 286);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(362, 38);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // pbEngagement
            // 
            pbEngagement.Location = new Point(258, 333);
            pbEngagement.Name = "pbEngagement";
            pbEngagement.Size = new Size(362, 22);
            pbEngagement.TabIndex = 10;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(258, 358);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 15);
            lblFeedback.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblLocation, 0, 0);
            tableLayoutPanel1.Controls.Add(txtLocation, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDesc, 0, 2);
            tableLayoutPanel1.Controls.Add(rtbDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAttach, 1, 3);
            tableLayoutPanel1.Controls.Add(lblMedia, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSubmit, 1, 5);
            tableLayoutPanel1.Controls.Add(btnBack, 1, 6);
            tableLayoutPanel1.Controls.Add(pbEngagement, 1, 7);
            tableLayoutPanel1.Controls.Add(lblFeedback, 1, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(850, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 700);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 600);
            Name = "ReportIssuesForm";
            Text = "Report Issues";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar pbEngagement;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}