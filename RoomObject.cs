using static System.Console;
using System;
using System.Diagnostics;


namespace EscapeRoom
{
    public class RoomObject
    {
        private string Name;
        private string Description;

        public RoomObject(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            WriteLine($"You inspect the {Name}.");
            WriteLine(Description);
            WriteLine("Press any key to continue");
            ReadKey(true);
        }

    }
}