﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Herd
    {
        // member variables (HAS A)
        public Dinosaur dinosaur1; // Herd contains 3 dinosaur objects
        public Dinosaur dinosaur2;
        public Dinosaur dinosaur3;

        // constructor (SPAWN)
        public Herd()
        {
            Console.WriteLine($"1) T-Rex / health: 100 / energy: 50.\n2) Veliciraptor / health: 50 / energy: 100\n3) Triceratops / health: 200/ energy: 25");
            Console.Write("Choose the first dinosaur in your herd:");
            string userInput = Console.ReadLine();
            dinosaur1 = ChooseDinosaurType(userInput);
            Console.Write("Choose the second dinosaur in your herd:");
            userInput = Console.ReadLine();
            dinosaur2 = ChooseDinosaurType(userInput);
            Console.Write("Choose the third dinosaur in your herd:");
            userInput = Console.ReadLine();
            dinosaur3 = ChooseDinosaurType(userInput);
        }

        // member methods (CAN DO)

        public Dinosaur ChooseDinosaurType(string userInput)
        {
            // take in user input
            // construct appropriate dinosaur
            // return dinosaur
            Dinosaur dinosaur = null;
            switch (userInput)
            {
                case "1":
                    dinosaur = new Dinosaur("TRex", 100, 50); // Instantiate each object with separate variable attributes
                    break;
                case "2":
                    dinosaur = new Dinosaur("Velociraptor", 50, 100);
                    break;
                case "3":
                    dinosaur = new Dinosaur("Triceratops", 200, 25);
                    break;
            }
            return dinosaur;
        }
        public void ChooseOpponent(Fleet fleet)
        {
            string userInput;
            // Dinosaurs go first, switch case to choose which dinosaur attacks which robot
            Console.WriteLine($"Choose dinosaur:\n1) {dinosaur1.type}\n2) {dinosaur2.type}\n3) {dinosaur3.type}");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            dinosaur1.Attack(fleet.robot1);
                            break;
                        case "2":
                            dinosaur1.Attack(fleet.robot2);
                            break;
                        case "3":
                            dinosaur1.Attack(fleet.robot3);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            dinosaur2.Attack(fleet.robot1);
                            break;
                        case "2":
                            dinosaur2.Attack(fleet.robot2);
                            break;
                        case "3":
                            dinosaur2.Attack(fleet.robot3);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            dinosaur3.Attack(fleet.robot1);
                            break;
                        case "2":
                            dinosaur3.Attack(fleet.robot2);
                            break;
                        case "3":
                            dinosaur3.Attack(fleet.robot3);
                            break;
                    }
                    break;
            }
        }
    }
}
