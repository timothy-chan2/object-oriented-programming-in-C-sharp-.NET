namespace RPG.Inventory.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            Name = "A health potion";
            Description = "Useful for healing";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
