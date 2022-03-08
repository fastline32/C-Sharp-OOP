namespace WildFarm
{
    public class Fruit : Food, IFood
    {
        public Fruit(int quantity) 
            : base(quantity)
        {
        }
    }
}