using NUnit.Framework;
using RPG.Inventory.Items;
using RPG.Inventory.Items.Containers;
using RPG.Inventory.Items.Potions;
using RPG.Inventory.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            AddItemStatus actual = b.AddItem(p);
            Assert.That(actual, Is.EqualTo(AddItemStatus.Success));
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack b = new Backpack();
            Sword s = new Sword();

            b.AddItem(s);
            b.AddItem(s);
            b.AddItem(s);
            b.AddItem(s);

            AddItemStatus actual = b.AddItem(s);
            Assert.That(actual, Is.EqualTo(AddItemStatus.BagIsFull));
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);
            Item actual = b.RemoveItem();
            Assert.That(actual, Is.EqualTo(p));
        }

        [Test]
        public void EmptyBackpackReturnsNull()
        {
            Backpack b = new Backpack();

            Item item = b.RemoveItem();
            Assert.That(item, Is.EqualTo(null));
        }

        [Test]
        public void PotionSatchelOnlyAllowsPotions()
        {
            PotionSatchel satchel = new PotionSatchel();
            Sword sword = new Sword();

            AddItemStatus actual = satchel.AddItem(sword);
            Assert.That(actual, Is.EqualTo(AddItemStatus.ItemNotRightType));

            HealthPotion potion = new HealthPotion();
            actual = satchel.AddItem(potion);
            Assert.That(actual, Is.EqualTo(AddItemStatus.Success));
        }

        [Test]
        public void WeightRestrictedBagRestrictsWeight()
        {
            WetPaperSack sack = new WetPaperSack();
            HealthPotion potion = new HealthPotion();

            Assert.That(sack.AddItem(potion), Is.EqualTo(AddItemStatus.Success));

            Sword sword = new Sword();
            Assert.That(sack.AddItem(sword), Is.EqualTo(AddItemStatus.BagIsTooHeavy));

            sack.RemoveItem();
            Assert.That(sack.AddItem(sword), Is.EqualTo(AddItemStatus.Success));
        }
    }
}
