﻿namespace Project
{
    partial class EmployeeAccountView
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
            panel2 = new Panel();
            ViewingClients_Button = new Button();
            viewing_credit_applications_button = new Button();
            back_button = new Button();
            add_credit_button = new Button();
            clients_dataGridView = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clients_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(clients_dataGridView);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-10, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 561);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            panel2.Controls.Add(ViewingClients_Button);
            panel2.Controls.Add(viewing_credit_applications_button);
            panel2.Controls.Add(back_button);
            panel2.Controls.Add(add_credit_button);
            panel2.Location = new Point(17, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 363);
            panel2.TabIndex = 1;
            // 
            // ViewingClients_Button
            // 
            ViewingClients_Button.BackColor = Color.FromArgb(34, 36, 49);
            ViewingClients_Button.Cursor = Cursors.Hand;
            ViewingClients_Button.FlatAppearance.BorderSize = 0;
            ViewingClients_Button.FlatStyle = FlatStyle.Flat;
            ViewingClients_Button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ViewingClients_Button.ForeColor = Color.FromArgb(78, 184, 206);
            ViewingClients_Button.Location = new Point(13, 23);
            ViewingClients_Button.Margin = new Padding(3, 4, 3, 4);
            ViewingClients_Button.Name = "ViewingClients_Button";
            ViewingClients_Button.Size = new Size(203, 69);
            ViewingClients_Button.TabIndex = 8;
            ViewingClients_Button.Text = "Просмотр клиентов";
            ViewingClients_Button.UseVisualStyleBackColor = false;
            ViewingClients_Button.Click += ViewingClients_Button_Click;
            // 
            // viewing_credit_applications_button
            // 
            viewing_credit_applications_button.BackColor = Color.FromArgb(34, 36, 49);
            viewing_credit_applications_button.Cursor = Cursors.Hand;
            viewing_credit_applications_button.FlatAppearance.BorderSize = 0;
            viewing_credit_applications_button.FlatStyle = FlatStyle.Flat;
            viewing_credit_applications_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            viewing_credit_applications_button.ForeColor = Color.FromArgb(78, 184, 206);
            viewing_credit_applications_button.Location = new Point(13, 188);
            viewing_credit_applications_button.Margin = new Padding(3, 4, 3, 4);
            viewing_credit_applications_button.Name = "viewing_credit_applications_button";
            viewing_credit_applications_button.Size = new Size(203, 69);
            viewing_credit_applications_button.TabIndex = 12;
            viewing_credit_applications_button.Text = "Просмотр заявок на кредит";
            viewing_credit_applications_button.UseVisualStyleBackColor = false;
            viewing_credit_applications_button.Click += viewing_credit_applications_button_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(34, 36, 49);
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            back_button.ForeColor = Color.FromArgb(78, 184, 206);
            back_button.Location = new Point(13, 271);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(203, 69);
            back_button.TabIndex = 10;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // add_credit_button
            // 
            add_credit_button.BackColor = Color.FromArgb(34, 36, 49);
            add_credit_button.Cursor = Cursors.Hand;
            add_credit_button.FlatAppearance.BorderSize = 0;
            add_credit_button.FlatStyle = FlatStyle.Flat;
            add_credit_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            add_credit_button.ForeColor = Color.FromArgb(78, 184, 206);
            add_credit_button.Location = new Point(13, 105);
            add_credit_button.Margin = new Padding(3, 4, 3, 4);
            add_credit_button.Name = "add_credit_button";
            add_credit_button.Size = new Size(203, 69);
            add_credit_button.TabIndex = 11;
            add_credit_button.Text = "Добавить кредит";
            add_credit_button.UseVisualStyleBackColor = false;
            add_credit_button.Click += add_credit_button_Click;
            // 
            // clients_dataGridView
            // 
            clients_dataGridView.AllowUserToAddRows = false;
            clients_dataGridView.AllowUserToDeleteRows = false;
            clients_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clients_dataGridView.BackgroundColor = Color.FromArgb(34, 36, 49);
            clients_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clients_dataGridView.GridColor = Color.White;
            clients_dataGridView.Location = new Point(272, 81);
            clients_dataGridView.Margin = new Padding(3, 4, 3, 4);
            clients_dataGridView.Name = "clients_dataGridView";
            clients_dataGridView.ReadOnly = true;
            clients_dataGridView.RowHeadersVisible = false;
            clients_dataGridView.RowHeadersWidth = 51;
            clients_dataGridView.RowTemplate.Height = 25;
            clients_dataGridView.Size = new Size(759, 361);
            clients_dataGridView.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            panel3.Location = new Point(268, 76);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 372);
            panel3.TabIndex = 14;
            // 
            // EmployeeAccountView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 559);
            Controls.Add(panel1);
            Name = "EmployeeAccountView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAccountView";
            FormClosed += EmployeeAccountView_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clients_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ViewingClients_Button;
        private Button viewing_credit_applications_button;
        private Button back_button;
        private Button add_credit_button;
        private DataGridView clients_dataGridView;
        private Panel panel3;
    }
}