namespace Pike_Place.Models.Mobs
{
    public class TheViper : Mob
    {
        private const int InitHealth = 7;
        private const int InitAttack = 4;
        private const int InitExperience = 15;

        public TheViper()
        {
            this.Health = InitHealth;
            this.Attack = InitAttack;
            this.Experience = InitExperience;
        }

        public override string ToString()
        {
            return $"{nameof(TheViper)}";
        }
    }
}