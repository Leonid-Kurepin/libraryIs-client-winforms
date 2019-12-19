using System;
using System.Windows.Forms;

namespace LibraryIS.WinFormsClient
{
    public partial class Auth : Form
    {

        public Auth()
        {
            InitializeComponent();

            labelSignInInfo.Hide();
        }

        private async void ButtonSignIn_ClickAsync(object sender, EventArgs e)
        {
            var urlString = "https://localhost:44330/";
            var client = new LibraryIsHttpClient(urlString);

            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (await client.TryAuthenticateAsync(login, password))
            {
                MainMenu mainMenuForm = new MainMenu(client);
                mainMenuForm.Show();

                this.Hide();
            }
            else
            {
                labelSignInInfo.Show();
            }
        }
    }
}
