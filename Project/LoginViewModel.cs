using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public class LoginViewModel
    {
        public string login { get; set; }
        public string password { get; set; }
        public User user { get; set; }

        public LoginViewModel(string login, string password)
        {
            this.login = login;
            this.password = password;
            //this.user = user;
        }

        public string IsLoggedIn()
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
                return "Null";
            else if (table.Rows[0].ItemArray.Contains("Employee"))
                return "Employee";
            else
                return "Client";
            
        }
    }
}
