namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public abstract void Drive(double distance);

        public abstract void Refuel(double fuel);
    }
}