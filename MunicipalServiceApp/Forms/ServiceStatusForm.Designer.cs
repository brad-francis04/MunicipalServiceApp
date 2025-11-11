namespace MunicipalServicesApp.Forms
{
    partial class ServiceStatusForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblResult = new Label();
            dgvAll = new DataGridView();
            btnBack = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 10F);
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(63, 17);
            lblId.TabIndex = 0;
            lblId.Text = "Enter ID:";
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(240, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(707, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 9F);
            lblResult.Location = new Point(3, 38);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(141, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Status will appear here...";
            // 
            // dgvAll
            // 
            dgvAll.AllowUserToAddRows = false;
            dgvAll.AllowUserToDeleteRows = false;
            dgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAll.Dock = DockStyle.Fill;
            dgvAll.Location = new Point(3, 116);
            dgvAll.Name = "dgvAll";
            dgvAll.ReadOnly = true;
            dgvAll.RowHeadersVisible = false;
            dgvAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAll.Size = new Size(231, 534);
            dgvAll.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(240, 656);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(707, 41);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(txtId, 1, 0);
            tableLayoutPanel1.Controls.Add(lblResult, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvAll, 0, 2);
            tableLayoutPanel1.Controls.Add(btnBack, 1, 3);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(950, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ServiceStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 700);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 600);
            Name = "ServiceStatusForm";
            Text = "Service Request Status";
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}