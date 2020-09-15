﻿using System;
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
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 100;
            attackPower = 10;
        }

        // member methods (CAN DO)

        public void Attack(Robot robot)
        {
            energy -= 10; // Dinosaur spends 10 energy to attack
            robot.health -= attackPower; // Robot takes damage equivalent to dinosaur attack power;
        }
    }
}