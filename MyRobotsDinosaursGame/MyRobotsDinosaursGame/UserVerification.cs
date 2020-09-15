using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class UserVerification
    {
        public static bool VerifyInput(int userInput, int start, int end)
            // Take user input and start/ending 
        {
            bool isValidInput = false;
            while(userInput < start || userInput > end)
            {
                Console.Write("Invalid choice. Please try again: ");
                userInput = int.Parse(Console.ReadLine());
            }
            isValidInput = true;
            return isValidInput;
        }
    }
}
