using ConsoleLibrary.Models;
using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library boiseLibrary = new Library("Boise Library", "123 fak str");
            boiseLibrary.Setup();

            Book mobyDick = new Book("Moby Dick", "das90fudas", "Herman Wells");
            Book awesome = new Book("D$'s Awesome Guide to D&D", "39487237", "D Money");
            Book readyplayerone = new Book("Ready Player One", "4435ihhf", "Jake Overall");
            var battlefield1942 = new VideoGame() {
                Name = "Battlefield 1942",
                Platform = "PC"
            };

            var dnd121 = new Magazine("DnD", 121);

            boiseLibrary.AddItem(mobyDick);
            boiseLibrary.AddItem(awesome);
            boiseLibrary.AddItem(readyplayerone);
            boiseLibrary.AddItem(battlefield1942);
            boiseLibrary.AddItem(dnd121);

            while (boiseLibrary.Visiting)
            {
                boiseLibrary.MainMenuSelection();
            }




        }
    }
}
