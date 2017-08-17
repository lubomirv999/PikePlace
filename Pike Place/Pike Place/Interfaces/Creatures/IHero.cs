using Pike_Place.Interfaces.Abilities;

namespace Pike_Place.Interfaces.Creatures
{
    public interface IHero : IDamagable, IMana, IMoveable, IDrawable,IHealable,IMortal
    {
        string Name { get; }

        int Health { get; }

        int AttackPower { get; }

        ILevel Level { get; }     
    }
}