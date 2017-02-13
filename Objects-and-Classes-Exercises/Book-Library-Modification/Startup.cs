namespace Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Use the classes from the previous problem and make a program 
             * that read a list of books and print all titles released after given date 
             * ordered by date and then by title lexicographically. 
             * The date is given if format “day-month-year” at the last line in the input.
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
                    ReleaseDate = DateTime.ParseExact(bookInfo[3],"dd.MM.yyyy",CultureInfo.InvariantCulture),
                    ISBN = bookInfo[4],
                    Price = decimal.Parse(bookInfo[5])
                };

                myLibrary.Books.Add(currentBook);
            }

            DateTime releasedAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in myLibrary.Books.OrderBy(i => i.ReleaseDate).ThenBy(i => i.Title))
            {
                if (book.ReleaseDate > releasedAfter)
                {
                    Console.WriteLine($"{book.Title} -> {book.ReleaseDate.Day.ToString("00")}.{book.ReleaseDate.Month.ToString("00")}.{book.ReleaseDate.Year}"); 
                }
            }
        }
    }
}
