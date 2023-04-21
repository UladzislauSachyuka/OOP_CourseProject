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
    public partial class ClientAccountView : Form
    {
        public ClientAccountView()
        {
            InitializeComponent();
        }

        private void ViewingClients_Button_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ClientAccountView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileView profileView = new ProfileView();
            profileView.Show();
        }
    }
}
