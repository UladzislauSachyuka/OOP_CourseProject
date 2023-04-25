using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.ViewModels
{
    public class GetCreditViewModel
    {
        public string fio { get; set; }
        public string credit_name { get; set; }
        public double rate { get; set; }
        public int sum { get; set; }
        public int period { get; set; }

        public GetCreditViewModel(string fio, string credit_name, double rate, int sum, int period) 
        {
            this.fio = fio;
            this.credit_name = credit_name;
            this.rate = rate;
            this.sum = sum;
            this.period = period;
        }

        public bool GetCredit()
        {
            bool IsSuccessfully = false;
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients_credits` (`fio`, `credit_type`, `rate`, `sum`, `period`, `status`) VALUES (@fio, @credit_type, @rate, @sum, @period, @status)", dataBase.getConnection());

            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@credit_type", MySqlDbType.VarChar).Value = credit_name;
            command.Parameters.Add("@rate", MySqlDbType.VarChar).Value = rate;
            command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sum;
            command.Parameters.Add("@period", MySqlDbType.VarChar).Value = period;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "ожидание";

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                IsSuccessfully = true;

            return IsSuccessfully;
        }

    }
}
