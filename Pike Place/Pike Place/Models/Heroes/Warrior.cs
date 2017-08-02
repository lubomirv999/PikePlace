using Pike_Place.Models;

namespace Pike_Place.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int Health { get; }

        public int Power { get; }

        public int Level { get; }
    }
}