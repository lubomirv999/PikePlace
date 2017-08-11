namespace Pike_Place.Models.Spells.Warrior
{
    public class Charge : ISpell
    {
        private const int InitDamage = 5;
        private const int InitManaCost = 5;

        public Charge()
        {
            this.Damage = InitDamage;
            this.ManaCost = InitManaCost;
        }

        public int Damage { get; }
        public int ManaCost { get; }
    }
}