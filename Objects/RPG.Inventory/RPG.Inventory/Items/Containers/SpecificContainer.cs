﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class SpecificContainer : Container
    {
        private string _requiredType;

        public SpecificContainer(int capacity, string requiredType) : base(capacity)
        {
            _requiredType = requiredType;
        }

        public override bool AddItem(Item itemToAdd)
        {
            if (itemToAdd.Type == _requiredType)
            {
                return base.AddItem(itemToAdd);
            }
            return false;
        }
    }
}
