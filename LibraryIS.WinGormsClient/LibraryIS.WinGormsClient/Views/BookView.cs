using System;

namespace LibraryIS.WinFormsClient.Views
{
    public class BookView
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public DateTime? DateOfPublishing { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public int? CountAvailable { get; set; }
    }
}
