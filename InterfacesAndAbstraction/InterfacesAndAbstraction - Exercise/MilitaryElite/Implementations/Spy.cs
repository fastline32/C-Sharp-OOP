using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class Spy : Soldier,ISpy
    {
        public Spy(int id, string firstName, string lastName, string codeNumber) 
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public string CodeNumber { get; set; }
    }
}