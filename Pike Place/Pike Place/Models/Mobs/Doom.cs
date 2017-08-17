using Pike_Place.Models.Others;

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
            this.Position = new Coordinates(Constants.Constants.MobSpawnPositionX, Constants.Constants.MobSpawnPositionY);
            this.MobPicture = Constants.Constants.DoomPicture;
        }

        public override string ToString()
        {
            return $"{nameof(Doom)}";
        }
    }
}