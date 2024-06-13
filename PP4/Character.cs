using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    internal class Character
    {
        public string Name = "";
        public string House = "";
        public string Inventory = "";
        public Character(string name, string house, string inventory)
        {
            Name = name;
            House = house;
            Inventory = inventory;
        }
    }
}
