namespace Project.Views
{
    partial class GetCreditView
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
            period_label = new TextBox();
            sum_label = new TextBox();
            label10 = new Label();
            label9 = new Label();
            back_button = new Button();
            add_button = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            credit_rate_label = new TextBox();
            label1 = new Label();
            credit_type_comboBox = new ComboBox();
            label2 = new Label();
            credits_dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)credits_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(period_label);
            panel1.Controls.Add(sum_label);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(add_button);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(credit_rate_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(credit_type_comboBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 295);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 36, 49);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
            textBox1.Location = new Point(495, 158);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 82;
            textBox1.Text = "%";
            // 
            // period_label
            // 
            period_label.BackColor = Color.FromArgb(34, 36, 49);
            period_label.BorderStyle = BorderStyle.None;
            period_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            period_label.ForeColor = Color.FromArgb(78, 184, 206);
            period_label.Location = new Point(752, 152);
            period_label.MaxLength = 3;
            period_label.Name = "period_label";
            period_label.Size = new Size(90, 27);
            period_label.TabIndex = 81;
            // 
            // sum_label
            // 
            sum_label.BackColor = Color.FromArgb(34, 36, 49);
            sum_label.BorderStyle = BorderStyle.None;
            sum_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sum_label.ForeColor = Color.FromArgb(78, 184, 206);
            sum_label.Location = new Point(752, 87);
            sum_label.MaxLength = 6;
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(90, 27);
            sum_label.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(78, 184, 206);
            label10.Location = new Point(848, 162);
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
            label9.Location = new Point(848, 97);
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
            back_button.Location = new Point(802, 242);
            back_button.Name = "back_button";
            back_button.Size = new Size(161, 39);
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
            add_button.Location = new Point(620, 242);
            add_button.Name = "add_button";
            add_button.Size = new Size(161, 39);
            add_button.TabIndex = 74;
            add_button.Text = "Подтвердить";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(752, 184);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 1);
            panel5.TabIndex = 73;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(752, 119);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 1);
            panel4.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(78, 184, 206);
            label4.Location = new Point(667, 162);
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
            label3.Location = new Point(667, 97);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 64;
            label3.Text = "Сумма";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(290, 189);
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
            credit_rate_label.Location = new Point(290, 154);
            credit_rate_label.MaxLength = 10;
            credit_rate_label.Name = "credit_rate_label";
            credit_rate_label.Size = new Size(169, 27);
            credit_rate_label.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(78, 184, 206);
            label1.Location = new Point(87, 162);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 61;
            label1.Text = "Ставка";
            // 
            // credit_type_comboBox
            // 
            credit_type_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            credit_type_comboBox.FormattingEnabled = true;
            credit_type_comboBox.Location = new Point(290, 97);
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
            label2.Location = new Point(87, 97);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 41;
            label2.Text = "Вид кредита";
            // 
            // credits_dataGridView
            // 
            credits_dataGridView.AllowUserToAddRows = false;
            credits_dataGridView.AllowUserToDeleteRows = false;
            credits_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            credits_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            credits_dataGridView.Location = new Point(0, 0);
            credits_dataGridView.Name = "credits_dataGridView";
            credits_dataGridView.ReadOnly = true;
            credits_dataGridView.RowHeadersVisible = false;
            credits_dataGridView.RowHeadersWidth = 51;
            credits_dataGridView.RowTemplate.Height = 29;
            credits_dataGridView.Size = new Size(985, 372);
            credits_dataGridView.TabIndex = 5;
            // 
            // GetCreditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 664);
            Controls.Add(credits_dataGridView);
            Controls.Add(panel1);
            Name = "GetCreditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetCreditView";
            FormClosed += GetCreditView_FormClosed;
            Load += GetCreditView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)credits_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox period_label;
        private TextBox sum_label;
        private Label label10;
        private Label label9;
        private Button back_button;
        private Button add_button;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Panel panel7;
        private TextBox credit_rate_label;
        private Label label1;
        private ComboBox credit_type_comboBox;
        private Label label2;
        private DataGridView credits_dataGridView;
    }
}