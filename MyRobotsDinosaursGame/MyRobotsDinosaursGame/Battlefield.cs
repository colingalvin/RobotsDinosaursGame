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
            DisplayStats();

            string userInput;
            // Dinosaurs go first, switch case to choose which dinosaur attacks which robot
            Console.WriteLine($"Choose dinosaur:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            herd.dinosaur1.Attack(fleet.robot1);
                            break;
                        case "2":
                            herd.dinosaur1.Attack(fleet.robot2);
                            break;
                        case "3":
                            herd.dinosaur1.Attack(fleet.robot3);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            herd.dinosaur2.Attack(fleet.robot1);
                            break;
                        case "2":
                            herd.dinosaur2.Attack(fleet.robot2);
                            break;
                        case "3":
                            herd.dinosaur2.Attack(fleet.robot3);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            herd.dinosaur3.Attack(fleet.robot1);
                            break;
                        case "2":
                            herd.dinosaur3.Attack(fleet.robot2);
                            break;
                        case "3":
                            herd.dinosaur3.Attack(fleet.robot3);
                            break;
                    }
                    break;
            }

            DisplayStats();
            // Add if statement to see if any robots are actually capable of attacking
            // Switch case to choose which robot attacks which dinosaur
            Console.WriteLine($"Choose robot:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            fleet.robot1.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            fleet.robot1.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            fleet.robot1.Attack(herd.dinosaur3);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            fleet.robot2.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            fleet.robot2.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            fleet.robot2.Attack(herd.dinosaur2);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            fleet.robot3.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            fleet.robot3.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            fleet.robot3.Attack(herd.dinosaur3);
                            break;
                    }
                    break;
            }
        }

        public void DisplayStats()
        {
            Console.Clear();
            Console.WriteLine($"Dinosaur health:\n{herd.dinosaur1.type}: {herd.dinosaur1.health}\n{herd.dinosaur2.type}: {herd.dinosaur2.health}\n{herd.dinosaur3.type}: {herd.dinosaur3.health}\n");
            Console.WriteLine($"Robot power:\n{fleet.robot1.name}: {fleet.robot1.health}\n{fleet.robot2.name}: {fleet.robot2.health}\n{fleet.robot3.name}: {fleet.robot3.health}\n");
        }
    }
}
