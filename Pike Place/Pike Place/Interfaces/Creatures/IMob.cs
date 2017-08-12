using Pike_Place.Interfaces.Abilities;

namespace Pike_Place.Interfaces.Creatures
{
    public interface IMob : IDamagable,IDrawable
    {
        int Health { get; }

        int Attack { get; }
        
        int Experience { get; }

        int GiveExperience();

        bool IsDead();
    }
}