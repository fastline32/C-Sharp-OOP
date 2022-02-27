using System;
using System.Diagnostics.CodeAnalysis;

namespace PizzaCalories
{
    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    public class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()!.Split();
            Pizza pizza = null;
            try
            {
                pizza = new Pizza(input[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            input = Console.ReadLine()!.Split();
            try
            {
                pizza.Dough = new Dough(input[1], input[2], double.Parse(input[3]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            
            string line = Console.ReadLine();
            while (line != "END")
            {
                input = line.Split();
                Topping topping = null;
                try
                {
                    topping = new Topping(input[1], double.Parse(input[2]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }

                try
                {
                    pizza.Add(topping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                line = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
        }
    }
}
