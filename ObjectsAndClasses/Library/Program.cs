using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Library
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Book[] book = new Book[n];
            Library library = new Library();
            library.Books = new List<Book>();
            library.Name = "MyLibrary";
            for (int i = 0; i < n; i++)
            {
                string[] comm = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                book[i] = new Book();
                book[i].Title = comm[0];
                book[i].Author = comm[1];
                book[i].Publisher = comm[2];       
                book[i].ReleaseDate = DateTime.ParseExact(comm[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book[i].ISBN = comm[4];
                book[i].Price = double.Parse(comm[5]);
                
                library.Books.Add(book[i]);
            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var Book in library.Books.OrderByDescending(x=>x.Price).OrderBy(x=>x.Author))
            {
                double sum = library.Books.Where(b => b.Author == Book.Author).Select(p=>p.Price).Sum();
                Console.WriteLine(Book.Author + " -> " + sum);
            }

            foreach (var Book in library.Books)
            {
                if(Book.ReleaseDate > date)
                {
                    Console.WriteLine($"{Book.Title} -> {Book.ReleaseDate:dd.MM.yyyy}");
                }
            }
        }
    }
}
