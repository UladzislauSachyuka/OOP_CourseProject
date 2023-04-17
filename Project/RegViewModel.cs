using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project
{
    public class RegViewModel
    {
        public string surname {  get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string birthdate { get; set; }
        public string telephone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public User user { get; set; }

        public RegViewModel(string sur, string name, string patronymic, string birth, string tel, string log, string pass, User user)
        {
            surname = sur;
            this.name = name;
            this.patronymic = patronymic;
            birthdate = birth;
            telephone = tel;
            login = log;
            password = pass;
            this.user = user;
        }

        public bool IsUserExists()
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool SignUp()
        {
            bool IsSuccessfully = false;
            DataBase dataBase = new DataBase();
            string fio = surname + " " + name + " " + patronymic;
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`fio`, `birthdate`, `telephone`, `role`, `login`, `password`) VALUES (@fio, @birth, @tel, @role, @login, @password)", dataBase.getConnection());

            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@birth", MySqlDbType.VarChar).Value = birthdate;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telephone;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = user.Role;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1) 
                IsSuccessfully = true;

            dataBase.CloseConnection();

            return IsSuccessfully;
        }

    }
}
