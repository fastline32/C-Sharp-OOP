using System;
using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IPerson,IResident
    {
        public string Name { get; private set; }
        public string Country { get; private set; }

        public Citizen(string name, string country,int age)
        {
            Name=name;
            Country=country;
            Age=age;
        }
        void IResident.GetName()
        {
            Console.WriteLine($"{Name}");
        }

        public int Age { get; private set; }
        void IPerson.GetName()
        {
            Console.WriteLine($"Mr/Ms/Mrs {Name}");
        }
    }
}