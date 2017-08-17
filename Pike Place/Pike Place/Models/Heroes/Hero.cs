using System;
using System.Runtime.CompilerServices;
using Pike_Place.Core;
using Pike_Place.Interfaces.Abilities;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models.Mobs;
using Pike_Place.Models.Others;
using Pike_Place.Models.Spells;

namespace Pike_Place.Models.Heroes
{
    public abstract class Hero : IHero
    {      
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public int AttackPower { get; protected set; }
        public Coordinates position = new Coordinates(Constants.Constants.HeroSpawnPositionX, Constants.Constants.HeroSpawnPositionY);
        public string[] HeroPicture { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public ILevel Level { get; protected set; }
        public ISpell Spell { get; protected set; }

        public void TakeDamage(int attackPower)
        {
            
            this.Health -= attackPower;
            if (this.Health<0)
            {
                this.Health = 0;
            }
           
        }

        public string AutoAttack(Mob mob)
        {
            if (IsInRange(mob))
            {
                mob.TakeDamage(this.AttackPower);

                this.TakeDamage(mob.Attack);
                if (mob.IsDead())
                {
                    this.Level.LevelUp(mob.GiveExperience());
                    Heal(mob.Experience);
                    Mana += 7;
                   return $"You killed {mob.GetType().Name}!";
                }                

                return $"You attacked {mob.GetType().Name}!";
            }
            else
            {
                return "You should be in the mobs range to autoattack!";
            }
           
        }

        public string AttackWithSpell(Mob mob)
        {
           if (this.Mana < Spell.ManaCost)
            {
                return "Not enough mana!";
            }
            else
            {
                mob.TakeDamage(Spell.Damage);
                this.Mana -= Spell.ManaCost;
                this.Level.LevelUp(mob.GiveExperience());
                 return $"You attacked {mob.GetType().Name} with spell {Spell.GetType().Name}!";
            }
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
            for (int i = 0; i < this.Height; i++)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine(new string(' ',this.Width));
                coords.y++;
            }
        }

        public void Move(ConsoleKeyInfo keyInfo, ref Coordinates coords)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    this.Delete();
                    if (coords.x < Constants.Constants.PlayBoxWidth - this.Width)
                    {
                        if (coords.x + Constants.Constants.MainShipSpeedX <= Constants.Constants.PlayBoxWidth - this.Width)
                            coords.x += Constants.Constants.MainShipSpeedX;
                        coords.x++;
                    }
                    this.Draw();
                    break;
                case ConsoleKey.LeftArrow:
                    this.Delete();

                    if (coords.x - 1 > Constants.Constants.FrameWidth)
                    {
                        if (coords.x - Constants.Constants.MainShipSpeedX > Constants.Constants.FrameWidth)
                            coords.x -= Constants.Constants.MainShipSpeedX;
                        coords.x--;
                    }
                    this.Draw();

                    break;
                case ConsoleKey.UpArrow:
                    this.Delete();

                    if (coords.y - 1 > Constants.Constants.FrameWidth+3)
                    {
                        if (coords.y - Constants.Constants.MainShipSpeedY > Constants.Constants.FrameWidth)
                            coords.y -= Constants.Constants.MainShipSpeedY;
                        coords.y--;
                    }
                    this.Draw();


                    break;
                case ConsoleKey.DownArrow:
                    this.Delete();

                    if (coords.y < Constants.Constants.PlayBoxHeight - this.Height)
                    {
                        if (coords.y + Constants.Constants.MainShipSpeedY <= Constants.Constants.PlayBoxHeight - this.Height)
                            coords.y += Constants.Constants.MainShipSpeedY;
                        coords.y++;
                    }
                    this.Draw();

                    break;
              
                default:
                    this.Draw();
                    break;
            }
        }

        public bool IsInRange(Mob other)
        {
           
            if (this.position.x> other.Position.x -4 - this.Width)
            {
                if (this.position.y > other.Position.y-4-this.Height && this.position.y<other.Position.y+other.MobPicture.Length+4)
                {
                    return true;
                }
            }
             if (this.position.x > other.Position.x+ other.MobPicture.Length && this.position.x < other.Position.x + other.MobPicture.Length+4)
            {
                if (this.position.y > other.Position.y - 4 - this.Height && this.position.y < other.Position.y + other.MobPicture.Length + 4)
                {
                    return true;
                }
            }
            return false;
        }

        public void Heal(int hp)
        {
            this.Health += hp;
        }

        public bool IsDead()
        {
            if (this.Health==0)
            {
                return true;
            }
            return false;
        }
    }
}