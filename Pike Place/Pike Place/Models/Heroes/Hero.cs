using Pike_Place.Interfaces;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models.Spells;

namespace Pike_Place.Models
{
    public abstract class Hero : IHero
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public int AttackPower { get; protected set; }
        public ILevel Level { get; protected set; }
        public ISpell Spell { get; protected set; }

        public string AutoAttack(IMob mob)
        {
            mob.TakeDamage(this.AttackPower);

            this.TakeDamage(mob.Attack);

            this.Level.LevelUp(mob.GiveExperience());

            return $"The Monster is Dead! Experience Gain: {mob.GiveExperience()}";
        }
        public abstract  string AttackWithSpell(IMob mob);
        public void TakeDamage(int attackPower)
        {
            this.Health -= attackPower;
        }

       
    }
}