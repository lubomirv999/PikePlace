namespace Pike_Place.Models.Spells.Mage
{
    public class FrostBolt : ISpell
    {
        private const int InitDamage = 2;
        private const int InitManaCost = 5;

        public FrostBolt()
        {
            this.Damage = InitDamage;
            this.ManaCost = InitManaCost;
        }

        public int Damage { get; }
        public int ManaCost { get; }
    }
}