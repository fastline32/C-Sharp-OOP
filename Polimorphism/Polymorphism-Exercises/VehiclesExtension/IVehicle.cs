namespace VehiclesExtension
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }
    }
}