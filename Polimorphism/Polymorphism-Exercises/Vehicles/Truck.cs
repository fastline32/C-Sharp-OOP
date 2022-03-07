using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double litre = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
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
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += (fuel / 100) * 95;
        }
    }
}