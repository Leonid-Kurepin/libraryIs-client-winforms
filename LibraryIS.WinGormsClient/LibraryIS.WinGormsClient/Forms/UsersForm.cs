using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.HttpClient;
using LibraryIS.WinFormsClient.HttpClient.Extensions;
using LibraryIS.WinFormsClient.Mappers;
using LibraryIS.WinFormsClient.Views;

namespace LibraryIS.WinFormsClient.Forms
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

        private async void Users_Load(object sender, EventArgs e)
        {
            await UpdateUsersDataGridAsync();
        }

        private async Task UpdateUsersDataGridAsync()
        {
            var responseContent = await _client.GetUsersAsync();
            var usersList = responseContent.Items as List<UserDto>;

            List<UserView> users = new List<UserView>();

            foreach (var userDto in usersList)
            {
                var userView = UserMapper.MapToUserView(userDto);
                users.Add(userView);
            }

            dataGridViewUsers.DataSource = DatatableConverter.ConvertListToDatatable(users);
        }
    }
}
