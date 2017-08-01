namespace Pike_Place.Models.Mobs
{
    public class Doom : Mob
    {
        public Doom(string name, int health, int power)
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