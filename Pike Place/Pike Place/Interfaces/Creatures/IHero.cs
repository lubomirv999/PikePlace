using Pike_Place.Interfaces.Abilities;
using Pike_Place.Interfaces.Creatures;

namespace Pike_Place.Interfaces
{
    public interface IHero : IDamagable , IMana
    {
        string Name { get; }

        int Health { get; }

        int AttackPower { get; }

        ILevel Level { get; }
        
    }
}