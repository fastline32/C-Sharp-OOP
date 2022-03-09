using System;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string ProduceSound() => "Hoot Hoot";

        public override void Eat(IFood food)
        {
            if (food.GetType().Name=="Meat")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.25;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}