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
                Spaceship playerShip= ShipWright();
                playerShip.ShipInfo();
            }            
            else
            {
                Console.WriteLine("Please try again");

            }
            return i;
        }
       static public Spaceship ShipWright()
        {
            Console.WriteLine("Welcome to the Shipwright, press 1 for new ship");
            Console.WriteLine("Please enter your ship name");
            string shipName = Console.ReadLine();
            Spaceship Playership = new Gamerules.Spaceship(shipName);
            return Playership;
                

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
