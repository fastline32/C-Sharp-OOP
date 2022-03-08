namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string ToString() => "Hoot Hoot";
    }
}