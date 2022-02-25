using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name,double money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name { get { return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }

        } 
        public double Money { get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products { get { return products; } }

        public void BuyProduct(Product product)
        {
            this.products.Add(product);
        }
    }
}
