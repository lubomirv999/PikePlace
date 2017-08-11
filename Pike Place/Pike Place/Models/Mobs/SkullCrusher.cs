namespace Pike_Place.Models.Mobs
{
    public class SkullCrusher : Mob
    {
        private const int InitHealth = 15;
        private const int InitAttack = 2;
        private const int InitExperience = 12;

        public SkullCrusher()
        {
            this.Health = InitHealth;
            this.Attack = InitAttack;
            this.Experience = InitExperience;
        }

        public override string ToString()
        {
            return $"{nameof(SkullCrusher)}";
        }
    }
}