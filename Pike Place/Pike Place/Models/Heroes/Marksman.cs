using Pike_Place.Models;

namespace Pike_Place.Heroes
{
    public class Marksman : Hero
    {
        public Marksman(string name, int health, int power, int level)
        {
            this.Name = name;
            this.Health = health;
            this.Power = power;
            this.Level = level;
        }

        public string Name { get; }

        public int Health { get; }

        public int Power { get; }

        public int Level { get; }
    }
}