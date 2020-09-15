using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Weapon
    {
        // member variables (HAS A)
        public string type;
        public int attackPower;

        // constructor (SPAWN)
        public Weapon()
        {
            Console.WriteLine("1) Sword (power:10)\n2) Battle Axe (power: 15)");
            Console.Write("Enter the number of your robot's weapon: ");
            string userInput = Console.ReadLine();
            switch(userInput) // choose which weapon each robot has
            {
                case "1":
                    type = "Sword";
                    attackPower = 10;
                    break;
                case "2":
                    type = "Battle Axe";
                    attackPower = 15;
                    break;
            }
        }

        // member methods (CAN DO)
    }
}
