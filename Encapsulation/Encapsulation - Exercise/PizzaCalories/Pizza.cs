using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dought;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            Dough = dought;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value == " " || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }

        }

        public Dough Dough
        {
            get
            {
                return this.dought;
            }
            set
            {
                this.dought = value;
            }
        }

        public double Calories
        {
            get
            {
                double sum = 0;
                sum += dought.Calories;
                foreach (var topping in Toppings)
                {
                    sum += topping.Calories;
                }
                return sum;
            }
        }

        public List<Topping> Toppings => toppings;

        public void Add(Topping topping)
        {
            if (toppings.Count < 10)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}
