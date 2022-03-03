using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        public ICollection<IPrivate> Privates { get; set; }
    }
}