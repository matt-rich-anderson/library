using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<Book> books = new List<Book>()
            {
                new Book
                {
                    Title = "My Work Is Not Yet Done",
                    Author = "Thomas Ligotti",
                    PublishDate = DateTime.Now,
                    Genre = "Horror"
                },
                new Book
                {
                    Title = "The Judging Eye",
                    Author = "R. Scott Bakker",
                    PublishDate = DateTime.Now,
                    Genre = "Fantasy"
                },
                new Book
                {
                    Title = "Strange Eons",
                    Author = "Devon McCarty",
                    PublishDate = DateTime.Now,
                    Genre = "Scifi/Horror"
                },
            };

            foreach(Book book in books)
            {
                Console.WriteLine($"The book is {book.Title} by {book.Author}.");
            }
        }
    }
}
