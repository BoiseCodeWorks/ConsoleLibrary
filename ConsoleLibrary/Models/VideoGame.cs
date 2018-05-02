using System;
using ConsoleLibrary.Abstracts;
using ConsoleLibrary.Interfaces;

namespace ConsoleLibrary.Models
{
    public class VideoGame : CheckoutItem
    {
        public string Platform { get; set; }
        
        public new void Checkout()
        {
            base.Checkout();
            ReturnDate = DateTime.Now.AddDays(5);
        }
    }
}