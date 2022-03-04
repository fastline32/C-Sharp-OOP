﻿using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : IIdent,IBuyer
    {
        public Citizen(string name, int age, string id, string birthday)
        {
           this.Name = name;
           this.Age = age;
           this.Id = id;
           this.Birthday = birthday;
           Food = 0;
        }
        public string Name { get;}
        public int Age { get; }
        public string Id { get; }
        public string Birthday { get; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}
