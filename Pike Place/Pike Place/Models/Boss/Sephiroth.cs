namespace Pike_Place.Models.Boss
{
    public class Sephiroth : Boss
    {
        public Sephiroth(string name, int health, int power)
        {
            this.Name = name;
            this.Health = health;
            this.Power = power;
        }

        public string Name { get; }

        public int Health { get; }

        public int Power { get; }
    }
}