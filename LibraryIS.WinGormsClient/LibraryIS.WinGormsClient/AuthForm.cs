using System;
using System.Windows.Forms;

namespace LibraryIS.WinGormsClient
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();

            this.Hide();
        }
    }
}
