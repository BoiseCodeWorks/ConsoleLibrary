using DataLibrary.Abstracts;
using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    internal class Library
    {

        public string Name { get; private set; }
        string Address { get; set; }

        public bool Visiting { get; private set; }
        public bool InSection { get; private set; }
        private List<Book> Books = new List<Book>();
        private List<VideoGame> VideoGames = new List<VideoGame>();
        private List<ILibraryItem> Items = new List<ILibraryItem>();
        private List<ICheckOutable> ItemsForCheckout = new List<ICheckOutable>();
        //private Menu MainMenu { get; set; }
        //private Menu BookMenu { get; set; }

        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Visiting = true;
            InSection = false;
            //MainMenu = BuildMainMenu();
        }

        //Menu BuildMainMenu()
        //{
        //    return new Menu(
        //        "Main Menu",
        //        new List<MenuOption>
        //        {
        //            new MenuOption(BookSelection, "Visit the Book Section"),
        //            new MenuOption(VideoGameSelection, "Visit the Video Game Section"),
        //            new MenuOption(LeaveLibrary, "Leave the Library")
        //        });
        //}

        //public void Setup()
        //{
        //    BuildBookMenu();
        //}

        //void BuildBookMenu()
        //{
        //     BookMenu = new Menu(
        //        "Book Menu",
        //        new List<MenuOption>
        //        {
        //            new MenuOption(PrintBooks, "View all the Books"),
        //            new MenuOption(LeaveSection, "Leave the Section")
        //        });
        //}


        //public void MainMenuSelection()
        //{
        //    Action action = MainMenu.SelectOption();
        //    if( action != null)
        //    {
        //        action.Invoke();
        //    }
        //}

        //private void BookSelection()
        //{
        //    Console.Clear();
        //    InSection = true;
        //    while(InSection)
        //    {
        //        Action action = BookMenu.SelectOption();
        //        if (action != null)
        //        {
        //            action.Invoke();
        //        }
        //    }
        //}

        //private void VideoGameSelection()
        //{
        //    Console.WriteLine("Under Construction");
        //}

        //private void LeaveLibrary()
        //{
        //    Console.WriteLine("Thanks for stopping in!");
        //    Visiting = false;
        //}

        //private void LeaveSection()
        //{
        //    Console.WriteLine("You've left the Section!");
        //    InSection = false;
        //}

        //private void PrintBooks()
        //{
        //    Console.Clear();
        //    int count = 1;
        //    foreach(Book book in Books)
        //    {
        //        Console.WriteLine($"{count++} {book.Name} - {book.Author}");
        //    }
        //    Console.ReadLine();
        //}


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
