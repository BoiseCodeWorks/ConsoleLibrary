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



    }
}
