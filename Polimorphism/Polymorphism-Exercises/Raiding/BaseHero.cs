using System.Threading;

namespace Raiding
{
    public abstract class BaseHero : IBasedHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; }
        public virtual int Power { get; }
        public abstract string CastAbility();
    }
}