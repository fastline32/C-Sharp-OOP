namespace Raiding
{
    public interface IBasedHero
    {
        public string Name { get; }
        public int Power { get; }
        public string CastAbility();
    }
}