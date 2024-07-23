namespace RPG.Inventory.Items.Weapons
{
    public class Sword : Item
    {
        public Sword()
        {
            Name = "A wooden sword";
            Description = "Useful for defending yourself";
            Weight = 3;
            Type = ItemType.Weapon;
        }
    }
}
