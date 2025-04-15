using System.Collections.Generic;

namespace Game.Models
{
    public class Shop
    {
        public Dictionary<string, decimal> Prices { get; private set; }

        public Shop()
        {
            Prices = new Dictionary<string, decimal>
            {
                { "WheatSeed", 10m },
                { "CarrotSeed", 15m },
                { "PumpkinSeed", 20m }
            };
        }

        public bool BuyItem(string itemName, int quantity, FarmModel farm, Inventory inventory)
        {
            if (Prices.ContainsKey(itemName))
            {
                decimal totalCost = Prices[itemName] * quantity;
                if (farm.Money >= totalCost)
                {
                    farm.Money -= totalCost;
                    inventory.AddItem(itemName, quantity);
                    return true;
                }
            }
            return false;
        }

        public bool SellItem(string itemName, int quantity, FarmModel farm, Inventory inventory)
        {
            if (Prices.ContainsKey(itemName) && inventory.RemoveItem(itemName, quantity))
            {
                decimal totalEarnings = Prices[itemName] * quantity * 0.5m; // Продаем за половину цены
                farm.Money += totalEarnings;
                return true;
            }
            return false;
        }
    }
}
