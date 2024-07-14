using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class WeightRestrictedContainer : Container
    {
        private int _maxWeight;
        private int _currentWeight;
        
        public WeightRestrictedContainer(int capacity, int maxWeight) : base(capacity)
        {
            _maxWeight = maxWeight;
        }

        public override bool AddItem(Item itemToAdd)
        {
            if (_currentWeight + itemToAdd.Weight > _maxWeight)
            {
                return false;
            }
            
            bool itemAdded = base.AddItem(itemToAdd);

            if (itemAdded)
            {
                _currentWeight += itemToAdd.Weight;
            }

            return itemAdded;
        }
    }
}
