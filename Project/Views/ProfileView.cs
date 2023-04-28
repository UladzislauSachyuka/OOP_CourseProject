using MySql.Data.MySqlClient;
using Project.ViewModels;
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

namespace Project
{
    public partial class ProfileView : Form
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void save_changes_button_Click(object sender, EventArgs e)
        {
            string surname = surname_label.Text;
            string name = name_label.Text;
            string patronymic = patronymic_label.Text;
            string birth = date_label.Text;
            string telephone = telephone_label.Text;
            string salary = salary_label.Text;
            string login = login_label.Text;
            string password = password_label.Text;

            if (surname_label.Text is "" || name_label.Text is "" || patronymic_label.Text is ""
                || date_label.Text is "" || telephone_label.Text is "" || salary_label.Text is ""
                || login_label.Text is "" || password_label.Text is "")
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

            ProfileViewModel profileViewModel = new ProfileViewModel(surname, name, patronymic, birth, telephone, salary, login, password);

            if (profileViewModel.IsUserExists())
            {
                message_label.Text = "Такой логин уже существует";
                message_label.Visible = true;
                return;
            }

            if (profileViewModel.SaveChanges())
                MessageBox.Show("Данные успешно сохранены");
            else
                MessageBox.Show("Ошибка");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            ClientAccountView clientAccountView = new ClientAccountView();
            clientAccountView.Show();
        }

        private void ProfileView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void salary_label_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            surname_label.DeselectAll();
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @id", dataBase.getConnection());
            command.Parameters.Add("@id", MySqlDbType.UInt32).Value = LoginViewModel.user.Id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string fio = Convert.ToString(table.Rows[0].ItemArray.GetValue(1));
            surname_label.Text = fio.Split()[0];
            name_label.Text = fio.Split()[1];
            patronymic_label.Text = fio.Split()[2];
            date_label.Text = Convert.ToString(table.Rows[0].ItemArray.GetValue(2));
            telephone_label.Text = Convert.ToString(table.Rows[0].ItemArray.GetValue(3));
            salary_label.Text = Convert.ToString(table.Rows[0].ItemArray.GetValue(4));
            login_label.Text = Convert.ToString(table.Rows[0].ItemArray.GetValue(6));
            password_label.Text = Convert.ToString(table.Rows[0].ItemArray.GetValue(7));
        }
    }
}
