using System;
using Pike_Place.Interfaces.Concreet;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models;
using Pike_Place.Models.Spells;

namespace Pike_Place.Heroes
{
    public class Mage : Hero
    {
        private const int InitHealth = 10;
        private const int InitAttackPower = 3;
        private const int InitMana = 10;

        public Mage(string name)
        {
            this.Name = name;
            this.Level = new Level();
            this.Spell = new FrostBolt();
            this.Health = InitHealth * this.Level.CurrentLevel;
            this.AttackPower = InitAttackPower * this.Level.CurrentLevel;
            this.Mana = InitMana * this.Level.CurrentLevel;
        }
        
        public override string AttackWithSpell(IMob mob)
        {
            mob.TakeDamage(Spell.Damage);

            if (this.Mana < Spell.ManaCost)
            {
                throw new ArgumentException("Not enough mana");
            }
            this.Mana -= Spell.ManaCost;

            this.Level.LevelUp(mob.GiveExperience());

            return $"The Monster is Dead! Experience Gain: {mob.GiveExperience()}";
        }
    }
}