namespace Pike_Place.Interfaces.Abilities
{
    public interface ILevel
    {
        int CurrentLevel { get; }

        int Experience { get; }

        void LevelUp(int expGainFromMonster);
    }
}