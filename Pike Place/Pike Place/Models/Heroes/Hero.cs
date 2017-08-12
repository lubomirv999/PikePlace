using System;
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
        public Coordinates position = new Coordinates(5, 5); //move to const
        public string[] HeroPicture { get; set; }
        public ILevel Level { get; protected set; }
        public ISpell Spell { get; protected set; }

        public void TakeDamage(int attackPower)
        {
            this.Health -= attackPower;
        }

        public string AutoAttack(IMob mob)
        {
            mob.TakeDamage(this.AttackPower);

            this.TakeDamage(mob.Attack);

            this.Level.LevelUp(mob.GiveExperience());

            return $"The Monster is Dead! Experience Gain: {mob.GiveExperience()}";
        }

        public string AttackWithSpell(IMob mob)
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

        public void Draw()
        {
            Coordinates coords = new Coordinates(this.position.x, this.position.y);

            foreach (var line in HeroPicture)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine("{0}", line);
                coords.y++;
            }
        }

        public void Delete()
        {
            Coordinates coords = new Coordinates(this.position.x, this.position.y);
            for (int i = 0; i < Constants.MainShipHeight; i++)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine(new string(' ', Constants.MainShipWidth));
                coords.y++;
            }
        }

        public void Move(ConsoleKeyInfo keyInfo, ref Coordinates coords)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    this.Delete();
                    if (coords.x < Constants.PlayBoxWidth - Constants.MainShipWidth)
                    {
                        if (coords.x + Constants.MainShipSpeedX <= Constants.PlayBoxWidth - Constants.MainShipWidth)
                            coords.x += Constants.MainShipSpeedX;
                        coords.x++;
                    }
                    this.Draw();
                    break;
                case ConsoleKey.LeftArrow:
                    this.Delete();

                    if (coords.x - 1 > Constants.FrameWidth)
                    {
                        if (coords.x - Constants.MainShipSpeedX > Constants.FrameWidth)
                            coords.x -= Constants.MainShipSpeedX;
                        coords.x--;
                    }
                    this.Draw();

                    break;
                case ConsoleKey.UpArrow:
                    this.Delete();

                    if (coords.y - 1 > Constants.FrameWidth)
                    {
                        if (coords.y - Constants.MainShipSpeedY > Constants.FrameWidth)
                            coords.y -= Constants.MainShipSpeedY;
                        coords.y--;
                    }
                    this.Draw();


                    break;
                case ConsoleKey.DownArrow:
                    this.Delete();

                    if (coords.y < Constants.PlayBoxHeight - Constants.MainShipHeight)
                    {
                        if (coords.y + Constants.MainShipSpeedY <= Constants.PlayBoxHeight - Constants.MainShipHeight)
                            coords.y += Constants.MainShipSpeedY;
                        coords.y++;
                    }
                    this.Draw();

                    break;

                default:
                    this.Draw();
                    break;
            }
        }
    }
}