namespace Pike_Place.Interfaces.Creatures
{
    public interface IMob : IDamagable
    {
        int Health { get; }

        int Attack { get; }
        
        int Experience { get; }

        int GiveExperience();

        bool IsDead();
    }
}