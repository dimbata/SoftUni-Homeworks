﻿namespace Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
