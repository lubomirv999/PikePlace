using System;
using Pike_Place.Interfaces.Concreet;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models;
using Pike_Place.Models.Spells;
using Pike_Place.Models.Spells.Marsman;

namespace Pike_Place.Heroes
{
    public class Marksman : Hero
    {
        private const int InitHealth = 10;
        private const int InitAttackPower = 3;
        private const int InitMana = 10;

        public Marksman(string name)
        {
            this.Name = name;
            this.Level = new Level();
            this.Spell = new LongShot();
            this.Health = InitHealth * this.Level.CurrentLevel;
            this.AttackPower = InitAttackPower * this.Level.CurrentLevel;
            this.Mana = InitMana * this.Level.CurrentLevel;
        }
        
    }
}