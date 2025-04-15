using System.Collections.Generic;

namespace Game.Models
{
    public class Inventory
    {
        public Dictionary<string, int> Items { get; private set; }

        public Inventory()
        {
            Items = new Dictionary<string, int>();
        }

        public void AddItem(string itemName, int quantity)
        {
            if (Items.ContainsKey(itemName))
            {
                Items[itemName] += quantity;
            }
            else
            {
                Items[itemName] = quantity;
            }
        }

        public bool RemoveItem(string itemName, int quantity)
        {
            if (Items.ContainsKey(itemName) && Items[itemName] >= quantity)
            {
                Items[itemName] -= quantity;
                if (Items[itemName] == 0)
                {
                    Items.Remove(itemName);
                }
                return true;
            }
            return false;
        }

        public int GetItemQuantity(string itemName)
        {
            return Items.ContainsKey(itemName) ? Items[itemName] : 0;
        }
    }
}
