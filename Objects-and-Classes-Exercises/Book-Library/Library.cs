namespace Book_Library
{
    using System;
    using System.Collections.Generic;

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();
    }
}
