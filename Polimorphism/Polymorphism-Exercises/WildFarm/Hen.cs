namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
        }


        public override string ProduceSound() => "Cluck";

        public override void Eat(IFood food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }
    }
}