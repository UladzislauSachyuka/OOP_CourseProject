﻿using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
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
    public partial class CreditApplicationsView : Form
    {
        public CreditApplicationsView()
        {
            InitializeComponent();
        }

        private void id_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreditApplicationsView_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients_credits` WHERE `status` = @status", dataBase.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "ожидание";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataTable temp = new DataTable();
            temp = table.DefaultView.ToTable(true, "id", "fio", "credit_type", "rate", "sum", "period");
            credit_applications_dataGridView.DataSource = temp;
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients_credits` WHERE `status` = @status", dataBase.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "ожидание";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            List<int> ids = new List<int>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
                ids.Add((int)row["id"]);

            if (!ids.Contains(Convert.ToInt32(id_label.Text)))
            {
                MessageBox.Show("Данный id отсутствует");
                return;
            }

            string query = "UPDATE clients_credits SET status = @status WHERE id =@id";
            dataBase.OpenConnection();

            command = new MySqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@status", "одобрен");

            dataBase.CloseConnection();
        }

        private void refuse_button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients_credits` WHERE `status` = @status", dataBase.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "ожидание";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            List<int> ids = new List<int>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
                ids.Add((int)row["id"]);

            if (!ids.Contains(Convert.ToInt32(id_label.Text)))
            {
                MessageBox.Show("Данный id отсутствует");
                return;
            }

            string query = "UPDATE clients_credits SET status = @status WHERE id =@id";
            dataBase.OpenConnection();

            command = new MySqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@status", "отказано");

            dataBase.CloseConnection();
        }

        private void CreditApplicationsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeAccountView employeeAccountView = new EmployeeAccountView();
            employeeAccountView.Show();
        }
    }
}
