﻿using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Project.ViewModels;
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
    public partial class ClientAccountView : Form
    {
        public ClientAccountView()
        {
            InitializeComponent();
        }

        private void ClientAccountView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileView profileView = new ProfileView();
            profileView.Show();
        }

        private void get_credit_button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @id", dataBase.getConnection());
            command.Parameters.Add("@id", MySqlDbType.UInt32).Value = LoginViewModel.user.Id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (Convert.ToString(table.Rows[0].ItemArray.GetValue(4)) is "")
            {
                MessageBox.Show("Укажите все личные данные");
                return;
            }

            Hide();
            GetCreditView getCreditView = new GetCreditView();
            getCreditView.Show();
        }
    }
}
