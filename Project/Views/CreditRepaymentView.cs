using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
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
    public partial class CreditRepaymentView : Form
    {
        public CreditRepaymentView()
        {
            InitializeComponent();
        }

        private void CreditRepaymentView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreditRepaymentView_Load(object sender, EventArgs e)
        {
            credit_balance_label.Text = LoginViewModel.user.CreditRepayment.Balance.ToString();
            interest_payment_label.Text = LoginViewModel.user.CreditRepayment.InterestPayment.ToString();
            main_debt_label.Text = LoginViewModel.user.CreditRepayment.MainDebt.ToString();
            sum_label.Text = LoginViewModel.user.CreditRepayment.Sum.ToString();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            LoginViewModel.user.CreditRepayment.Balance -= LoginViewModel.user.CreditRepayment.MainDebt;         
            LoginViewModel.user.CreditRepayment.InterestPayment = LoginViewModel.user.CreditRepayment.Balance * LoginViewModel.user.CreditRepayment.Rate / 100 / 12;
            LoginViewModel.user.CreditRepayment.Sum = LoginViewModel.user.CreditRepayment.InterestPayment + LoginViewModel.user.CreditRepayment.MainDebt;

            if (LoginViewModel.user.CreditRepayment.Balance - LoginViewModel.user.CreditRepayment.MainDebt < 1)
            {
                LoginViewModel.user.CreditRepayment.MainDebt = LoginViewModel.user.CreditRepayment.Balance;
            }

            if (LoginViewModel.user.CreditRepayment.Balance == 0)
            {
                DataBase data = new DataBase();
                string qu = "DELETE FROM credit_repayments WHERE fio = @fio";
                data.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(qu, data.getConnection());
                cmd.Parameters.AddWithValue("@fio", LoginViewModel.user.Name);

                cmd.ExecuteNonQuery();

                data.CloseConnection();

                MessageBox.Show("Вы погасили кредит");
            }
            else
            {
                DataBase dataBase = new DataBase();
                string query = "UPDATE credit_repayments SET balance = @balance, interest_payment = @interest_payment, main_debt = @main_debt, sum = @sum WHERE fio = @fio";
                dataBase.OpenConnection();

                MySqlCommand command = new MySqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@balance", Math.Round(LoginViewModel.user.CreditRepayment.Balance, 2));
                command.Parameters.AddWithValue("@interest_payment", Math.Round(LoginViewModel.user.CreditRepayment.InterestPayment, 2));
                command.Parameters.AddWithValue("@main_debt", Math.Round(LoginViewModel.user.CreditRepayment.MainDebt, 2));
                command.Parameters.AddWithValue("@sum", Math.Round(LoginViewModel.user.CreditRepayment.Sum, 2));
                command.Parameters.AddWithValue("@fio", LoginViewModel.user.Name);

                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Оплата прошла успешно");
            }

            Hide();
            ClientAccountView clientAccountView = new ClientAccountView();
            clientAccountView.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccountView clientAccountView = new ClientAccountView();
            clientAccountView.Show();
        }
    }
}
