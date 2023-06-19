using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory    
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);

            foreach (string line in lines)
            {
                string[] typeSplit = line.Split('|');
                string[] consolemonData = typeSplit[0].Split(',');
                //Console.WriteLine(line);
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consolemonData[0];
                dataMon.energy = int.Parse(consolemonData[2]);
                dataMon.health = int.Parse(consolemonData[4]);
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.energy);
                Console.WriteLine(dataMon.health);

            }


        }
    }
}
