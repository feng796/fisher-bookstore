using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id =65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();

            Assert.Equal(expectedPublicationDate, actualPublicationDate);
        }

        public void ChangeISBN()
        {
            var book = new Book()
            {
                Id = 2,
                Title = "Little Prince",
                Author = new Author()
                {
                    Id = 10,
                    Name = "Antoine saint-exupery"
                },
                PublishDate = DateTime.Now.AddMonths(-6), 
                Publisher = "Reynal & Hitchcock"
            };

            var newISBN = "123456789";
            book.ChangeISBN(newISBN);

            var expectedISBN = newISBN.ToString();
            var actualISBN = book.ISBN.ToString();

            Assert.Equal(expectedISBN,actualISBN);
        }

        public void ChangeAuthor()
        {
            var book = new Book()
            {
                Id = 2,
                Title = "Little Prince",
                Author = new Author()
                {
                    Id = 10,
                    Name = "Antoine saint-exupery"
                },
                PublishDate = DateTime.Now.AddMonths(-6), 
                Publisher = "Reynal & Hitchcock"
            };

            var newAuthor = new Author(){
                Id = 9, 
                Name = "Chipotle"};
            book.ChangeAuthor(newAuthor);

            var expextedAuthor = newAuthor;
            var actualAuthor = book.Author;
            Assert.Equal(expextedAuthor,actualAuthor);
        }
    }
}
