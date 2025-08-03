using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;
using System.Text.Json;
using Microsoft.VisualBasic.FileIO;

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
        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult  = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element);
            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.weakness);
            copyResult.skills = new List<Skill>();
            foreach (Skill skill in copyFrom.skills)
            {
                Skill copySkill = CopySkill(skill);
                copyResult.skills.Add(copySkill);
            }
            return copyResult;
        }

    }
}
