using System;
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
            Console.WriteLine($"1) T-Rex / health: 100 / energy: 50\n2) Veliciraptor / health: 50 / energy: 100\n3) Triceratops / health: 200/ energy: 25\n");
            
            Console.Write("Choose the first dinosaur in your herd: "); // User chooses which dinosaur to add to herd
            string userInput = Console.ReadLine();
            // Verify
            string validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3);
            dinosaur1 = ChooseDinosaurType(validUserInput); // take returned dinosaur and assign

            Console.Write("Choose the second dinosaur in your herd: "); // Choose dinosaur type
            userInput = Console.ReadLine();
            // Verify
            validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3);
            dinosaur2 = ChooseDinosaurType(validUserInput); // Assign
            
            Console.Write("Choose the third dinosaur in your herd: "); // Choose dinosaur type
            userInput = Console.ReadLine();
            // Verify
            validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3);
            dinosaur3 = ChooseDinosaurType(validUserInput); // Assign
        }

        // member methods (CAN DO)

        public Dinosaur ChooseDinosaurType(string userInput)
        {
            // user input already verified in constructor
            Dinosaur dinosaur = null;
            switch (userInput) // user input determines type of dinosaur constructed
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
            return dinosaur; // return dinosaur to constructor
        }

        public void ChooseOpponent(Fleet fleet)
        {
            // Dinosaurs go first, switch case to choose which dinosaur attacks which robot
            Console.WriteLine($"Choose dinosaur:\n1) {dinosaur1.type}\n2) {dinosaur2.type}\n3) {dinosaur3.type}");
            string userInput = Console.ReadLine();
            string validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3); // Verify

            switch (validUserInput)
            {
                case "1":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3); // Verify
                    // Verify that dinosaur has power (is alive)
                    switch (validUserInput)
                    {
                        case "1":
                            dinosaur1.Attack(fleet.robot1);
                            GameVerification.CheckIfRobotIsDead(fleet.robot1);
                            break;
                        case "2":
                            dinosaur1.Attack(fleet.robot2);
                            GameVerification.CheckIfRobotIsDead(fleet.robot2);
                            break;
                        case "3":
                            dinosaur1.Attack(fleet.robot3);
                            GameVerification.CheckIfRobotIsDead(fleet.robot3);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3); // Verify
                    switch (validUserInput)
                    {
                        case "1":
                            dinosaur2.Attack(fleet.robot1);
                            GameVerification.CheckIfRobotIsDead(fleet.robot1);
                            break;
                        case "2":
                            dinosaur2.Attack(fleet.robot2);
                            GameVerification.CheckIfRobotIsDead(fleet.robot2);
                            break;
                        case "3":
                            dinosaur2.Attack(fleet.robot3);
                            GameVerification.CheckIfRobotIsDead(fleet.robot3);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine($"Choose robot to attack:\n1) {fleet.robot1.name}\n2) {fleet.robot2.name}\n3) {fleet.robot3.name}");
                    userInput = Console.ReadLine();
                    validUserInput = GameVerification.VerifySwitchCase(userInput, 1, 3); // Verify
                    switch (validUserInput)
                    {
                        case "1":
                            dinosaur3.Attack(fleet.robot1);
                            GameVerification.CheckIfRobotIsDead(fleet.robot1);
                            break;
                        case "2":
                            dinosaur3.Attack(fleet.robot2);
                            GameVerification.CheckIfRobotIsDead(fleet.robot2);
                            break;
                        case "3":
                            dinosaur3.Attack(fleet.robot3);
                            GameVerification.CheckIfRobotIsDead(fleet.robot3);
                            break;
                    }
                    break;
            }
        }
    }
}
