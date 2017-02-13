namespace Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();
    }
}
