using System;
using System.Collections.Generic;
using System.Text;

namespace _8_29.Info
{
    internal class BookInfo
    {
        public string Id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double BookPrice { get; set; }
        public string BookTag { get; set; }
        public bool IsBorrow { get; set; }
    }
}