namespace Pike_Place.Models.Spells.Marsman
{
    public class LongShot : ISpell
    {
        private const int InitDamage = 6;
        private const int InitManaCost = 5;

        public LongShot()
        {
            this.Damage = InitDamage;
            this.ManaCost = InitManaCost;
        }

        public int Damage { get; }
        public int ManaCost { get; }
    }
}