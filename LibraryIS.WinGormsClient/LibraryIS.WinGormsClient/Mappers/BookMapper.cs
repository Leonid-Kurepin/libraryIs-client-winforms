using System;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.View;
using LibraryIS.WinFormsClient.Views;

namespace LibraryIS.WinFormsClient.Mappers
{
    public static class BookMapper
    {
        public static BookView MapToBookView(BookDto bookDto)
        {
            var author = bookDto.Author;
            var publisher = bookDto.Publisher;

            return new BookView()
            {
                Id = bookDto.Id,
                Title = bookDto.Title,
                AuthorName = author == null ? "" : author.Name,
                PublisherName =  publisher == null ? "" : publisher.Name,
                DateOfPublishing = bookDto.DateOfPublishing,
                Isbn = bookDto.Isbn,
                Summary = bookDto.Summary,
                CountAvailable = bookDto.CountAvailable
            };
        }
    }
}
