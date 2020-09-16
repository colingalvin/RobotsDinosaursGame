using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Robot
    {
        // member variables (HAS A)

        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public bool hasPower;

        // constructor (SPAWN)

        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            Console.WriteLine($"Choose a weapon for {name}:");
            weapon = new Weapon();
            hasPower = true;
        }

        // member methods (CAN DO)
        public void Attack(Dinosaur dinosaur)
        {
            powerLevel -= 1; // Robot spends 1 power to attack
            dinosaur.health -= weapon.attackPower; // Robot takes damage equivalent to robot's weapon attack power;
        }
    }
}
