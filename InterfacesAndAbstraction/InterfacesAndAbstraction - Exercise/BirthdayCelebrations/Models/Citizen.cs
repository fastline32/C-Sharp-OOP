using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdent
    {
        public Citizen(string name, int age, string id, string birthday)
        {
           this.Name = name;
           this.Age = age;
           this.Id = id;
           this.Birthday = birthday;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthday { get; }
    }
}
