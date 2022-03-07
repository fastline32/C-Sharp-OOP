using System;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double litre = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {
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
            if (fuel < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (fuel > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    FuelQuantity += fuel*0.95;
                }
            }
        }
    }
}