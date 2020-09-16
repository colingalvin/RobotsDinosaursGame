using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsDinosaursGame
{
    class Program
    {
        // Add isAlive attribute to all, change name/remove from play when dead

        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield(); // Instantiates a herd and a fleet
            battlefield.DoBattle();
            battlefield.EndGame();
        }
    }
}
