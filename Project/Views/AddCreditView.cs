using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class AddCreditView : Form
    {
        public AddCreditView()
        {
            InitializeComponent();
            credit_type_comboBox.Items.Add("Потребительский");
            credit_type_comboBox.Items.Add("На автомобиль");
            credit_type_comboBox.Items.Add("На образование");
            credit_type_comboBox.Items.Add("Для бизнеса");
            credit_type_comboBox.Items.Add("На жилье");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (credit_type_comboBox.Text is "" || credit_rate_label.Text is "" || min_sum_label.Text is ""
                || max_sum_label.Text is "" || min_period_label.Text is "" || max_period_label.Text is "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            double _rate = Convert.ToDouble(credit_rate_label.Text);
            if (_rate < 3.5)
            {
                MessageBox.Show("Минимальная ставка 3.5 %");
                return;
            }
            else if (_rate > 15)
            {
                MessageBox.Show("Максимальная ставка 15 %");
                return;
            }

            int _min_sum = Convert.ToInt32(min_sum_label.Text);
            if (_min_sum < 50)
            {
                MessageBox.Show("Минимальная сумма 50 рублей");
                return;
            }

            int _max_sum = Convert.ToInt32(max_sum_label.Text);
            if (_max_sum < _min_sum)
            {
                MessageBox.Show("Максимальная сумма не может быть меньше минимальной");
                return;
            }

            int _min_period = Convert.ToInt32(min_period_label.Text);
            if (_min_period < 1)
            {
                MessageBox.Show("Минимальный срок 1 месяц");
                return;
            }

            int _max_period = Convert.ToInt32(max_period_label.Text);
            if (_max_period < _min_period)
            {
                MessageBox.Show("Максимальный срок не может быть меньше минимального");
                return;
            }

            string name = credit_type_comboBox.Text;
            double rate = _rate;
            string sum = "от " + _min_sum.ToString() + " до " + _max_sum.ToString() + " руб.";
            string period = "от " + _min_period.ToString() + " до " + _max_period.ToString() + " мес.";

            AddCreditViewModel addCreditViewModel = new AddCreditViewModel(name, rate, sum, period);

            if (addCreditViewModel.AddCredit())
            {
                Hide();
                EmployeeAccountView employeeAccountView = new EmployeeAccountView();
                employeeAccountView.Show();
                MessageBox.Show("Кредит успешно добавлен");
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeAccountView employeeAccountView = new EmployeeAccountView();
            employeeAccountView.Show();
        }

        private void credit_rate_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && credit_rate_label.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void min_sum_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void max_sum_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void min_period_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void max_period_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddCreditView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
