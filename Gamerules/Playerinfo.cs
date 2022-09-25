using System;
using System.Collections.Generic;
using System.Text;

namespace Gamerules
{
    public class Playerinfo
    {
       public string PlayerName { get; set; }

        public Spaceship PlayerShip { get; set; }
        public Playerinfo(string name)
        {
            this.PlayerName = name;
            this.PlayerShip = null;

        }
        public Playerinfo(string name, Spaceship spaceship)
        {
            this.PlayerName = name;
            this.PlayerShip = spaceship;

        }
        public void ListPlayerinfo()
        {
            Console.WriteLine(this.PlayerName.ToString());
            this.PlayerShip.ShipInfo();
            
            

        }


    }


}
