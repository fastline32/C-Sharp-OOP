namespace ExplicitInterfaces.Interfaces
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }

        public void GetName();
    }
}