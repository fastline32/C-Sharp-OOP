using System.Collections.Generic;
using System.Linq;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }
        public void CompleteMission(string codeName)
        {
            var mission = Missions.FirstOrDefault(x => x.CodeName == codeName);
            mission.Status = Status.Finished;
        }
    }
}