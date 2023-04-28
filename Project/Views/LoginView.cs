using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project.Models;
using Project.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class LoginView : Form
    {
        public string login { get; set; }
        public string password { get; set; }
        public User user { get; set; }

        public LoginView()
        {
            InitializeComponent();
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text is "")
            {
                passwordBox.Text = "Пароль";
                passwordBox.PasswordChar = '\0';
            }

            if (loginBox.Text == "Логин")
                loginBox.Clear();
            loginBox.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            if (loginBox.Text is "")
                loginBox.Text = "Логин";

            if (passwordBox.Text == "Пароль")
                passwordBox.Clear();

            passwordBox.PasswordChar = '●';
            passwordBox.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginBox.TextLength < 4 || passwordBox.TextLength < 4)
            {
                message_label.Text = "Логин и пароль должны содержать от 4 до 15 символов";
                message_label.Visible = true;
                return;
            }

            login = loginBox.Text;
            password = passwordBox.Text;

            user = new User();
            user.UserAuth = new UserAuth();
            user.UserAuth.Login = login;
            user.UserAuth.Password = password;

            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_ = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", dataBase.getConnection());
            command_.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            dataBase.OpenConnection();

            adapter.SelectCommand = command_;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                message_label.Text = "Неправильный логин или пароль";
                message_label.Visible = true;
                return;
            }

            user.Id = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
            user.Name = Convert.ToString(table.Rows[0].ItemArray.GetValue(1));
            user.Birthdate = Convert.ToString(table.Rows[0].ItemArray.GetValue(2));
            user.Telephone = Convert.ToString(table.Rows[0].ItemArray.GetValue(3));
            if (table.Rows[0].ItemArray.GetValue(4).ToString() != "")
                user.Salary = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(4));

            dataBase.CloseConnection();


            LoginViewModel loginViewModel = new LoginViewModel(login, password, user);

            if (loginViewModel.IsLoggedIn() == "Employee")
            {
                Hide();
                EmployeeAccountView employeeAccountView = new EmployeeAccountView();
                employeeAccountView.Show();
            }
            else if (loginViewModel.IsLoggedIn() == "Client")
            {
                Hide();
                ClientAccountView clientAccountView = new ClientAccountView();
                clientAccountView.Show();
            }
            else
            {
                message_label.Text = "Неправильный логин или пароль";
            }

        }

        private void employee_registr_label_MouseHover(object sender, EventArgs e)
        {
            employee_registr_label.ForeColor = Color.FromArgb(78, 144, 206);
        }

        private void employee_registr_label_MouseLeave(object sender, EventArgs e)
        {
            employee_registr_label.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void client_registr_label_MouseHover(object sender, EventArgs e)
        {
            client_registr_label.ForeColor = Color.FromArgb(78, 144, 206);
        }

        private void client_registr_label_MouseLeave(object sender, EventArgs e)
        {
            client_registr_label.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void employee_registr_label_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeRegistrationView employee_registr_view = new EmployeeRegistrationView();
            employee_registr_view.Show();
        }

        private void client_registr_label_Click(object sender, EventArgs e)
        {
            Hide();
            ClientRegistrationView client_registr_view = new ClientRegistrationView();
            client_registr_view.Show();
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
