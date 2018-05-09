using DataLibrary.HelperModels;
using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Providers
{
    public class LibraryProvider
    {

        private FakeDb _db;

        public LibraryProvider()
        {
            _db = new FakeDb();
        }

        public List<string> GetLibraries()
        {
            List<string> libNames = new List<string>();
            foreach(var l in _db.Libraries)
            {
                libNames.Add(l.Name);
            }
            return libNames;
        }

        public List<ReturnLibraryItem> GetBooks(int libraryId)
        {
            return _db.Libraries[libraryId].GetBooksInfo();
        }

        public string CheckOutBook(int libraryId, string bookId)
        {
            return _db.Libraries[libraryId].CheckOutBook(bookId);
        }
    }
}
