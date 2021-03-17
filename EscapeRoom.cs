using static System.Console;
using System;
using System.Diagnostics;

namespace EscapeRoom
{
    public class EscapeRoom
    {
        private RoomObject Painting;
        private RoomObject Cane;
        private RoomObject DeskDrawer;
        private Door LockedDoor;
        private bool HasEscaped;

        public EscapeRoom()
        {
            Painting = new RoomObject("painting", "Its,oddly enough, a giant painting of mice.You think \"mice\" might be a clue.");
            Cane = new RoomObject("cane", "You realize it is actually a walking stick that a \"blind\" person might use.");
            DeskDrawer = new RoomObject("desk drawer", "It sticks slightly,but you manage to jiggle it open. You find a post it with a number \"three\" on it..");
            LockedDoor = new Door("three blind mice");
            HasEscaped = false;
        }
        public void StartRoom()
        {
            Title = "Escape";
            WriteLine("You wake up and look arround..");
            WriteLine("Looks like you are is some kind of escape room.");
            WriteLine("Press any key to exit...");
            ReadKey(true);
            
            // Painting.DisplayInfo();
            // Cane.DisplayInfo();
            // DeskDrawer.DisplayInfo();
            // bool wasSuccessful = LockedDoor.AttemptEscape();
            // WriteLine($"Did they escape? {wasSuccessful}");
            //

            while (!HasEscaped)
            {
                string choice = Navigate();
                WriteLine($"You chose {choice}");
                if (choice == "1")
                {
                    Painting.DisplayInfo();
                }
                if (choice == "2")
                {
                    DeskDrawer.DisplayInfo();
                }
                if (choice == "3")
                {
                    Cane.DisplayInfo();
                }else if (choice == "4")
                {
                    bool wasSuccessful = LockedDoor.AttemptEscape();
                    HasEscaped = wasSuccessful;
                }
                else
                {
                    DisplayInvalidChoiceFeedback();
                }
                
            }
            WriteLine("Congratulations on escaping! Thanks for playing.");
            
            
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }

        private void DisplayInvalidChoiceFeedback()
        {
            WriteLine("That's not valid option. Try again.");
            WriteLine("Press any key to continue...");
            ReadKey(true);
        }
        

        private string Navigate()
        {
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("Where would you liek to look?");
            WriteLine(" 1) a painting\n 2) a desk drawer\n 3) a cane\n 4) a door");
            string navigationChoice = ReadLine().Trim();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            return navigationChoice;

        }
    }
}