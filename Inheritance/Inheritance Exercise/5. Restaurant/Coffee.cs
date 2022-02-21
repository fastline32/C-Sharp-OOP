namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;

        public Coffee(string name, double caffeine, double milliliters = CoffeeMilliliters, decimal price = CoffeePrice) : base(name, price, milliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
