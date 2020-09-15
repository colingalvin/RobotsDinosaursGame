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

        // constructor (SPAWN)
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            weapon = new Weapon();
        }

        // member methods (CAN DO)
    }
}
