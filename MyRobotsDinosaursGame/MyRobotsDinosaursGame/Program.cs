using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield(); // Instantiates a herd and a fleet
            do // Do while while both teams have a member that is alive
            {
                battlefield.DoBattle();
            }
            while ((battlefield.fleet.robot1.health > 0 || battlefield.fleet.robot2.health > 0 || battlefield.fleet.robot3.health > 0) && (battlefield.herd.dinosaur1.health > 0 || battlefield.herd.dinosaur2.health > 0 || battlefield.herd.dinosaur3.health > 0));
            
            if(battlefield.fleet.robot1.health > 0 || battlefield.fleet.robot2.health > 0 || battlefield.fleet.robot3.health > 0) // If any robots survived
            {
                Console.WriteLine("Game Over. Robots win!");
                Console.WriteLine("Final stats:"); // Add final stats for each dinosaur/robot
            }
            else // If no robots survive
            {
                Console.WriteLine("Game over. Dinosaurs win!");
                Console.WriteLine("Final stats:"); // Add final stats for each dinosaur/robot
            }
        }
    }
}
