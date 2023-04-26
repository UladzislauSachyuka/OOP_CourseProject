namespace Project.Views
{
    partial class CreditApplicationsView
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
            refuse_button = new Button();
            id_label = new TextBox();
            back_button = new Button();
            approve_button = new Button();
            panel4 = new Panel();
            label3 = new Label();
            credit_applications_dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)credit_applications_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(refuse_button);
            panel1.Controls.Add(id_label);
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(approve_button);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 362);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 110);
            panel1.TabIndex = 5;
            // 
            // refuse_button
            // 
            refuse_button.BackColor = Color.FromArgb(78, 184, 206);
            refuse_button.Cursor = Cursors.Hand;
            refuse_button.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            refuse_button.FlatAppearance.BorderSize = 0;
            refuse_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            refuse_button.FlatStyle = FlatStyle.Flat;
            refuse_button.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            refuse_button.ForeColor = Color.FromArgb(34, 36, 49);
            refuse_button.Location = new Point(598, 49);
            refuse_button.Name = "refuse_button";
            refuse_button.Size = new Size(161, 39);
            refuse_button.TabIndex = 81;
            refuse_button.Text = "Отказать";
            refuse_button.UseVisualStyleBackColor = false;
            refuse_button.Click += refuse_button_Click;
            // 
            // id_label
            // 
            id_label.BackColor = Color.FromArgb(34, 36, 49);
            id_label.BorderStyle = BorderStyle.None;
            id_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id_label.ForeColor = Color.FromArgb(78, 184, 206);
            id_label.Location = new Point(143, 54);
            id_label.MaxLength = 3;
            id_label.Name = "id_label";
            id_label.Size = new Size(45, 27);
            id_label.TabIndex = 80;
            id_label.KeyPress += id_label_KeyPress;
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
            back_button.Location = new Point(785, 49);
            back_button.Name = "back_button";
            back_button.Size = new Size(161, 39);
            back_button.TabIndex = 75;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // approve_button
            // 
            approve_button.BackColor = Color.FromArgb(78, 184, 206);
            approve_button.Cursor = Cursors.Hand;
            approve_button.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            approve_button.FlatAppearance.BorderSize = 0;
            approve_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            approve_button.FlatStyle = FlatStyle.Flat;
            approve_button.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            approve_button.ForeColor = Color.FromArgb(34, 36, 49);
            approve_button.Location = new Point(411, 49);
            approve_button.Name = "approve_button";
            approve_button.Size = new Size(161, 39);
            approve_button.TabIndex = 74;
            approve_button.Text = "Одобрить";
            approve_button.UseVisualStyleBackColor = false;
            approve_button.Click += approve_button_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(143, 86);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(45, 1);
            panel4.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(78, 184, 206);
            label3.Location = new Point(37, 59);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 64;
            label3.Text = "id клиента";
            // 
            // credit_applications_dataGridView
            // 
            credit_applications_dataGridView.AllowUserToAddRows = false;
            credit_applications_dataGridView.AllowUserToDeleteRows = false;
            credit_applications_dataGridView.AllowUserToResizeColumns = false;
            credit_applications_dataGridView.AllowUserToResizeRows = false;
            credit_applications_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            credit_applications_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            credit_applications_dataGridView.Location = new Point(1, 0);
            credit_applications_dataGridView.Name = "credit_applications_dataGridView";
            credit_applications_dataGridView.ReadOnly = true;
            credit_applications_dataGridView.RowHeadersVisible = false;
            credit_applications_dataGridView.RowHeadersWidth = 51;
            credit_applications_dataGridView.RowTemplate.Height = 29;
            credit_applications_dataGridView.Size = new Size(985, 365);
            credit_applications_dataGridView.TabIndex = 6;
            // 
            // CreditApplicationsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 473);
            Controls.Add(credit_applications_dataGridView);
            Controls.Add(panel1);
            Name = "CreditApplicationsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreditApplicationsView";
            FormClosed += CreditApplicationsView_FormClosed;
            Load += CreditApplicationsView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)credit_applications_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox id_label;
        private TextBox sum_label;
        private Label label9;
        private Button back_button;
        private Button approve_button;
        private Panel panel4;
        private Label label3;
        private DataGridView credit_applications_dataGridView;
        private Button refuse_button;
    }
}