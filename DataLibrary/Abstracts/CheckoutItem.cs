using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Abstracts
{
    internal abstract class CheckoutItem : ICheckOutable
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public void Checkout()
        {
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(7);
        }
    }
}
