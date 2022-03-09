using System;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        
        public override string ProduceSound() => "Meow";

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.30;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
