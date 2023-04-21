namespace Project.Views
{
    partial class AddCreditView
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
            textBox1 = new TextBox();
            max_period_label = new TextBox();
            max_sum_label = new TextBox();
            min_period_label = new TextBox();
            min_sum_label = new TextBox();
            label10 = new Label();
            label9 = new Label();
            back_button = new Button();
            add_button = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            credit_rate_label = new TextBox();
            label1 = new Label();
            credit_type_comboBox = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(max_period_label);
            panel1.Controls.Add(max_sum_label);
            panel1.Controls.Add(min_period_label);
            panel1.Controls.Add(min_sum_label);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(add_button);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(credit_rate_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(credit_type_comboBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 295);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 36, 49);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
            textBox1.Location = new Point(458, 158);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 82;
            textBox1.Text = "%";
            // 
            // max_period_label
            // 
            max_period_label.BackColor = Color.FromArgb(34, 36, 49);
            max_period_label.BorderStyle = BorderStyle.None;
            max_period_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            max_period_label.ForeColor = Color.FromArgb(78, 184, 206);
            max_period_label.Location = new Point(816, 152);
            max_period_label.MaxLength = 3;
            max_period_label.Name = "max_period_label";
            max_period_label.Size = new Size(90, 27);
            max_period_label.TabIndex = 81;
            max_period_label.KeyPress += max_period_label_KeyPress;
            // 
            // max_sum_label
            // 
            max_sum_label.BackColor = Color.FromArgb(34, 36, 49);
            max_sum_label.BorderStyle = BorderStyle.None;
            max_sum_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            max_sum_label.ForeColor = Color.FromArgb(78, 184, 206);
            max_sum_label.Location = new Point(816, 87);
            max_sum_label.MaxLength = 6;
            max_sum_label.Name = "max_sum_label";
            max_sum_label.Size = new Size(90, 27);
            max_sum_label.TabIndex = 80;
            max_sum_label.KeyPress += max_sum_label_KeyPress;
            // 
            // min_period_label
            // 
            min_period_label.BackColor = Color.FromArgb(34, 36, 49);
            min_period_label.BorderStyle = BorderStyle.None;
            min_period_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            min_period_label.ForeColor = Color.FromArgb(78, 184, 206);
            min_period_label.Location = new Point(692, 152);
            min_period_label.MaxLength = 2;
            min_period_label.Name = "min_period_label";
            min_period_label.Size = new Size(40, 27);
            min_period_label.TabIndex = 79;
            min_period_label.KeyPress += min_period_label_KeyPress;
            // 
            // min_sum_label
            // 
            min_sum_label.BackColor = Color.FromArgb(34, 36, 49);
            min_sum_label.BorderStyle = BorderStyle.None;
            min_sum_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            min_sum_label.ForeColor = Color.FromArgb(78, 184, 206);
            min_sum_label.Location = new Point(692, 87);
            min_sum_label.MaxLength = 3;
            min_sum_label.Name = "min_sum_label";
            min_sum_label.Size = new Size(40, 27);
            min_sum_label.TabIndex = 78;
            min_sum_label.KeyPress += min_sum_label_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(78, 184, 206);
            label10.Location = new Point(912, 162);
            label10.Name = "label10";
            label10.Size = new Size(50, 23);
            label10.TabIndex = 77;
            label10.Text = "мес.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(78, 184, 206);
            label9.Location = new Point(912, 97);
            label9.Name = "label9";
            label9.Size = new Size(48, 23);
            label9.TabIndex = 76;
            label9.Text = "руб.";
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
            back_button.Location = new Point(839, 242);
            back_button.Name = "back_button";
            back_button.Size = new Size(123, 39);
            back_button.TabIndex = 75;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // add_button
            // 
            add_button.BackColor = Color.FromArgb(78, 184, 206);
            add_button.Cursor = Cursors.Hand;
            add_button.FlatAppearance.BorderColor = Color.FromArgb(210, 148, 243);
            add_button.FlatAppearance.BorderSize = 0;
            add_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 148, 243);
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            add_button.ForeColor = Color.FromArgb(34, 36, 49);
            add_button.Location = new Point(689, 242);
            add_button.Name = "add_button";
            add_button.Size = new Size(123, 39);
            add_button.TabIndex = 74;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(816, 184);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 1);
            panel5.TabIndex = 73;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(816, 119);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 1);
            panel4.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(78, 184, 206);
            label8.Location = new Point(761, 162);
            label8.Name = "label8";
            label8.Size = new Size(33, 23);
            label8.TabIndex = 71;
            label8.Text = "до";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(78, 184, 206);
            label7.Location = new Point(761, 97);
            label7.Name = "label7";
            label7.Size = new Size(33, 23);
            label7.TabIndex = 70;
            label7.Text = "до";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(692, 184);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(40, 1);
            panel3.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(692, 119);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(40, 1);
            panel2.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(78, 184, 206);
            label6.Location = new Point(651, 162);
            label6.Name = "label6";
            label6.Size = new Size(30, 23);
            label6.TabIndex = 67;
            label6.Text = "от";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(78, 184, 206);
            label5.Location = new Point(651, 97);
            label5.Name = "label5";
            label5.Size = new Size(30, 23);
            label5.TabIndex = 66;
            label5.Text = "от";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(78, 184, 206);
            label4.Location = new Point(545, 162);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 65;
            label4.Text = "Срок";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(78, 184, 206);
            label3.Location = new Point(545, 97);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 64;
            label3.Text = "Сумма";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(253, 189);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 1);
            panel7.TabIndex = 63;
            // 
            // credit_rate_label
            // 
            credit_rate_label.BackColor = Color.FromArgb(34, 36, 49);
            credit_rate_label.BorderStyle = BorderStyle.None;
            credit_rate_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            credit_rate_label.ForeColor = Color.FromArgb(78, 184, 206);
            credit_rate_label.Location = new Point(253, 154);
            credit_rate_label.MaxLength = 10;
            credit_rate_label.Name = "credit_rate_label";
            credit_rate_label.Size = new Size(169, 27);
            credit_rate_label.TabIndex = 62;
            credit_rate_label.KeyPress += credit_rate_label_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(78, 184, 206);
            label1.Location = new Point(50, 162);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 61;
            label1.Text = "Ставка";
            // 
            // credit_type_comboBox
            // 
            credit_type_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            credit_type_comboBox.FormattingEnabled = true;
            credit_type_comboBox.Location = new Point(253, 97);
            credit_type_comboBox.Name = "credit_type_comboBox";
            credit_type_comboBox.Size = new Size(200, 28);
            credit_type_comboBox.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(78, 184, 206);
            label2.Location = new Point(50, 97);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 41;
            label2.Text = "Вид кредита";
            // 
            // AddCreditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 290);
            Controls.Add(panel1);
            Name = "AddCreditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCreditView";
            FormClosed += AddCreditView_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox credit_type_comboBox;
        private Label label2;
        private Panel panel7;
        private TextBox credit_rate_label;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Button back_button;
        private Button add_button;
        private TextBox max_period_label;
        private TextBox max_sum_label;
        private TextBox min_period_label;
        private TextBox min_sum_label;
        private Label label10;
        private Label label9;
        private TextBox textBox1;
    }
}