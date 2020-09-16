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
        public void DisplayStats()
        {
            Console.WriteLine($"Dinosaur health:\n  {herd.dinosaur1.type}: {herd.dinosaur1.health}\n  {herd.dinosaur2.type}: {herd.dinosaur2.health}\n  {herd.dinosaur3.type}: {herd.dinosaur3.health}\n");
            Console.WriteLine($"Robot power:\n  {fleet.robot1.name}: {fleet.robot1.health}\n  {fleet.robot2.name}: {fleet.robot2.health}\n  {fleet.robot3.name}: {fleet.robot3.health}\n");
            // Add more stats to be displayed (when unique dinosaurs have unique attacks)
        }

        public void DoBattle()
        {
            do
            {
                Console.Clear();
                DisplayStats(); // Display health stats before each round
                herd.ChooseOpponent(fleet); // Dinosaurs go first

                Console.Clear();
                DisplayStats();
                fleet.ChooseOpponent(herd);
            }
            while ((fleet.robot1.health > 0 || fleet.robot2.health > 0 || fleet.robot3.health > 0) && (herd.dinosaur1.health > 0 || herd.dinosaur2.health > 0 || herd.dinosaur3.health > 0)) ;
            // Add if statement to see if any robots are actually capable of attacking
        }

        public void EndGame()
        {
            if(fleet.robot1.health > 0 || fleet.robot2.health > 0 || fleet.robot3.health > 0) // If any robots survived
            {
                Console.WriteLine("Game Over. Robots win!");
                Console.WriteLine($"Final stats:\n"); // Add final stats for each dinosaur/robot
                DisplayStats();
            }
            else // If no robots survive
            {
                Console.WriteLine("Game over. Dinosaurs win!");
                Console.WriteLine($"Final stats: \n"); // Add final stats for each dinosaur/robot
                DisplayStats();
            }
        }
    }
}
