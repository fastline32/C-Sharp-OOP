namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name) : base(name)
        {

        }

        public override int Power => power;

        public override string CastAbility() => $"{this.GetType().Name} - {Name} healed for {Power}";

    }
}