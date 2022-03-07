using System;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double litre = 0.9;

        public Car(double fuelQuantity, double fuelConsumption,double tankCapacity) 
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {

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
            if (fuel < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (FuelQuantity + fuel > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    FuelQuantity += fuel;
                }
            }
        }
    }
}