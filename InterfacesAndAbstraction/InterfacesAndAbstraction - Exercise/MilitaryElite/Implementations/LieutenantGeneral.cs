using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class LieutenantGeneral : Private,ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates { get; set; }
    }
}