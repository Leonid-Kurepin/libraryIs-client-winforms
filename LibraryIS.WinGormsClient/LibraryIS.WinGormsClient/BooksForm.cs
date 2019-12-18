using System;
using System.Windows.Forms;
using LibraryIS.WinFormsClient;

namespace LibraryIS.WinGormsClient
{
    public partial class Books : Form
    {
        private readonly LibraryIsHttpClient _client;

        public Books(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
