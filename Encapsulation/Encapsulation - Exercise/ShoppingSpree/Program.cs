using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<Person> persons = new List<Person>();
            string[] peoples = line.Split(';',StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < peoples.Length; i++)
                {
                    string[] peopleArgs = peoples[i].Split('=',StringSplitOptions.RemoveEmptyEntries);
                    Person person = null;
                    try
                    {
                        person = new Person(peopleArgs[0], double.Parse(peopleArgs[1]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);
                    }
                    persons.Add(person);
                }
            List<Product> products = new List<Product>();
            string[] items = Console.ReadLine()!.Split(';',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < items.Length; i++)
            {
                string[] itemArgs = items[i].Split('=');
                Product product = new Product(itemArgs[0], double.Parse(itemArgs[1]));
                products.Add(product);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                
            }
        }
    }
}
