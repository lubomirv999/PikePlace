using Pike_Place.Models;

namespace Pike_Place.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int Health = 60;

        public int Power = 80;

        public int Level = 1;
    }
}