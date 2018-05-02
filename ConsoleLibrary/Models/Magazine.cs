using ConsoleLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Models
{
    public class Magazine : ILibraryItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Issue { get; set; }

        public Magazine(string name, int issue)
        {
            Name = name;
            Issue = issue;
        }
    }
}
