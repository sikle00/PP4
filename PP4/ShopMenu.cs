using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    public class ShopMenu
    {
        public List<string> MenuWands;
        public List<string> MenuAnimal;
        public ShopMenu(string wandMenu, string animalMenu)
        { 
            MenuWands = new List<string> { };
            MenuAnimal = new List<string> { };
        }
    }
}
