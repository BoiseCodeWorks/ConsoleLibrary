using DataLibrary.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Services
{
    public class LibraryService
    {

        private LibraryProvider _lp = new LibraryProvider();

        public void ShowLibraries()
        {
            var names = _lp.GetLibraries();
            foreach(var n in names)
            {
                Console.WriteLine(n);
            }
        }

    }
}
