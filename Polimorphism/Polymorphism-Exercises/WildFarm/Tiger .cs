using System;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) 
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override string ProduceSound() => "ROAR!!!";

        public override void Eat(IFood food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity;
        }
    }
}