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

        // constructor (SPAWN)

        // member methods (CAN DO)
        public void DoBattle()
        {
            Herd dinosaurs = new Herd(); // Instantiate herd (list) of Dinosaur objects
            Fleet robots = new Fleet(); // Instantiate fleet (list) of Robot objects
            dinosaurs.dinosaur1.Attack(robots.robot1);
            robots.robot2.Attack(dinosaurs.dinosaur2);
        }
    }
}
