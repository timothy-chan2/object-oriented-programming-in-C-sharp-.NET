using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Armor
{
    public class MiniShield : Item
    {
        public MiniShield()
        {
            Name = "A small shield";
            Description = "Useful for protecting yourself";
            Weight = 3;
            Type = "Armor";
        }
    }
}
