using System;
using System.Collections.Generic;

namespace WildFarm
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            List<IAnimal> animals = new List<IAnimal>();
            while (command !=  "End")
            {
                try
                {
                    string[] inputInfo = command.Split();
                    string type = inputInfo[0];
                    string name = inputInfo[1];
                    double weight = double.Parse(inputInfo[2]);
                    IAnimal animal = null;
                    if (type == "Cat")
                    {
                        string livingRegion = inputInfo[3];
                        string breed = inputInfo[4];
                        animal = new Cat(name, weight, 0, livingRegion, breed);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    else if (type == "Tiger")
                    {
                        string livingRegion = inputInfo[3];
                        string breed = inputInfo[4];
                        animal = new Tiger(name, weight, 0, livingRegion, breed);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    else if (type == "Mouse") 
                    {
                        string livingRegion = inputInfo[3];
                        animal = new Mouse(name, weight, 0, livingRegion);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    else if (type == "Dog")
                    {
                        string livingRegion = inputInfo[3];
                        animal = new Dog(name, weight, 0, livingRegion);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    else if (type == "Owl")
                    {
                        double wingSize = double.Parse(inputInfo[3]);
                        animal = new Owl(name, weight, 0, wingSize);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    else if (type == "Hen")
                    {
                        double wingSize = double.Parse(inputInfo[3]);
                        animal = new Hen(name, weight, 0, wingSize);
                        Console.WriteLine(animal.ProduceSound());
                    }
                    animals.Add(animal);
                    Food food = null;
                    string[] foodInfo = Console.ReadLine()!.Split();
                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);
                    if (foodType == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                        animal.Eat(food);
                    }
                    else if (foodType == "Fruit")
                    {
                        food = new Fruit(quantity);
                        animal.Eat(food);
                    }
                    else if (foodType == "Meat")
                    {
                        food = new Meat(quantity);
                        animal.Eat(food);
                    }
                    else if (foodType == "Seeds")
                    {
                        food = new Seeds(quantity);
                        animal.Eat(food);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
