using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Interfaces
{
    public interface ICheckOutable : ILibraryItem
    {
        DateTime CheckOutDate { get; set; }
        DateTime ReturnDate { get; set; }
        void Checkout();
        //LibraryMember IssuedTo { get; set; }
    }
}
