using Pike_Place.Interfaces.Abilities;
using Pike_Place.Models.Spells.Warrior;

namespace Pike_Place.Models.Heroes
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
            this.HeroPicture = Constants.Constants.MagePicture;
            this.Height = Constants.Constants.MageHeight;
            this.Width = Constants.Constants.MageWidth;
           
        }
        
    }
}