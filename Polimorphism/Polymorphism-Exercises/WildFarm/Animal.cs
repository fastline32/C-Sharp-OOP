﻿namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name,double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }
        public string Name { get;}
        public double Weight { get;}
        public int FoodEaten { get;}
        public abstract string ToString();
    }
}