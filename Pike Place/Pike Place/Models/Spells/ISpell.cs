namespace Pike_Place.Models.Spells
{
    public interface ISpell
    {
        int Damage { get; }

        int ManaCost { get; }
    }
}