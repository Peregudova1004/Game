using Game.Models;
using System.Collections.Generic;

namespace Game.Models
{
    public class FarmModel
    {
        public decimal Money { get; set; } = 100;
        public int Day { get; private set; } = 1;
        public List<Plant> Plants { get; } = new List<Plant>();
        public List<Animal> Animals { get; } = new List<Animal>();

        public void NextDay()
        {
            Day++;
            foreach (var plant in Plants) plant.Grow();
            foreach (var animal in Animals) animal.Produce();
        }
    }
}