using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Gamerules
{
    public  class Spaceship
    {
        public static int _counter = 1;
        
        public int SpaceshipId { get; set; }
        public string SpaceshipName { get; set; }
        public int MaxFuel { get; set; }
        public int CurrentFuel { get; set; }
        public int InventorySize { get; set; }
        public static List<Item> Inventory { get; set; }

        public Spaceship(string name, int fuel, int inv)
        {
            this.SpaceshipId = Interlocked.Increment(ref _counter);
            this.SpaceshipName = name;
            this.MaxFuel = fuel;
            this.CurrentFuel = fuel;
            this.InventorySize = inv;

        }
        public Spaceship()
        {
            this.SpaceshipId = 0;
            this.SpaceshipName = "0";
            this.MaxFuel = 0;
            this.CurrentFuel = 0;
            this.InventorySize = 0;

        }
        public Spaceship(string name)
        {
            this.SpaceshipId = Interlocked.Increment(ref _counter);
            this.SpaceshipName = name;
            Random r = new Random();
            int fuel = r.Next(80, 140);
            this.MaxFuel = fuel;
            this.CurrentFuel = fuel;
            int inv = r.Next(20, 40);
            this.InventorySize = inv;            
        }
        public void ShipInfo()
        {
            Console.WriteLine(this.SpaceshipId.ToString());
            Console.WriteLine(this.SpaceshipName);
            Console.WriteLine(this.MaxFuel.ToString());
            Console.WriteLine(this.CurrentFuel.ToString());
            Console.WriteLine(this.InventorySize.ToString());

        }
        public static List<Spaceship> ships = new List<Spaceship>();
        

    }
}
