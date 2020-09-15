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
            dinosaur1 = new Dinosaur("TRex"); // Instantiate each object with separate variable attributes
            dinosaur2 = new Dinosaur("Velociraptor");
            dinosaur3 = new Dinosaur("Triceratops");
        }

        // member methods (CAN DO)
    }
}
