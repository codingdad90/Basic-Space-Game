using System;
using Gamerules;
using System.Collections;
using System.Collections.Generic;


namespace Commandlinetester
{

    class CommandLineFunctions
    {
        static public Gamerules.Playerinfo NewPlayer()
        {
            Console.WriteLine("Welcome Pilot!");
            Console.WriteLine("Please enter Pilot Name......");
            string tempString = Console.ReadLine();
            Playerinfo CurrentPlayer = new Playerinfo(tempString);
            Console.WriteLine("Welcome " + tempString);
            return CurrentPlayer;
        }
        static public Playerinfo PeacefulSystem(Playerinfo currentPlayer)
        {

            Console.WriteLine("Welcome to [insert solar system]");
            Console.WriteLine("Type 1 to visit the merchant, 2 to visit the colony, and 3 to visit the shipwright");
            string i = Console.ReadLine().ToString();
            if (i == "1")
            {
                Console.WriteLine("Welcome to The Merchant");
                Playerinfo Player = currentPlayer;
                return Player;

            }
            else if (i == "2")
            {
                Console.WriteLine("Welcome to the Colony");
                Playerinfo Player = currentPlayer;
                return Player;
            }
            else if (i == "3")
            {
                Console.WriteLine("Welcome to the Shipwright");
                Spaceship playerShip = ShipWright(currentPlayer.PlayerShip);
                playerShip.ShipInfo();

                Playerinfo Player = new Playerinfo(currentPlayer.PlayerName, playerShip);
                Spaceship.ships.Add(playerShip);
                
                //To test if all ships are being added to ship list
                /*foreach (Spaceship ship in Spaceship.ships)
                {
                    ship.ShipInfo();

                }*/
                return Player;

            }

            else
            {
                Console.WriteLine("Please try again");
                Playerinfo Player = currentPlayer;
                return Player;


            }


            
            
        }
        static public Spaceship ShipWright(Spaceship spaceship)
        {
            Console.WriteLine("Welcome to the Shipwright, press 1 for new ship press 2 to see your current ship");
            string i = Console.ReadLine();
            if (i == "1")
            {
                return NewShip();
            }
            else //(i=="2")
            {
                if (spaceship == null)
                {
                    Console.WriteLine("You don't have a ship. I will generate one for you");
                    return NewShip();
                }
                else
                {
                    spaceship.ShipInfo();
                    return spaceship;
                }
            }
            


        }
        static public Spaceship NewShip()
        {
            
            Console.WriteLine("Please enter your ship name");
            string shipName = Console.ReadLine();
            Spaceship Playership = new Gamerules.Spaceship(shipName);
            return Playership;
            


        }
        static public List<Item> PossibleItems()
        {
            List<Item> itemlist = new List<Item>()
            {
                new Item(){ItemNumber=1,ItemName="Iron", Price=10},
                new Item(){ItemNumber=2,ItemName="Computer Chips", Price=55},
                new Item(){ItemNumber=3,ItemName="Gems", Price=100},
                new Item(){ItemNumber=4,ItemName="Food Rations", Price=20},
                new Item(){ItemNumber=5,ItemName="Rare Elements", Price=250},
                new Item(){ItemNumber=6,ItemName="Fashionable Furniture", Price=100},
                new Item(){ItemNumber=7,ItemName="Livestock", Price=30},
                new Item(){ItemNumber=8,ItemName="Plasma", Price=125},
                new Item(){ItemNumber=9,ItemName="Robots", Price=150},
                new Item(){ItemNumber=10,ItemName="GPU's", Price=100},
                
            };
            return itemlist;
        }
    }

    class Program
    {
        //string tempString;
        static void Main(string[] args)
        {
            CommandLineFunctions.PossibleItems();
            var CurrentPlayer = CommandLineFunctions.NewPlayer();
            string x = "0";
            while (x != "x")
            {
                Console.WriteLine("Type one to view the Solar System, 2 for your ship and inventory!");
                x = Console.ReadLine();
                Console.WriteLine("You have chosen " + x);
                if (x == "1")
                {
                    CurrentPlayer = CommandLineFunctions.PeacefulSystem(CurrentPlayer);
                    CurrentPlayer.ListPlayerinfo();

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
                else
                    Console.WriteLine("Welcome to inventory");

                string[] NPCNames = System.IO.File.ReadAllLines("C:\\Users\\mauri\\source\\repos\\Basic Space Game\\Commandlinetester\\namelist.txt");
                /*foreach (var names in NPCNames)
                {
                    Console.WriteLine(names);
                }*/
            }

        }
    }
}
