using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Fleet
    {
        // member variables (HAS A)
        public Robot robot1; // Fleet contains 3 robot objects
        public Robot robot2;
        public Robot robot3;


        // constructor (SPAWN)
        public Fleet()
        {
            Console.Write("Enter the name of the first robot in your fleet: ");
            string robot1Name = Console.ReadLine();
            robot1 = new Robot(robot1Name); // Instantiate each object with separate variable attributes
            Console.Write("Enter the name of the second robot in your fleet: ");
            string robot2Name = Console.ReadLine();
            robot2 = new Robot(robot2Name);
            Console.Write("Enter the name of the third robot in your fleet: ");
            string robot3Name = Console.ReadLine();
            robot3 = new Robot(robot3Name);
        }

        // member methods (CAN DO)

        public void ChooseOpponent(Herd herd)
        {
            string userInput;
            Console.WriteLine($"Choose robot:\n1) {robot1.name}\n2) {robot2.name}\n3) {robot3.name}");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            robot1.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            robot1.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            robot1.Attack(herd.dinosaur3);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            robot2.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            robot2.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            robot2.Attack(herd.dinosaur2);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine($"Choose dinosaur to attack:\n1) {herd.dinosaur1.type}\n2) {herd.dinosaur2.type}\n3) {herd.dinosaur3.type}");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            robot3.Attack(herd.dinosaur1);
                            break;
                        case "2":
                            robot3.Attack(herd.dinosaur2);
                            break;
                        case "3":
                            robot3.Attack(herd.dinosaur3);
                            break;
                    }
                    break;
            }
        }
    }
}
