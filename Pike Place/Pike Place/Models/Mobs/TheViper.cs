using Pike_Place.Models.Others;

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
            this.Position = new Coordinates(Constants.Constants.MobSpawnPositionX, Constants.Constants.MobSpawnPositionY);
            this.MobPicture = Constants.Constants.ViperPicture;
        }

        public override string ToString()
        {
            return $"{nameof(TheViper)}";
        }
    }
}