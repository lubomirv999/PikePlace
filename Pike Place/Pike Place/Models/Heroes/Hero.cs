using Pike_Place.Interfaces;

namespace Pike_Place.Models
{
    public abstract class Hero : IHero
    {
        public string Name { get; }

        public int Health { get; set; }

        public int Power { get; set; }

        public int Level { get; set; }
    }
}