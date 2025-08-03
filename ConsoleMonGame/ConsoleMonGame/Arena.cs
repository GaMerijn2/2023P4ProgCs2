using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterB, fighterA);

            //print damage and health
            Console.WriteLine(fighterA.name + " Damaged " + fighterB.name + " For: " + (100 - fighterB.health));
            Console.WriteLine(fighterB.name + " Now Has " + fighterB.health+ " Left. " );

            fighterB.skills[0].UseOn(fighterA, fighterB);

            //print damage and health
            Console.WriteLine(fighterB.name + " Damaged " + fighterA.name + " For: " + (100 - fighterA.health));
            Console.WriteLine(fighterA.name + " Now Has " + fighterA.health + " Left. ");

        }
    }
}
