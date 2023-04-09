namespace Project
{
    partial class EmployeeRegistrationView
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
            message_label = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            authorization_label = new Label();
            Employee_RegisterButton = new Button();
            employee_passwordBox = new TextBox();
            employee_loginBox = new TextBox();
            label = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(message_label);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(authorization_label);
            panel1.Controls.Add(Employee_RegisterButton);
            panel1.Controls.Add(employee_passwordBox);
            panel1.Controls.Add(employee_loginBox);
            panel1.Controls.Add(label);
            panel1.Location = new Point(-3, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 563);
            panel1.TabIndex = 3;
            // 
            // message_label
            // 
            message_label.BackColor = Color.Transparent;
            message_label.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            message_label.ForeColor = Color.FromArgb(233, 6, 39);
            message_label.Location = new Point(48, 113);
            message_label.Name = "message_label";
            message_label.Size = new Size(478, 24);
            message_label.TabIndex = 17;
            message_label.Text = "\r\n";
            message_label.TextAlign = ContentAlignment.MiddleCenter;
            message_label.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(144, 228);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 1);
            panel3.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(144, 306);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 1);
            panel5.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 1);
            panel2.TabIndex = 14;
            // 
            // authorization_label
            // 
            authorization_label.AutoSize = true;
            authorization_label.BackColor = Color.FromArgb(34, 36, 49);
            authorization_label.Cursor = Cursors.Hand;
            authorization_label.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorization_label.ForeColor = Color.FromArgb(78, 184, 206);
            authorization_label.Location = new Point(202, 478);
            authorization_label.Name = "authorization_label";
            authorization_label.Size = new Size(174, 32);
            authorization_label.TabIndex = 8;
            authorization_label.Text = "Авторизация";
            authorization_label.TextAlign = ContentAlignment.MiddleCenter;
            authorization_label.Click += authorization_label_Click;
            authorization_label.MouseLeave += authorization_label_MouseLeave;
            authorization_label.MouseHover += authorization_label_MouseHover;
            // 
            // Employee_RegisterButton
            // 
            Employee_RegisterButton.BackColor = Color.FromArgb(78, 184, 206);
            Employee_RegisterButton.Cursor = Cursors.Hand;
            Employee_RegisterButton.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            Employee_RegisterButton.FlatAppearance.BorderSize = 0;
            Employee_RegisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            Employee_RegisterButton.FlatStyle = FlatStyle.Flat;
            Employee_RegisterButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Employee_RegisterButton.ForeColor = Color.FromArgb(34, 36, 49);
            Employee_RegisterButton.Location = new Point(142, 408);
            Employee_RegisterButton.Name = "Employee_RegisterButton";
            Employee_RegisterButton.Size = new Size(290, 57);
            Employee_RegisterButton.TabIndex = 7;
            Employee_RegisterButton.Text = "Зарегистрироваться";
            Employee_RegisterButton.UseVisualStyleBackColor = false;
            Employee_RegisterButton.Click += Employee_RegisterButton_Click;
            // 
            // employee_passwordBox
            // 
            employee_passwordBox.BackColor = Color.FromArgb(34, 36, 49);
            employee_passwordBox.BorderStyle = BorderStyle.None;
            employee_passwordBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            employee_passwordBox.ForeColor = Color.WhiteSmoke;
            employee_passwordBox.Location = new Point(144, 274);
            employee_passwordBox.MaxLength = 15;
            employee_passwordBox.Name = "employee_passwordBox";
            employee_passwordBox.Size = new Size(287, 22);
            employee_passwordBox.TabIndex = 6;
            employee_passwordBox.TabStop = false;
            employee_passwordBox.Text = "Пароль";
            // 
            // employee_loginBox
            // 
            employee_loginBox.BackColor = Color.FromArgb(34, 36, 49);
            employee_loginBox.BorderStyle = BorderStyle.None;
            employee_loginBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            employee_loginBox.ForeColor = Color.WhiteSmoke;
            employee_loginBox.Location = new Point(143, 194);
            employee_loginBox.MaxLength = 15;
            employee_loginBox.Name = "employee_loginBox";
            employee_loginBox.Size = new Size(288, 22);
            employee_loginBox.TabIndex = 5;
            employee_loginBox.TabStop = false;
            employee_loginBox.Text = "Логин";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(78, 184, 206);
            label.Location = new Point(202, 57);
            label.Name = "label";
            label.Size = new Size(171, 32);
            label.TabIndex = 2;
            label.Text = "Регистрация";
            label.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeeRegistrationView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 540);
            Controls.Add(panel1);
            Name = "EmployeeRegistrationView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeRegistrationView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label message_label;
        private Label client_registr_label;
        private Panel panel3;
        private Panel panel5;
        private Panel panel2;
        private Label authorization_label;
        private Button Employee_RegisterButton;
        private TextBox employee_passwordBox;
        private TextBox employee_loginBox;
        private Label label;
    }
}