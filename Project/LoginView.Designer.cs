namespace Project
{
    partial class LoginView
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
            client_registr_label = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            employee_registr_label = new Label();
            LoginButton = new Button();
            passwordBox = new TextBox();
            loginBox = new TextBox();
            label = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(message_label);
            panel1.Controls.Add(client_registr_label);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(employee_registr_label);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(label);
            panel1.Location = new Point(-6, -17);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 563);
            panel1.TabIndex = 2;
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
            // client_registr_label
            // 
            client_registr_label.AutoSize = true;
            client_registr_label.BackColor = Color.FromArgb(34, 36, 49);
            client_registr_label.Cursor = Cursors.Hand;
            client_registr_label.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            client_registr_label.ForeColor = Color.FromArgb(78, 184, 206);
            client_registr_label.Location = new Point(345, 465);
            client_registr_label.Name = "client_registr_label";
            client_registr_label.Size = new Size(171, 64);
            client_registr_label.TabIndex = 16;
            client_registr_label.Text = "Регистрация\r\nклиента";
            client_registr_label.TextAlign = ContentAlignment.MiddleCenter;
            client_registr_label.Click += employee_registr_label_MouseHover;
            client_registr_label.MouseLeave += client_registr_label_MouseLeave;
            client_registr_label.MouseHover += client_registr_label_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(137, 228);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 1);
            panel3.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(137, 306);
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
            // employee_registr_label
            // 
            employee_registr_label.AutoSize = true;
            employee_registr_label.BackColor = Color.FromArgb(34, 36, 49);
            employee_registr_label.Cursor = Cursors.Hand;
            employee_registr_label.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            employee_registr_label.ForeColor = Color.FromArgb(78, 184, 206);
            employee_registr_label.Location = new Point(56, 465);
            employee_registr_label.Name = "employee_registr_label";
            employee_registr_label.Size = new Size(171, 64);
            employee_registr_label.TabIndex = 8;
            employee_registr_label.Text = "Регистрация\r\nсотрудника";
            employee_registr_label.TextAlign = ContentAlignment.MiddleCenter;
            employee_registr_label.Click += employee_registr_label_Click;
            employee_registr_label.MouseLeave += employee_registr_label_MouseLeave;
            employee_registr_label.MouseHover += employee_registr_label_MouseHover;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(78, 184, 206);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.FromArgb(34, 36, 49);
            LoginButton.Location = new Point(198, 408);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(158, 39);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.FromArgb(34, 36, 49);
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.ForeColor = Color.WhiteSmoke;
            passwordBox.Location = new Point(137, 274);
            passwordBox.MaxLength = 15;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(287, 22);
            passwordBox.TabIndex = 6;
            passwordBox.TabStop = false;
            passwordBox.Text = "Пароль";
            passwordBox.Click += passwordBox_Click;
            // 
            // loginBox
            // 
            loginBox.BackColor = Color.FromArgb(34, 36, 49);
            loginBox.BorderStyle = BorderStyle.None;
            loginBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.ForeColor = Color.WhiteSmoke;
            loginBox.Location = new Point(139, 194);
            loginBox.MaxLength = 15;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(288, 22);
            loginBox.TabIndex = 5;
            loginBox.TabStop = false;
            loginBox.Text = "Логин";
            loginBox.Click += loginBox_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(78, 184, 206);
            label.Location = new Point(190, 57);
            label.Name = "label";
            label.Size = new Size(174, 32);
            label.TabIndex = 2;
            label.Text = "Авторизация";
            label.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 540);
            Controls.Add(panel1);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBox3;
        private Label employee_registr_label;
        private Button LoginButton;
        private Button button1;
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label label;
        private Label client_registr_label;
        private Label message_label;
    }
}