﻿namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");

            string[] keyvalue = content.Split(':');
            Console.WriteLine("Key:" + keyvalue[0]);
            Console.WriteLine("Value:" + keyvalue[1]);

            string[] vakken = keyvalue[1].Split(',');
            Console.WriteLine("Vakken: ");
            foreach (string vak in vakken)
            {
                Console.WriteLine(vak);
            }
        }
    }
}