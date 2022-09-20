using System;
using Gamerules;

namespace Commandlinetester
{

    class CommandLineFunctions
    {
        static public string PeacefulSystem(string i)
        {
            Console.WriteLine("Welcome to [insert solar system]");
            Console.WriteLine("Type 1 to visit the merchant, 2 to visit the colony, and 3 to visit the shipwright");
             i = Console.ReadLine().ToString();
            if (i == "1")
            {
                Console.WriteLine("Welcome to The Merchant");

            }
            else if (i == "2")
            {
                Console.WriteLine("Welcome to the Colony");
            }
            else if (i == "3")
            {
                Console.WriteLine("Welcome to the Shipwright");
            }
            return i;
        }
    }
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
                string i = "0";
                while( i!="x")
                        {
                   i= CommandLineFunctions.PeacefulSystem(i);
                    
                    /*Console.WriteLine("Welcome to [insert solar system]");
                    Console.WriteLine("Type 1 to visit the merchant, 2 to visit the colony, and 3 to visit the shipwright");
                    i = Console.ReadLine().ToString();
                    if (i == "1")
                    {
                        Console.WriteLine("Welcome to The Merchant");

                    }
                    else if (i == "2")
                    {
                        Console.WriteLine("Welcome to the Colony");
                    }
                    else if (i == "3")
                    {
                        Console.WriteLine("Welcome to the Shipwright");
                    } */
                    Gamerules.
                }

                string[] NPCNames = System.IO.File.ReadAllLines("C:\\Users\\mauri\\source\\repos\\Basic Space Game\\Commandlinetester\\namelist.txt");
                /*foreach (var names in NPCNames)
                {
                    Console.WriteLine(names);
                }*/
            }

        }
    }
}
