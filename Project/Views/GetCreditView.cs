using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Project.Models;
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
    public partial class GetCreditView : Form
    {
        public GetCreditView()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string credit_type = credit_type_comboBox.Text;
            double rate = Convert.ToDouble(credit_rate_label.Text);
            int sum = Convert.ToInt32(sum_label.Text);
            int period = Convert.ToInt32(period_label.Text);

            if (credit_type_comboBox.Text is "" || credit_rate_label.Text is ""
                || sum_label.Text is "" || period_label.Text is "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            Credit credit = new Credit();

            GetCreditViewModel getCreditViewModel = new GetCreditViewModel(LoginViewModel.user.Name, credit_type, rate, sum, period, credit);

            if (getCreditViewModel.GetCredit())
                MessageBox.Show("Заявка на кредит отправлена");
            else
                MessageBox.Show("Ошибка");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccountView clientAccountView = new ClientAccountView();
            clientAccountView.Show();
        }

        private void GetCreditView_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `credits`", dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataTable temp = new DataTable();
            temp = table.DefaultView.ToTable(true, "name", "rate", "sum", "period");
            credits_dataGridView.DataSource = temp;

            credit_type_comboBox.Items.Add("Потребительский");
            credit_type_comboBox.Items.Add("На автомобиль");
            credit_type_comboBox.Items.Add("На образование");
            credit_type_comboBox.Items.Add("Для бизнеса");
            credit_type_comboBox.Items.Add("На жилье");
        }

        private void GetCreditView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
