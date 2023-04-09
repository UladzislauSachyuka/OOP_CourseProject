using System;
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

        private void Employee_RegisterButton_Click(object sender, EventArgs e)
        {
            if (employee_loginBox.Text is "" || employee_passwordBox.Text is "")
            {
                message_label.Text = "Все поля обязательны для заполнения";
                message_label.Visible = true;
                return;
            }
            else if (employee_loginBox.TextLength < 4 || employee_passwordBox.TextLength < 4)
            {
                message_label.Text = "Логин и пароль должны содержать от 4 до 15 символов";
                message_label.Visible = true;
                return;
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
    }
}
