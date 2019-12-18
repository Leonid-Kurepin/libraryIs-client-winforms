using System;
using System.Net.Http;
using System.Windows.Forms;
using LibraryIS.WinFormsClient;

namespace LibraryIS.WinGormsClient
{
    public partial class MainMenu : Form
    {
        private readonly LibraryIsHttpClient _client; 
        public MainMenu(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            Books booksForm = new Books(_client);
            booksForm.Tag = this;
            booksForm.Show();
            this.Hide();
        }

        private void ButtonMembers_Click(object sender, EventArgs e)
        {
            Users membersForm = new Users(_client);
            membersForm.Tag = this;
            membersForm.Show(this);
            this.Hide();
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            Members usersForm = new Members(_client);
            usersForm.Tag = this;
            usersForm.Show();
            this.Hide();
        }
    }
}
