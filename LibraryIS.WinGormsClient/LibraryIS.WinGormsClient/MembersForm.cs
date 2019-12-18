using System;
using System.Windows.Forms;
using LibraryIS.WinFormsClient;

namespace LibraryIS.WinGormsClient
{
    public partial class Members : Form
    {
        private readonly LibraryIsHttpClient _client;

        public Members(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
