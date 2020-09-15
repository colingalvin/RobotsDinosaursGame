using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Battlefield
    {
        // member variables (HAS A)
        public Herd herd;
        public Fleet fleet;

        // constructor (SPAWN)
        public Battlefield()
        {
            herd = new Herd(); // Instantiate herd (list) of Dinosaur objects
            fleet = new Fleet(); // Instantiate fleet (list) of Robot objects
        }

        // member methods (CAN DO)
        public void DoBattle()
        {
            herd.dinosaur1.Attack(fleet.robot1);
            herd.dinosaur2.Attack(fleet.robot2);
            herd.dinosaur3.Attack(fleet.robot3);
        }
    }
}
