using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using Project.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class EmployeeRegistrationView : Form
    {
        public EmployeeRegistrationView()
        {
            InitializeComponent();
        }

        private void authorization_label_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void Client_RegisterButton_Click(object sender, EventArgs e)
        {
            string surname = surname_label.Text;
            string name = name_label.Text;
            string patronymic = patronymic_label.Text;
            string birth = date_label.Text;
            string telephone = telephone_label.Text;
            string login = login_label.Text;
            string password = password_label.Text;

            if (surname_label.Text is "" || name_label.Text is "" || patronymic_label.Text is ""
                || date_label.Text is "" || telephone_label.Text is "" || login_label.Text is ""
                || password_label.Text is "" || confirm_password_label.Text is "")
            {
                message_label.Text = "Все поля обязательны для заполнения";
                message_label.Visible = true;
                return;
            }
            else if (surname_label.Text.Any(char.IsDigit) || name_label.Text.Any(char.IsDigit) || patronymic_label.Text.Any(char.IsDigit))
            {
                message_label.Text = "Поля для заполнения ФИО не должны содержать цифры";
                message_label.Visible = true;
                return;
            }

            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(date_label.Text.Trim());
            DateTime date;
            isValid = DateTime.TryParseExact(date_label.Text, "dd.MM.yyyy", new CultureInfo("ru-RU"), DateTimeStyles.None, out date);
            if (!isValid)
            {
                message_label.Text = "Некорректная дата";
                message_label.Visible = true;
                return;
            }

            if (telephone_label.TextLength != 12)
            {
                message_label.Text = "Телефон должен содеражать 12 цифр";
                message_label.Visible = true;
                return;
            }

            if (password_label.TextLength < 4)
            {
                message_label.Text = "Пароль должен содержать от 4 до 15 символов";
                message_label.Visible = true;
                return;
            }

            if (password_label.Text != confirm_password_label.Text)
            {
                message_label.Text = "Пароли не совпадают";
                message_label.Visible = true;
                return;
            }

            User user = new User();
            user.Role = "Employee";

            RegViewModel registration = new RegViewModel(surname, name, patronymic, birth, telephone, login, password, user);

            if (registration.IsUserExists())
            {
                message_label.Text = "Такой логин уже существует";
                message_label.Visible = true;
                return;
            }

            if (registration.SignUp())
            {
                Hide();
                LoginView loginView = new LoginView();
                loginView.Show();
                MessageBox.Show("Аккаунт успешно создан!");
            }
            else
            {
                MessageBox.Show("Ошибка! Аккаунт не был создан!");
            }

        }

        private void authorization_label_MouseHover(object sender, EventArgs e)
        {
            authorization_label.ForeColor = Color.FromArgb(78, 144, 206);
        }

        private void authorization_label_MouseLeave(object sender, EventArgs e)
        {
            authorization_label.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void surname_label_TextChanged(object sender, EventArgs e)
        {
            surname_label.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.surname_label.Text);
            surname_label.Select(surname_label.Text.Length, 0);
        }

        private void name_label_TextChanged(object sender, EventArgs e)
        {
            name_label.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name_label.Text);
            name_label.Select(name_label.Text.Length, 0);
        }

        private void patronymic_label_TextChanged(object sender, EventArgs e)
        {
            patronymic_label.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(patronymic_label.Text);
            patronymic_label.Select(patronymic_label.Text.Length, 0);
        }

        private void telephone_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmployeeRegistrationView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
