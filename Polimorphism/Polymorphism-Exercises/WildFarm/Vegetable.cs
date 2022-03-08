namespace WildFarm
{
    public class Vegetable : Food , IFood
    {
        public Vegetable(int quantity) 
            : base(quantity)
        {
        }
    }
}