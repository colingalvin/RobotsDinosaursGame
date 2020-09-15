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
            DisplayStats(); // Clear console, display health stats before each round
            herd.ChooseOpponent(fleet); // Dinosaurs go first
            DisplayStats();
            fleet.ChooseOpponent(herd);
            // Add if statement to see if any robots are actually capable of attacking
        }

        public void DisplayStats()
        {
            Console.Clear();
            Console.WriteLine($"Dinosaur health:\n {herd.dinosaur1.type}: {herd.dinosaur1.health}\n {herd.dinosaur2.type}: {herd.dinosaur2.health}\n {herd.dinosaur3.type}: {herd.dinosaur3.health}\n");
            Console.WriteLine($"Robot power:\n {fleet.robot1.name}: {fleet.robot1.health}\n {fleet.robot2.name}: {fleet.robot2.health}\n {fleet.robot3.name}: {fleet.robot3.health}\n");
            // Add more stats to be displayed (when unique dinosaurs have unique attacks)
        }
    }
}
