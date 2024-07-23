﻿namespace RPG.Inventory.Items.Containers
{
    public class SpecificContainer : Container
    {
        private ItemType _requiredType;

        public SpecificContainer(int capacity, ItemType requiredType) : base(capacity)
        {
            _requiredType = requiredType;
        }

        public override AddItemStatus AddItem(Item itemToAdd)
        {
            if (itemToAdd.Type == _requiredType)
            {
                return base.AddItem(itemToAdd);
            }
            return AddItemStatus.ItemNotRightType;
        }
    }
}
