using Pike_Place.Interfaces.Creatures;

namespace Pike_Place.Models.Mobs
{
    public abstract class Mob : IMob
    {
        public string Name { get; }

        public int Health { get; }

        public int Power { get; }
    }
}