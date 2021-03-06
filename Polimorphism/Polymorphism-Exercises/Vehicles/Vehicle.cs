namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity,double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public abstract void Drive(double distance);

        public abstract void Refuel(double fuel);
    }
}