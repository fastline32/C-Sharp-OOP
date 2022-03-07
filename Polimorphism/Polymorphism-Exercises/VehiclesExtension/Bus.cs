using System;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double litre = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption,double tankCapacity) 
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {

        }

        public override void Drive(double distance)
        {
            double totalFuelNeeded = distance * (FuelConsumption+litre);
            if (totalFuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= totalFuelNeeded;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            double totalFuelNeeded = distance * (FuelConsumption);
            if (totalFuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= totalFuelNeeded;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }


        public override void Refuel(double fuel)
        {
            if (fuel<1)
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