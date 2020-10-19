using System;

namespace L01_IntroductionToEFCore_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFCoreTestDbContext db = new EFCoreTestDbContext())
            {
                var books = db.Books;

                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id} - {book.Name} - {book.Author} - {book.Year}");
                }
            }
        }
    }
}
