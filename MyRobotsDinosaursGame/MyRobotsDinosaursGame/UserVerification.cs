using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class UserVerification
    {
        public static string VerifySwitchCase(string userInput, int start, int end)
            // Take user input and acceptable start/ending of input range
        {
            int userInputInt = int.Parse(userInput);
            string validInput;
            while(userInputInt < start || userInputInt > end)
            {
                Console.Write("Invalid choice. Please try again: ");
                userInputInt = int.Parse(Console.ReadLine());
            }
            validInput = Convert.ToString(userInputInt);
            return validInput;
        }
    }
}
