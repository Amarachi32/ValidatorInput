using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafe_UserInput
{
    internal class Utility
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");

            return Console.ReadLine();
        }

        public static void PrintMessage(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            
        }

    }
}
