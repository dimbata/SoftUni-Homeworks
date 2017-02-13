namespace Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList = new Dictionary<string, int>();
        public double Bill { get; set; }
    }
}
