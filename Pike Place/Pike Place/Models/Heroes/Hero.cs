using Pike_Place.Interfaces;

namespace Pike_Place.Models
{
    public abstract class Hero : IHero
    {
        public string Name { get; }

        public int Health { get; }

        public int Power { get; }

        public int Level { get; }
    }
}