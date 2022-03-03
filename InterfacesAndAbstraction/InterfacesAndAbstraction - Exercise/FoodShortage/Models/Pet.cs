using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Pet : IIdent
    {
        public Pet(string name,string birthday)
        {
            Name=name;
            Birthday=birthday;
        }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}