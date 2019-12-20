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

        private int? _selectedUserIndex;
        private int? _selectedUserId;

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

        private void DataGridViewUsers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            _selectedUserIndex = dataGridViewUsers.SelectedRows[0].Index;
            _selectedUserId = (int) dataGridViewUsers.SelectedRows[0].Cells["Id"].Value;
        }

        private async void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                return;
            }

            await _client.DeleteUserAsync((int) _selectedUserId);

            dataGridViewUsers.Rows.RemoveAt((int) _selectedUserIndex);

            _selectedUserIndex = null;
            _selectedUserId = null;

        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(_client);
            addUserForm.Tag = this;
            addUserForm.ShowDialog();
        }
    }
}
