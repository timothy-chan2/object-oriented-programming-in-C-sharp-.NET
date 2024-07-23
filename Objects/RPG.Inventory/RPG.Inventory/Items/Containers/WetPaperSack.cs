namespace RPG.Inventory.Items.Containers
{
    public class WetPaperSack : WeightRestrictedContainer
    {
        public WetPaperSack() : base(8, 3)
        {
            Name = "A wet paper sack";
            Description = "Container that cannot carry a lot of weight";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
