using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "Beast!")
            {
                string[] inputInfo = Console.ReadLine()!.Split();
                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);
                string gender = inputInfo[2];
                switch (input)
                {
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);break;
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog); break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog); break;
                    case "Kitten":
                        Kitten kittens = new Kitten(name, age);
                        animals.Add(kittens); break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat); break;
                }
                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
