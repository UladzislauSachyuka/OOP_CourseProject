﻿using System;
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
    public partial class ClientRegistrationView : Form
    {
        public ClientRegistrationView()
        {
            InitializeComponent();
        }

        private void Client_RegisterButton_Click(object sender, EventArgs e)
        {
            if (surname_label.Text is "" || name_label.Text is "" || patronymic_label.Text is ""
                || date_label.Text is "" || series_label.Text is "" || passport_label.Text is ""
                || password_client_label.Text is "" || confirm_password_label.Text is "")
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
        }

        private void authorization_label_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void surname_label_TextChanged(object sender, EventArgs e)
        {
            surname_label.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.surname_label.Text);
            surname_label.Select(surname_label.Text.Length, 0);
        }

        private void authorization_label_MouseHover(object sender, EventArgs e)
        {
            authorization_label.ForeColor = Color.FromArgb(78, 144, 206);
        }

        private void authorization_label_MouseLeave(object sender, EventArgs e)
        {
            authorization_label.ForeColor = Color.FromArgb(78, 184, 206);
        }
    }
}
