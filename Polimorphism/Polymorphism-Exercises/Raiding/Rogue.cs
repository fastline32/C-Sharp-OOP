namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string name) : base(name)
        {

        }

        public override int Power => power;

        public override string CastAbility() => $"{this.GetType().Name} - {Name} hit for {Power} damage";
        
    }
}