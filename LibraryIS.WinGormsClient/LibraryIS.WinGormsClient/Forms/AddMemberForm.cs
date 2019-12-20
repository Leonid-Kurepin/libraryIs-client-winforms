using System;
using System.Windows.Forms;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.HttpClient;
using LibraryIS.WinFormsClient.HttpClient.Extensions;

namespace LibraryIS.WinFormsClient.Forms
{
    public partial class AddMemberForm : Form
    {
        private readonly LibraryIsHttpClient _client;

        public AddMemberForm(LibraryIsHttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void AddMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var membersForm = (Members)this.Tag;
            membersForm.Show();
            this.Hide();
        }

        private async void ButtonAddUser_Click(object sender, System.EventArgs e)
        {
            var newMember = new MemberDto()
            {
                Name = textBoxName.Text,
                PassportNumber = int.Parse(textBoxPassportNumber.Text),
                PassportSeries = int.Parse(textBoxPassportSeries.Text),
                DateOfBirth =  DateTime.Parse(textBoxDob.Text),
            };

            if (await _client.AddMemberAsync(newMember))
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
