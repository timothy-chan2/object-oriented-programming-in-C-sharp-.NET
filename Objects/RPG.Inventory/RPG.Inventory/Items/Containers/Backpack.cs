using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class Backpack : Container
    {
        public Backpack() : base(4)
        {
            Name = "A backpack made from leather";
            Description = "Useful for bringing items along on your journey";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
