using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Dinosaur
    {
        // member variables (HAS A)

        public string type;
        public int health;
        public int energy;
        public int attackPower;

        // constructor (SPAWN)

        public Dinosaur(string type, int health, int energy)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
        }

        // member methods (CAN DO)

        public void Attack(Robot robot)
        {
            Console.WriteLine("Choose your attack:\n1) Bite (does 10 damage, costs 10 energy)\n2) Stomp (5 damage, costs 5 energy)");
            string userInput = Console.ReadLine();
            // Verify
            string validUserInput = UserVerification.VerifySwitchCase(userInput, 1, 2);
            switch (validUserInput)
            {
                case "1":
                    energy -= 10; // Dinosaur spends energy according to attack choice;
                    robot.health -= 10; // Robot takes damage according to dinosaur attack choice;
                    break;
                case "2":
                    energy -= 5;
                    robot.health -= 5;
                    break;
            }
        }

        
    }
}
