﻿using System.Dynamic;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower,double fuel)
        {
            HorsePower=horsePower;
            Fuel = fuel;
            FuelConsumption = DefaultFuelConsumption;
        }
        public virtual double FuelConsumption { get; set; }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}
