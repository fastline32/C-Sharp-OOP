using System.Diagnostics;

namespace WildFarm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, int foodEaten,double wingSize) 
            : base(name, weight, foodEaten)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; }

        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}