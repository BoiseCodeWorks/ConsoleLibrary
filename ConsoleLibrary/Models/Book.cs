using ConsoleLibrary.Abstracts;
using ConsoleLibrary.Interfaces;
using System;

namespace ConsoleLibrary.Models
{
    public class Book : CheckoutItem
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        
        public Book(string name, string iSBN, string author)
        {
            Name = name;
            ISBN = iSBN;
            Author = author;
        }
    }
}