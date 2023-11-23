using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGameSchool
{
    public class Item
    {
        public string Type {  get; set; }
        public Item(String type) 
        {
            this.Type = type;
        }
        public override string ToString()
        {
            return this.Type;
        }
    }
}
