namespace WildFarm
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name,double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }
        public string Name { get;}
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        public abstract string ProduceSound();

        public abstract void Eat(IFood food);
    }
}