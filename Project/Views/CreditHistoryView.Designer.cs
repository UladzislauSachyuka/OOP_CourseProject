namespace Project.Views
{
    partial class CreditHistoryView
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
            panel1 = new Panel();
            back_button = new Button();
            history_dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)history_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(back_button);
            panel1.Location = new Point(0, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 74);
            panel1.TabIndex = 6;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(78, 184, 206);
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            back_button.ForeColor = Color.FromArgb(34, 36, 49);
            back_button.Location = new Point(785, 23);
            back_button.Name = "back_button";
            back_button.Size = new Size(161, 39);
            back_button.TabIndex = 75;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // history_dataGridView
            // 
            history_dataGridView.AllowUserToAddRows = false;
            history_dataGridView.AllowUserToDeleteRows = false;
            history_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            history_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            history_dataGridView.Location = new Point(0, 1);
            history_dataGridView.Name = "history_dataGridView";
            history_dataGridView.ReadOnly = true;
            history_dataGridView.RowHeadersVisible = false;
            history_dataGridView.RowHeadersWidth = 51;
            history_dataGridView.RowTemplate.Height = 29;
            history_dataGridView.Size = new Size(985, 398);
            history_dataGridView.TabIndex = 7;
            // 
            // CreditHistoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 473);
            Controls.Add(history_dataGridView);
            Controls.Add(panel1);
            Name = "CreditHistoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreditHistoryView";
            FormClosed += CreditHistoryView_FormClosed;
            Load += CreditHistoryView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)history_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button back_button;
        private DataGridView history_dataGridView;
    }
}