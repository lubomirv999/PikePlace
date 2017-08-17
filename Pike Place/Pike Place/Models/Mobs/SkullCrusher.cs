using Pike_Place.Models.Others;

namespace Pike_Place.Models.Mobs
{
    public class SkullCrusher : Mob
    {
        private const int InitHealth = 15;
        private const int InitAttack = 3;
        private const int InitExperience = 12;

        public SkullCrusher()
        {
            this.Health = InitHealth;
            this.Attack = InitAttack;
            this.Experience = InitExperience;
            this.Position = new Coordinates(Constants.Constants.MobSpawnPositionX, Constants.Constants.MobSpawnPositionY);
            this.MobPicture = Constants.Constants.SkullPicture;
        }

        public override string ToString()
        {
            return $"{nameof(SkullCrusher)}";
        }
    }
}