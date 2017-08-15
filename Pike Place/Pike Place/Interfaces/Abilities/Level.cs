namespace Pike_Place.Interfaces.Abilities
{
    public class Level : ILevel
    {
        private int experience;
        private int currentLevel;
        private const int ExperienceMultyplier = 100;
        private const int StartLevel = 1;

        public Level()
        {
            this.CurrentLevel = StartLevel;
        }

        public int CurrentLevel
        {
            get { return this.currentLevel; } 
            private set { this.currentLevel = value; }
        }

        public int Experience
        {
            get
            {
                return this.experience;
                
            }
            set { this.experience = value; }
        }

        public void LevelUp(int expGainFromMonster)
        {
            this.experience += expGainFromMonster;

            var expNeededForLvlUp = this.CurrentLevel * ExperienceMultyplier;

            if (this.experience >= expNeededForLvlUp)
            {
                this.CurrentLevel += 1;
                this.experience %= expNeededForLvlUp;
            }
        }
        
    }
}