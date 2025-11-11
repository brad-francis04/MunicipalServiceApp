using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }

    // FINAL UI — BLACK SUBMIT & BACK ON ALL FORMS
    public static class UI
    {
        public static void ApplyModernStyle(Form form)
        {
            // FORM
            form.BackColor = Color.FromArgb(45, 45, 48);
            form.ForeColor = Color.White;
            form.Font = new Font("Segoe UI", 12F);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;

            // APPLY TO ALL CONTROLS (INCLUDING NESTED)
            ApplyToAllControls(form.Controls);
        }

        private static void ApplyToAllControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                // BUTTONS
                if (c is Button btn)
                {
                    string text = btn.Text.Trim().ToLower();

                    if (text.Contains("submit") || text.Contains("back"))
                    {
                        // BLACK BUTTONS
                        btn.BackColor = Color.Black;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        btn.Height = 50;
                        btn.Cursor = Cursors.Hand;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        // ORANGE FOR OTHERS
                        btn.BackColor = Color.FromArgb(255, 140, 0);
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        btn.Height = 50;
                        btn.Cursor = Cursors.Hand;
                    }
                }

                // INPUTS
                if (c is TextBox || c is ComboBox || c is RichTextBox)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                    c.Font = new Font("Segoe UI", 11F);
                }

                // LABELS
                if (c is Label lbl && lbl.Name.StartsWith("lbl"))
                {
                    lbl.ForeColor = Color.Cyan;
                    lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                }

                // DATAGRIDVIEW
                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.ForeColor = Color.Black;
                    dgv.Font = new Font("Segoe UI", 11F);
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.RowHeadersVisible = false;
                    dgv.ColumnHeadersHeight = 45;
                    dgv.RowTemplate.Height = 40;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

                    dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }

                // RECURSIVE: APPLY TO NESTED CONTROLS (TableLayoutPanel, etc.)
                if (c.HasChildren)
                {
                    ApplyToAllControls(c.Controls);
                }
            }
        }
    }
}