namespace Project
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
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 36, 49);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(78, 184, 206);
            button4.Location = new Point(13, 188);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(203, 69);
            button4.TabIndex = 12;
            button4.Text = "Просмотр заявок на кредит";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 36, 49);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(78, 184, 206);
            button2.Location = new Point(13, 271);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(203, 69);
            button2.TabIndex = 10;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 36, 49);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(78, 184, 206);
            button3.Location = new Point(13, 105);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(203, 69);
            button3.TabIndex = 11;
            button3.Text = "Добавить кредит";
            button3.UseVisualStyleBackColor = false;
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
        private Button button4;
        private Button button2;
        private Button button3;
        private DataGridView clients_dataGridView;
        private Panel panel3;
    }
}