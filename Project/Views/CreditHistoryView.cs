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
    public partial class CreditHistoryView : Form
    {
        public CreditHistoryView()
        {
            InitializeComponent();
        }

        private void CreditHistoryView_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients_credits` WHERE `fio` = @fio", dataBase.getConnection());
            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = LoginViewModel.user.Name;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataTable temp = new DataTable();
            temp = table.DefaultView.ToTable(true, "fio", "credit_type", "rate", "sum", "period", "status");
            history_dataGridView.DataSource = temp;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccountView clientAccountView = new ClientAccountView();
            clientAccountView.Show();
        }

        private void CreditHistoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
