using System;
using Pike_Place.Interfaces.Concreet;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models;
using Pike_Place.Models.Spells;
using Pike_Place.Models.Spells.Warrior;

namespace Pike_Place.Heroes
{
    public class Warrior : Hero
    {
        private const int InitHealth = 10;
        private const int InitAttackPower = 3;
        private const int InitMana = 10;

        public Warrior(string name)
        {
            this.Name = name;
            this.Level = new Level();
            this.Spell = new Charge();
            this.Health = InitHealth * this.Level.CurrentLevel;
            this.AttackPower = InitAttackPower * this.Level.CurrentLevel;
            this.Mana = InitMana * this.Level.CurrentLevel;
        }
        
    }
}