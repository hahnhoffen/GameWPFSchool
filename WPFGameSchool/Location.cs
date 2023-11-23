using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGameSchool
{
    public class Location
    {
        public string Position { get; set; }
        public Item Loot { get; set; }
        public Location(String position, Item loot) 
        { 
            this.Position = position;
            this.Loot = loot;
        }
        public Item getloot()
        {
            return this.Loot;
        }
    }
}
