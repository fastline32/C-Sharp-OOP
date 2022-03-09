using System;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {
        }


        public override string ProduceSound() => "Woof!";

        public override void Eat(IFood food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.4;
        }

        public override string ToString() => $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}