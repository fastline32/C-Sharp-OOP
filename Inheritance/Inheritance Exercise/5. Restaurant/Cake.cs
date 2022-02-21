namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5;
        public Cake(string name,decimal price = CakePrice,double grams = CakeGrams, double calories = CakeCalories) 
            : base(name, price, grams, calories)
        {

        }
    }
}
