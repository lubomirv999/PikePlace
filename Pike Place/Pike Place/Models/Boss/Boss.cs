using Pike_Place.Interfaces.Creatures;

namespace Pike_Place.Models.Boss
{
    public class Boss : IBoss
    {
        public string Name { get; }

        public int Health { get; }

        public int Power { get; }
    }
}