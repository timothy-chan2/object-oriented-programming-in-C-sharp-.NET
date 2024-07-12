using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class PotionSatchel : Container
    {
        public PotionSatchel() : base(4)
        {

        }

        public override bool AddItem(Item itemToAdd)
        {
            if (itemToAdd.Type == "Potion")
            {
                return base.AddItem(itemToAdd);
            }

            return false;
        }
    }
}
