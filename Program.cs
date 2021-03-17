using static System.Console;
using System;
using System.Diagnostics;

namespace EscapeRoom
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EscapeRoom myRoom = new EscapeRoom();
            myRoom.StartRoom();
            WriteLine("Press any key to exit...");
            ReadKey(true);
            
        }
    }
}