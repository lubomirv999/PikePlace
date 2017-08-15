using Pike_Place.Interfaces.Abilities;
using Pike_Place.Models.Spells.Marsman;

namespace Pike_Place.Models.Heroes
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
            this.HeroPicture = Constants.Constants.MagePicture;
            this.Height = Constants.Constants.MageHeight;
            this.Width = Constants.Constants.MageWidth;
           
        }
        
    }
}