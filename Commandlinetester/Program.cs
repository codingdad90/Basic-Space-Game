using System;
using Gamerules;

namespace Commandlinetester
{
    class Program
    {
         //string tempString;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Pilot!");
            Console.WriteLine("Please enter Pilot Name......");
            string tempString = Console.ReadLine();
            
            Console.WriteLine("Welcome "+tempString);
            string x = "0";
            while (x != "x")
            {
                Console.WriteLine("Please enter a number!");
                x = Console.ReadLine();
                Console.WriteLine("You have chosen " + x);

                string[] NPCNames = System.IO.File.ReadAllLines("C:\\Users\\mauri\\source\\repos\\Basic Space Game\\Commandlinetester\\namelist.txt");
                foreach (var names in NPCNames)
                {
                    Console.WriteLine(names);
                }
            }

        }
    }
}
