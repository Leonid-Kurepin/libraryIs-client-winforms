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
    public partial class Members : Form
    {
        private readonly LibraryIsHttpClient _client;

        private int? _selectedMemberIndex;
        private int? _selectedMemberId;

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

        private async void Members_Load(object sender, EventArgs e)
        {
            await UpdateMembersDataGridAsync();
        }

        private async Task UpdateMembersDataGridAsync()
        {
            var responseContent = await _client.GetMembersAsync();
            var membersList = responseContent.Items as List<MemberDto>;

            List<MemberView> members = new List<MemberView>();

            foreach (var memberDto in membersList)
            {
                var memberView = MemberMapper.MapToMemberView(memberDto);
                members.Add(memberView);
            }

            dataGridViewMembers.DataSource = DatatableConverter.ConvertListToDatatable(members);
        }

        private async void ButtonDeleteMember_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId == null)
            {
                return;
            }

            await _client.DeleteMemberAsync((int)_selectedMemberId);

            dataGridViewMembers.Rows.RemoveAt((int)_selectedMemberIndex);

            _selectedMemberIndex = null;
            _selectedMemberId = null;
        }

        private void DataGridViewMembers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            _selectedMemberIndex = dataGridViewMembers.SelectedRows[0].Index;
            _selectedMemberId = (int)dataGridViewMembers.SelectedRows[0].Cells["Id"].Value;
        }

        private void ButtonAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm(_client);
            addMemberForm.Tag = this;
            addMemberForm.ShowDialog();
        }
    }
}
