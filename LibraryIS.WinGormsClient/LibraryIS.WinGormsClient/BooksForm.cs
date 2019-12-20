using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.HttpClient;
using LibraryIS.WinFormsClient.Mappers;
using LibraryIS.WinFormsClient.Requests;
using LibraryIS.WinFormsClient.View;
using LibraryIS.WinFormsClient.Views;

namespace LibraryIS.WinFormsClient
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

        private async void Books_Load(object sender, EventArgs e)
        {
            await UpdateDataGridAsync();
        }

        private async Task UpdateDataGridAsync()
        {
            var responseContent = await _client.GetBooksAsync();
            var booksList = responseContent.Items as List<BookDto>;

            List<BookView> books = new List<BookView>();

            foreach (var bookDto in booksList)
            {
                var bookView = BookMapper.MapToBookView(bookDto);
                books.Add(bookView);
            }

            dataGridViewBooks.DataSource = DatatableConverter.ConvertListToDatatable(books);
        }
    }
}
