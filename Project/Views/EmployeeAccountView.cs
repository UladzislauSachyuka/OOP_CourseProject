using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployeeAccountView : Form
    {
        public EmployeeAccountView()
        {
            InitializeComponent();
        }

        private void ViewingClients_Button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `role` = @role", dataBase.getConnection());
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "client";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataTable temp = new DataTable();
            temp = table.DefaultView.ToTable(true, "id", "fio", "birthdate", "telephone", "salary");
            clients_dataGridView.DataSource = temp;

            dataBase.CloseConnection();
        }

        private void EmployeeAccountView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void add_credit_button_Click(object sender, EventArgs e)
        {
            Hide();
            AddCreditView addCreditView = new AddCreditView();
            addCreditView.Show();
        }

        private void viewing_credit_applications_button_Click(object sender, EventArgs e)
        {
            Hide();
            CreditApplicationsView creditApplicationsView = new CreditApplicationsView();
            creditApplicationsView.Show();
        }
    }
}
