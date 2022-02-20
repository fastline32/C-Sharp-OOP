namespace Zoo
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get { return this.name;} set { this.name = value; } }
    }
}
