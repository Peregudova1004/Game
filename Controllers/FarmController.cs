using Game.Models;

namespace Game.Controllers
{
    public class FarmController
    {
        private readonly FarmModel _model;

        public FarmController(FarmModel model)
        {
            _model = model;
        }

        // Добавляем методы для доступа к данным модели
        public decimal GetMoney() => _model.Money;
        public int GetDay() => _model.Day;

        public void PlantCrop(Plant.PlantType type)
        {
            _model.Plants.Add(new Plant(type));
        }

        public void NextDay()
        {
            _model.NextDay();
        }
    }
}