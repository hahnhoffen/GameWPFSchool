using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGameSchool
{
    public class Fighters
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Type { get; set; }
        public Fighters(String type, Item item)
        {
            this.Items.Add(item);
            this.Type = type;

        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public List<Item> GetItems() { return Items;}
    }
}
