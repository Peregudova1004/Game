using Game.Models;
using System.Collections.Generic;

namespace Game.Controllers
{
    public class FarmController
    {
        private readonly FarmModel _model;
        private readonly Inventory _inventory;
        private readonly Shop _shop;

        public FarmController(FarmModel model)
        {
            _model = model;
            _inventory = new Inventory();
            _shop = new Shop();
        }

        // Получение текущего количества денег
        public decimal GetMoney() => _model.Money;

        // Получение текущего дня
        public int GetDay() => _model.Day;

        // Посадка урожая на основе выбранного семени
        public bool PlantCrop(string seedName)
        {
            // Определяем тип растения на основе имени семян
            Plant.PlantType plantType;
            if (seedName.Contains("Wheat")) plantType = Plant.PlantType.Wheat;
            else if (seedName.Contains("Carrot")) plantType = Plant.PlantType.Carrot;
            else if (seedName.Contains("Pumpkin")) plantType = Plant.PlantType.Pumpkin;
            else return false; // Если тип семян не распознан, возвращаем false

            // Проверяем наличие семян в инвентаре
            if (_inventory.GetItemQuantity(seedName) > 0)
            {
                _inventory.RemoveItem(seedName, 1);
                _model.Plants.Add(new Plant(plantType));
                return true;
            }
            return false;
        }

        // Переход к следующему дню
        public void NextDay()
        {
            _model.NextDay();
            foreach (var plant in _model.Plants)
            {
                plant.Grow();
            }
        }

        // Покупка предмета
        public bool BuyItem(string itemName, int quantity)
        {
            return _shop.BuyItem(itemName, quantity, _model, _inventory);
        }

        // Продажа предмета
        public bool SellItem(string itemName, int quantity)
        {
            return _shop.SellItem(itemName, quantity, _model, _inventory);
        }

        // Получение количества предметов в инвентаре
        public int GetItemQuantity(string itemName)
        {
            return _inventory.GetItemQuantity(itemName);
        }

        // Получение всех предметов инвентаря
        public Dictionary<string, int> GetInventoryItems()
        {
            return _inventory.Items;
        }

        // Получение всех товаров магазина
        public Dictionary<string, decimal> GetShopItems()
        {
            return _shop.Prices;
        }
    }
}
