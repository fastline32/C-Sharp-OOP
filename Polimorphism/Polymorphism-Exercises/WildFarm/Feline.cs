namespace WildFarm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, int foodEaten, string livingRegion,string breed) 
            : base(name, weight, foodEaten, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get;}

        public override string ToString() =>
            $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}