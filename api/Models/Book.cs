using System;
using System.Collections.Generic;

namespace Fisher.Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishDate { get; set; }
        

        public string Publisher { get; set;}

        public void ChangePublicationDate(DateTime dateTime){
            this.PublishDate = dateTime;
        }

        public void ChangeISBN(String newISBN){
            this.ISBN = newISBN;
        }

        public void ChangeAuthor(Author newAuthor){
            this.Author = newAuthor;
        }
    }
}