using Pike_Place.Models;

namespace Pike_Place.Heroes
{
    public class Marksman : Hero
    {
        public Marksman(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int Health { get; }

        public int Power { get; }

        public int Level { get; }
    }
}