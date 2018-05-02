using ConsoleLibrary.Models;
using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library boiseLibrary = new Library("Boise Library", "123 fak str");

            Book mobyDick = new Book("Moby Dick", "das90fudas", "Herman Wells");
            var battlefield1942 = new VideoGame() {
                Name = "Battlefield 1942",
                Platform = "PC"
            };

            var dnd121 = new Magazine("DnD", 121);

            boiseLibrary.AddItem(mobyDick);
            boiseLibrary.AddItem(battlefield1942);
            boiseLibrary.AddItem(dnd121);

        }
    }
}
