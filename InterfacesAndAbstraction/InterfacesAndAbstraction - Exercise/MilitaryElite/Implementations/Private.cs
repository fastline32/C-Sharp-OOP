using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class Private : Soldier,IPrivate
    {
        public Private(int id, string firstName, string lastName , decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; set; }
    }
}