using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class AddCreditViewModel
    {
        public string name { get; set; }
        public double rate { get; set; }
        public string sum { get; set; }
        public string period { get; set; }

        public AddCreditViewModel(string name, double rate, string sum, string period) 
        {
            this.name = name;
            this.rate = rate;
            this.sum = sum;
            this.period = period;
        }

        public bool AddCredit()
        {
            bool IsSuccessfully = false;
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `credits` (`name`, `rate`, `sum`, `period`) VALUES (@name, @rate, @sum, @period)", dataBase.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@rate", MySqlDbType.Double).Value = rate;
            command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sum;
            command.Parameters.Add("@period", MySqlDbType.VarChar).Value = period;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsSuccessfully = true;

            dataBase.CloseConnection();

            return IsSuccessfully;
        }

    }
}
