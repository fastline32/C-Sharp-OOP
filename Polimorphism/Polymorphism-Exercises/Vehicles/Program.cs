using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main()
        {
            string[] infoLine = Console.ReadLine()!.Split();
            Car car = new Car(double.Parse(infoLine[1]), double.Parse(infoLine[2]));
            infoLine = Console.ReadLine()!.Split();
            Truck truck = new Truck(double.Parse(infoLine[1]), double.Parse(infoLine[2]));
            int rows = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < rows; i++)
            {
                infoLine = Console.ReadLine()!.Split();
                if (infoLine[0] == "Drive")
                {
                    if (infoLine[1] == "Car")
                    {
                        car.Drive(double.Parse(infoLine[2]));
                    }
                    else if (infoLine[1] == "Truck")
                    {
                        truck.Drive(double.Parse(infoLine[2]));
                    }
                }
                else if (infoLine[0] == "Refuel")
                {
                    if (infoLine[1] == "Car")
                    {
                        car.Refuel(double.Parse(infoLine[2]));
                    }
                    else if (infoLine[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(infoLine[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
