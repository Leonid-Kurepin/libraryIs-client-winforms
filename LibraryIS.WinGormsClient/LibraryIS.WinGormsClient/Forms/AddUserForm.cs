using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.HttpClient;
using LibraryIS.WinFormsClient.HttpClient.Extensions;

namespace LibraryIS.WinFormsClient.Forms
{
    public partial class AddUserForm : Form
    {
        private readonly LibraryIsHttpClient _client;

        public AddUserForm(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var usersForm = (Users) this.Tag;
            usersForm.Show();
            this.Hide();
        }

        private async void ButtonAddUser_Click(object sender, System.EventArgs e)
        {
            var newUser = new UserDto()
            {
                Name = textBoxName.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text,
                Role = textBoxRole.Text
            };

            if (await _client.AddUserAsync(newUser))
            {
                this.Close();
            }
            else
            {
                labelErrorMessage.Show();
            }
        }
    }
}
