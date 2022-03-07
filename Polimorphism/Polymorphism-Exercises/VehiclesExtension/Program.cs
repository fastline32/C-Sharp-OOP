using System;

namespace VehiclesExtension
{
    internal class Program
    {
        static void Main()
        {
            string[] infoLine = Console.ReadLine()!.Split();
            Car car = new Car(double.Parse(infoLine[1]), double.Parse(infoLine[2]),double.Parse(infoLine[3]));
            infoLine = Console.ReadLine()!.Split();
            Truck truck = new Truck(double.Parse(infoLine[1]), double.Parse(infoLine[2]),double.Parse(infoLine[3]));
            infoLine = Console.ReadLine()!.Split();
            Bus bus = new Bus(double.Parse(infoLine[1]), double.Parse(infoLine[2]), double.Parse(infoLine[3]));
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
                    else if(infoLine[1] == "Bus")
                    {
                        bus.Drive(double.Parse(infoLine[2]));
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
                    else if (infoLine[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(infoLine[2]));
                    }
                }
                else if(infoLine[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(infoLine[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
