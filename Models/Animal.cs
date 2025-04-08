namespace Game.Models
{
    public class Animal
    {
        public enum AnimalType { Chicken, Cow, Sheep }

        public AnimalType Type { get; }
        public int Products { get; private set; }

        public Animal(AnimalType type) => Type = type;

        public void Produce() => Products++;

        public int Collect()
        {
            int count = Products;
            Products = 0;
            return count;
        }
    }
}