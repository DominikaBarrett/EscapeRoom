using static System.Console;
using System;
using System.Diagnostics;

namespace EscapeRoom
{
    public class Door
    {
        private string Code;

        public Door(string code)
        {
            Code = code;
        }

        public bool AttemptEscape()
        {
            WriteLine("You step up and try the door. It's locked and needs a code...");
            Write("Please enter a code: ");
            string playerGuess = ReadLine().ToLower().Trim();
            if (playerGuess == Code)
            {
                WriteLine("Click ...the lock falls away.You escaped!");
                
            }
            else
            {
                WriteLine("Nothing happened..guess the code was wrong");
                
            }
            WriteLine("Press any key to continue....");
            ReadKey(true);
            return playerGuess == Code;
            
        }
    }
}

