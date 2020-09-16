using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class GameVerification
    {
        public static string VerifySwitchCase(string userInput, int start, int end)
        {
            int userInputInteger;
            string validatedInput;

            bool isInteger = int.TryParse(userInput, out userInputInteger);
            // Input must be integer between start and end values of switch case before exiting while loop
            while (isInteger != true || userInputInteger < start || userInputInteger > end)
            {
                Console.Write("Invalid choice. Please try again: ");
                userInput = Console.ReadLine();
                isInteger = int.TryParse(userInput, out userInputInteger);
            }
            validatedInput = Convert.ToString(userInputInteger);
            return validatedInput;
        }

        public static bool CheckIfDinosaurIsDead(Dinosaur dinosaur)
        {
            if (dinosaur.health <= 0)
            {
                dinosaur.health = 0;
                dinosaur.isAlive = false;
                dinosaur.type += " (dead)";
            }
            return dinosaur.isAlive;
        }

        public static bool CheckIfRobotIsDead(Robot robot)
        {
            if(robot.powerLevel <= 0)
            {
                robot.powerLevel = 0;
                robot.hasPower = false;
                robot.name += " (out of power)";
            }
            return robot.hasPower;
        }
    }
}
