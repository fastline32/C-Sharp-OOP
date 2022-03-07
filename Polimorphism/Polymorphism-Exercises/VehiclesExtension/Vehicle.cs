using System;

namespace VehiclesExtension
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity,double fuelConsumption,double tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }


        public abstract void Drive(double distance);

        public abstract void Refuel(double fuel);
    }
}