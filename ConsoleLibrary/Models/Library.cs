using ConsoleLibrary.Abstracts;
using ConsoleLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Models
{
    public class Library
    {

        string Name { get; set; }
        string Address { get; set; }

        private List<Book> Books = new List<Book>();
        private List<VideoGame> VideoGames = new List<VideoGame>();
        private List<ILibraryItem> Items = new List<ILibraryItem>();
        private List<ICheckOutable> ItemsForCheckout = new List<ICheckOutable>();


        public Library(string name, string address)
        {
            Name = name;
            Address = address;
        }

        internal void AddItem(ILibraryItem item)
        {
            Items.Add(item);
        }

        internal void AddItem(Book book)
        {
            Books.Add(book);
            AddItem((CheckoutItem)book);
        }

        internal void AddItem(VideoGame game)
        {
            VideoGames.Add(game);
            AddItem((CheckoutItem)game);
        }

        private void AddItem(CheckoutItem item)
        {
            ItemsForCheckout.Add(item);
        }

    }
}
