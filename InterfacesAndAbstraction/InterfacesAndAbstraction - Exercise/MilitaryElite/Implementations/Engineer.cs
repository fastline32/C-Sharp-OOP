using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class Engineer : SpecialisedSoldier,IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; set; }
    }
}