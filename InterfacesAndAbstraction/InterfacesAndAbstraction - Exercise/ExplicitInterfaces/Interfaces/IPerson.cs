namespace ExplicitInterfaces.Interfaces
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }

        public void GetName();
    }
}