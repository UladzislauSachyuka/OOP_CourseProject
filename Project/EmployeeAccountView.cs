using Microsoft.VisualBasic.Logging;
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `role` = @uR", dataBase.getConnection());
            command.Parameters.Add("@uR", MySqlDbType.VarChar).Value = "client";

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


    }
}
