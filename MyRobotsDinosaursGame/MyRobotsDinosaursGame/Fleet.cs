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
            robot1 = new Robot("Optimus Prime"); // Instantiate each object with separate variable attributes
            robot2 = new Robot("Terminator");
            robot3 = new Robot("Data");
        }

        // member methods (CAN DO)
    }
}
