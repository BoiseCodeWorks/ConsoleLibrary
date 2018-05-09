using ConsoleLibrary.Utils;
using DataLibrary.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Services
{
    public class LibraryService
    {
        private LibraryProvider _lp = new LibraryProvider();
        private int _libraryId { get; set; }
        private bool InLibrary { get; set; }
        private bool InSection { get; set; }
        public bool Running { get; private set; }
        private Menu LibraryMenu { get; set; }
        private Menu BookMenu { get; set; }

        
        public LibraryService()
        {
            Running = true;
            InLibrary = false;
            InSection = false;
            BuildLibraryMenu();
            BuildBookMenu();
        }
        
        #region LibraryMenu
        public void ShowLibraries()
        {
            var names = _lp.GetLibraries();
            var count = 1;
            foreach(var n in names)
            {
                Console.WriteLine($"{count++} {n}");
            }
        }
        public void LibrarySelection()
        {
            ShowLibraries();
            var names = _lp.GetLibraries();
            string input = Console.ReadLine();
            int index = -1;
            bool valid = int.TryParse(input, out index);
            if(!valid || index > names.Count || index <= 0)
            {
                Console.Clear();
                Console.WriteLine("Please make a valid selection");
                return;
            }
            SetLibrary(index-1);
        }

        private void SetLibrary(int index)
        {
            _libraryId = index;
            InLibrary = true;
            while(InLibrary)
            {
                Action action = LibraryMenu.SelectOption();
                if(action != null)
                {
                    action.Invoke();
                }
            }

        }

        //public void MainMenuSelection()
        //{
        //    Action action = MainMenu.SelectOption();
        //    if( action != null)
        //    {
        //        action.Invoke();
        //    }
        //}

        void BuildLibraryMenu()
        {
            LibraryMenu = new Menu(
                "Library Menu",
                new List<MenuOption>
                {
                    new MenuOption(BookSelection, "Visit the Book Section"),
                    new MenuOption(VideoGameSelection, "Visit the Video Game Section"),
                    new MenuOption(LeaveLibrary, "Leave the Library")
                });
        }

        private void VideoGameSelection()
        {
            Console.WriteLine("Under Construction");
        }

        private void LeaveLibrary()
        {
            Console.WriteLine("Thanks for stopping in!");
            InLibrary = false;
        }
        #endregion
        #region Book Menu
        private void BookSelection()
        {
            Console.Clear();
            InSection = true;
            while (InSection)
            {
                Action action = BookMenu.SelectOption();
                if (action != null)
                {
                    action.Invoke();
                }
            }
        }

        void BuildBookMenu()
        {
            BookMenu = new Menu(
               "Book Menu",
               new List<MenuOption>
               {
                    new MenuOption(PrintBooks, "View all the Books"),
                    new MenuOption(CheckoutBook, "Checkout a Book"),
                    new MenuOption(LeaveSection, "Leave the Section")
               });
        }

        private void CheckoutBook()
        {
            PrintBooks();
            var books = _lp.GetBooks(_libraryId);
            Console.WriteLine("What book  would you like to checkout?");
            string input = Console.ReadLine();
            int index = -1;
            bool valid = int.TryParse(input, out index);
            if(!valid || index <= 0 || index > books.Count)
            {
                Console.WriteLine("Please make a valid selection");
                return;
            }
              Console.WriteLine(_lp.CheckOutBook(_libraryId, books[index - 1].Id));
        }

        private void LeaveSection()
        {
            Console.WriteLine("You've left the Section!");
            InSection = false;
        }

        private void PrintBooks()
        {
            Console.Clear();
            var books = _lp.GetBooks(_libraryId);
            int count = 1;
            foreach (var book in books)
            {
                Console.WriteLine($"{count++} {book.Name}");
            }
            Console.ReadLine();
        }

        #endregion
    }
}
