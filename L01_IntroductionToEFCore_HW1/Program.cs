using System;
using System.Collections.Generic;
using System.Linq;

namespace L01_IntroductionToEFCore_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {
                var newBooks = new List<Book>()
                {
                    new Book { Name = "The Lord of the Rings", Author = "J. R. R. Tolkien", Year = 1954 },
                    new Book { Name = "The Hobbit", Author = "J. R. R. Tolkien", Year = 1937 },
                    new Book { Name = "Dream of the Red Chamber", Author = "Cao Xueqin", Year = 1791 }
                };

                if (db.Books.FirstOrDefault() == null)
                {
                    db.Books.AddRange(newBooks);
                    db.SaveChanges();
                }

                var books = db.Books;

                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id} - {book.Name} - {book.Author} - {book.Year}");
                }
            }
        }
    }
}
