using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class ProfileViewModel
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string birthdate { get; set; }
        public string telephone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public User user { get; set; }

        public ProfileViewModel(string sur, string name, string patronymic, string birth, string tel, string log, string pass) 
        {
            surname = sur;
            this.name = name;
            this.patronymic = patronymic;
            birthdate = birth;
            telephone = tel;
            login = log;
            password = pass;
            user = LoginViewModel.user;
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
            
            if (table.Rows.Count == 0)
                return false;
            else if (table.Rows.Count == 1 && user.Id == Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0)))
                return false;
            else
                return true;
        }

        public bool SaveChanges()
        {
            bool IsSuccessfully = false;
            DataBase dataBase = new DataBase();
            string fio = surname + " " + name + " " + patronymic;
            string query = "UPDATE users SET fio=@uF,birthdate=@uB,telephone =@uT,login =@uL,password =@uP WHERE id =@uI";
            dataBase.OpenConnection();
            
            MySqlCommand cmd = new MySqlCommand(query, dataBase.getConnection());
            cmd.Parameters.AddWithValue("@uF", fio);
            cmd.Parameters.AddWithValue("@uB", birthdate);
            cmd.Parameters.AddWithValue("@uT", telephone);
            cmd.Parameters.AddWithValue("@uL", login);
            cmd.Parameters.AddWithValue("@uP", password);
            cmd.Parameters.AddWithValue("@uI", user.Id);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                   IsSuccessfully = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataBase.CloseConnection();

            return IsSuccessfully;
        }

    }
}
