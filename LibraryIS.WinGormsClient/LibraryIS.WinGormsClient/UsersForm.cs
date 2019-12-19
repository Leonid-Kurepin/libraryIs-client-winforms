using System;
using System.Windows.Forms;

namespace LibraryIS.WinFormsClient
{
    public partial class Users : Form
    {
        private readonly LibraryIsHttpClient _client;

        public Users(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
