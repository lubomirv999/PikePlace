namespace Pike_Place.Interfaces
{
    public interface ILevel
    {
        int CurrentLevel { get; }

        int Experience { get; }

        void LevelUp(int expGainFromMonster);
    }
}