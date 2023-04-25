namespace Project
{
    partial class ClientAccountView
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
            panel2 = new Panel();
            back_button = new Button();
            button5 = new Button();
            button1 = new Button();
            get_credit_button = new Button();
            button4 = new Button();
            profile_button = new Button();
            button = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            panel2.Controls.Add(back_button);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(get_credit_button);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(profile_button);
            panel2.Controls.Add(button);
            panel2.Location = new Point(14, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 567);
            panel2.TabIndex = 2;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(34, 36, 49);
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            back_button.ForeColor = Color.FromArgb(78, 184, 206);
            back_button.Location = new Point(13, 488);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(203, 69);
            back_button.TabIndex = 15;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(34, 36, 49);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(78, 184, 206);
            button5.Location = new Point(13, 248);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(203, 69);
            button5.TabIndex = 14;
            button5.Text = "Погашение кредита";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 36, 49);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(78, 184, 206);
            button1.Location = new Point(13, 328);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(203, 69);
            button1.TabIndex = 13;
            button1.Text = "Кредитная история";
            button1.UseVisualStyleBackColor = false;
            // 
            // get_credit_button
            // 
            get_credit_button.BackColor = Color.FromArgb(34, 36, 49);
            get_credit_button.Cursor = Cursors.Hand;
            get_credit_button.FlatAppearance.BorderSize = 0;
            get_credit_button.FlatStyle = FlatStyle.Flat;
            get_credit_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            get_credit_button.ForeColor = Color.FromArgb(78, 184, 206);
            get_credit_button.Location = new Point(13, 8);
            get_credit_button.Margin = new Padding(3, 4, 3, 4);
            get_credit_button.Name = "get_credit_button";
            get_credit_button.Size = new Size(203, 69);
            get_credit_button.TabIndex = 8;
            get_credit_button.Text = "Получить кредит";
            get_credit_button.UseVisualStyleBackColor = false;
            get_credit_button.Click += get_credit_button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 36, 49);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(78, 184, 206);
            button4.Location = new Point(13, 168);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(203, 69);
            button4.TabIndex = 12;
            button4.Text = "Статус заявки";
            button4.UseVisualStyleBackColor = false;
            // 
            // profile_button
            // 
            profile_button.BackColor = Color.FromArgb(34, 36, 49);
            profile_button.Cursor = Cursors.Hand;
            profile_button.FlatAppearance.BorderSize = 0;
            profile_button.FlatStyle = FlatStyle.Flat;
            profile_button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            profile_button.ForeColor = Color.FromArgb(78, 184, 206);
            profile_button.Location = new Point(13, 408);
            profile_button.Margin = new Padding(3, 4, 3, 4);
            profile_button.Name = "profile_button";
            profile_button.Size = new Size(203, 69);
            profile_button.TabIndex = 10;
            profile_button.Text = "Личные данные";
            profile_button.UseVisualStyleBackColor = false;
            profile_button.Click += profile_button_Click;
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(34, 36, 49);
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button.ForeColor = Color.FromArgb(78, 184, 206);
            button.Location = new Point(13, 88);
            button.Margin = new Padding(3, 4, 3, 4);
            button.Name = "button";
            button.Size = new Size(203, 69);
            button.TabIndex = 11;
            button.Text = "Просмотр условий кредитования";
            button.UseVisualStyleBackColor = false;
            // 
            // ClientAccountView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1036, 622);
            Controls.Add(panel2);
            Name = "ClientAccountView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientAccountView";
            FormClosed += ClientAccountView_FormClosed;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button get_credit_button;
        private Button button4;
        private Button profile_button;
        private Button button;
        private Button button5;
        private Button button1;
        private Button back_button;
    }
}