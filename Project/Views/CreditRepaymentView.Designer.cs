namespace Project.Views
{
    partial class CreditRepaymentView
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
            main_debt_label = new TextBox();
            interest_payment_label = new TextBox();
            sum_label = new TextBox();
            back_button = new Button();
            pay_button = new Button();
            label4 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            credit_balance_label = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(main_debt_label);
            panel1.Controls.Add(interest_payment_label);
            panel1.Controls.Add(sum_label);
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(pay_button);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(credit_balance_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 201);
            panel1.TabIndex = 4;
            // 
            // main_debt_label
            // 
            main_debt_label.BackColor = Color.FromArgb(34, 36, 49);
            main_debt_label.BorderStyle = BorderStyle.None;
            main_debt_label.Enabled = false;
            main_debt_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            main_debt_label.ForeColor = Color.FromArgb(78, 184, 206);
            main_debt_label.Location = new Point(512, 74);
            main_debt_label.MaxLength = 8;
            main_debt_label.Name = "main_debt_label";
            main_debt_label.Size = new Size(202, 27);
            main_debt_label.TabIndex = 81;
            // 
            // interest_payment_label
            // 
            interest_payment_label.BackColor = Color.FromArgb(34, 36, 49);
            interest_payment_label.BorderStyle = BorderStyle.None;
            interest_payment_label.Enabled = false;
            interest_payment_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            interest_payment_label.ForeColor = Color.FromArgb(78, 184, 206);
            interest_payment_label.Location = new Point(294, 74);
            interest_payment_label.MaxLength = 8;
            interest_payment_label.Name = "interest_payment_label";
            interest_payment_label.Size = new Size(129, 27);
            interest_payment_label.TabIndex = 80;
            // 
            // sum_label
            // 
            sum_label.BackColor = Color.FromArgb(34, 36, 49);
            sum_label.BorderStyle = BorderStyle.None;
            sum_label.Enabled = false;
            sum_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sum_label.ForeColor = Color.FromArgb(78, 184, 206);
            sum_label.Location = new Point(794, 74);
            sum_label.MaxLength = 8;
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(153, 27);
            sum_label.TabIndex = 78;
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
            back_button.Location = new Point(839, 149);
            back_button.Name = "back_button";
            back_button.Size = new Size(123, 39);
            back_button.TabIndex = 75;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // pay_button
            // 
            pay_button.BackColor = Color.FromArgb(78, 184, 206);
            pay_button.Cursor = Cursors.Hand;
            pay_button.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            pay_button.FlatAppearance.BorderSize = 0;
            pay_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            pay_button.FlatStyle = FlatStyle.Flat;
            pay_button.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            pay_button.ForeColor = Color.FromArgb(34, 36, 49);
            pay_button.Location = new Point(689, 149);
            pay_button.Name = "pay_button";
            pay_button.Size = new Size(123, 39);
            pay_button.TabIndex = 74;
            pay_button.Text = "Оплатить";
            pay_button.UseVisualStyleBackColor = false;
            pay_button.Click += pay_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(78, 184, 206);
            label4.Location = new Point(794, 28);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 65;
            label4.Text = "Сумма платежа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(78, 184, 206);
            label3.Location = new Point(503, 28);
            label3.Name = "label3";
            label3.Size = new Size(211, 23);
            label3.TabIndex = 64;
            label3.Text = "Погашение осн. долга";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(50, 108);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(900, 1);
            panel7.TabIndex = 63;
            // 
            // credit_balance_label
            // 
            credit_balance_label.BackColor = Color.FromArgb(34, 36, 49);
            credit_balance_label.BorderStyle = BorderStyle.None;
            credit_balance_label.Enabled = false;
            credit_balance_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            credit_balance_label.ForeColor = Color.FromArgb(78, 184, 206);
            credit_balance_label.Location = new Point(50, 74);
            credit_balance_label.MaxLength = 10;
            credit_balance_label.Name = "credit_balance_label";
            credit_balance_label.Size = new Size(164, 27);
            credit_balance_label.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(78, 184, 206);
            label1.Location = new Point(294, 28);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 61;
            label1.Text = "Платеж по %";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(78, 184, 206);
            label2.Location = new Point(50, 28);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 41;
            label2.Text = "Остаток кредита";
            // 
            // CreditRepaymentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 201);
            Controls.Add(panel1);
            Name = "CreditRepaymentView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreditRepaymentView";
            FormClosed += CreditRepaymentView_FormClosed;
            Load += CreditRepaymentView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox main_debt_label;
        private TextBox interest_payment_label;
        private TextBox sum_label;
        private Button back_button;
        private Button pay_button;
        private Label label4;
        private Label label3;
        private Panel panel7;
        private TextBox credit_balance_label;
        private Label label1;
        private Label label2;
    }
}