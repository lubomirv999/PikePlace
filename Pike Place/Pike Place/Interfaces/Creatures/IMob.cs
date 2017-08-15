using Pike_Place.Interfaces.Abilities;
using Pike_Place.Models.Others;

namespace Pike_Place.Interfaces.Creatures
{
    public interface IMob : IDamagable,IDrawable
    {
        int Health { get; }

        int Attack { get; }
        
        int Experience { get; }

        Coordinates Position { get; }
        
        int GiveExperience();

        bool IsDead();
    }
}