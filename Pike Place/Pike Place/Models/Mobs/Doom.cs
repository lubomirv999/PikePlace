namespace Pike_Place.Models.Mobs
{
    public class Doom : Mob
    {
        private const int InitHealth = 10;
        private const int InitAttack = 1;
        private const int InitExperience = 10;

        public Doom()
        {
            this.Health = InitHealth;
            this.Attack = InitAttack;
            this.Experience = InitExperience;
        }

        public override string ToString()
        {
            return $"{nameof(Doom)}";
        }
    }
}