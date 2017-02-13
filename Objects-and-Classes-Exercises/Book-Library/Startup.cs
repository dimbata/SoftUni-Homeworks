namespace Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * To model a book library, define classes to hold a book and a library. 
             * The library must have a name and a list of books. 
             * The books must contain the title, author, publisher, 
             * release date, ISBN-number and price. 
             * Read a list of books, add them to the library 
             * and print the total sum of prices by author, 
             * ordered descending by price and then by author’s name lexicographically.
             * Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
             */

            int n = int.Parse(Console.ReadLine());

            Library myLibrary = new Library();

            for (int i = 0; i < n; i++)
            {
                var bookInfo = Console.ReadLine().Split(' ');

                var currentBook = new Book()
                {
                    Title = bookInfo[0],
                    Author = bookInfo[1],
                    Publisher = bookInfo[2],
                    ReleaseDate = bookInfo[3],
                    ISBN = bookInfo[4],
                    Price = decimal.Parse(bookInfo[5])
                };

                myLibrary.Books.Add(currentBook);
            }

            var authorByPrice = new Dictionary<string, decimal>();

            foreach (var book in myLibrary.Books)
            {
                if (!authorByPrice.ContainsKey(book.Author))
                {
                    authorByPrice[book.Author] = 0;
                }

                authorByPrice[book.Author] += book.Price;
            }

            foreach (var author in authorByPrice.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
