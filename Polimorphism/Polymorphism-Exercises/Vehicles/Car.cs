using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double litre = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public override void Drive(double distance)
        {
            double totalFuelNeeded = distance * (FuelConsumption + litre);
            if (totalFuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= totalFuelNeeded;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}