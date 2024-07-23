﻿namespace RPG.Inventory.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public ItemType Type { get; set; }
    }
}
