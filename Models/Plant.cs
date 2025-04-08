namespace Game.Models
{
    public class Plant
    {
        public enum PlantType { Wheat, Carrot, Pumpkin }

        public PlantType Type { get; }
        public int Growth { get; private set; }
        public int MaxGrowth { get; } = 5;
        public bool IsReady => Growth >= MaxGrowth;

        public Plant(PlantType type) => Type = type;

        public void Grow()
        {
            if (!IsReady) Growth++;
        }
    }
}