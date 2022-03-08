namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, int foodEaten,string livingRegion) 
            : base(name, weight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }
    }
}