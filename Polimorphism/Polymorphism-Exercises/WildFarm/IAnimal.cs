namespace WildFarm
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }

        string ProduceSound();

        void Eat(IFood food);
    }
}