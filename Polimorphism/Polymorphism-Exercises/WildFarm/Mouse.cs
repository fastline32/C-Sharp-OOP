using System;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
        }


        public override string ProduceSound() => "Squeak";

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.10;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString() => $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}