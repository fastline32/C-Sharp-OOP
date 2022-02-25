using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string,Person> persons = new Dictionary<string, Person>();
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
                    persons.Add(peopleArgs[0],person);
                }
            Dictionary<string,Product> products = new Dictionary<string,Product>();
            string[] items = Console.ReadLine()!.Split(';',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < items.Length; i++)
            {
                string[] itemArgs = items[i].Split('=');
                Product product = null;
                try
                {
                    product = new Product(itemArgs[0], double.Parse(itemArgs[1]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                
                products.Add(itemArgs[0],product);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] input = command.Split();
                string person = input[0];
                string item = input[1];
                if (persons[person].Money >= products[item].Cost)
                {
                    Console.WriteLine($"{persons[person].Name} bought {products[item].Name}");
                    persons[person].Money -= products[item].Cost;
                    persons[person].Products.Add(products[item]);
                }
                else
                {
                    Console.WriteLine($"{persons[person].Name} can't afford {products[item].Name}");
                }
                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                List<string> names = new List<string>();
                foreach (var item in person.Value.Products)
                {
                    names.Add(item.Name);
                }

                if (person.Value.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Key} - {string.Join(", ", names)}");
                }
                else
                {
                    Console.WriteLine($"{person.Key} - Nothing bought");
                }
                
            }
        }
    }
}
//80
