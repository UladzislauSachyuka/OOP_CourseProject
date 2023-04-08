using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text is "")
                passwordBox.Text = "Пароль";

            loginBox.Clear();
            loginBox.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            if (loginBox.Text is "")
                loginBox.Text = "Логин";

            passwordBox.Clear();
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
    }
}
