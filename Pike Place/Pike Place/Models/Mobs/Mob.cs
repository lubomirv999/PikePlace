using System;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models.Others;

namespace Pike_Place.Models.Mobs
{
    public abstract class Mob : IMob
    {
        public int Health { get; protected set; }
        public int Attack { get; protected set; }
        public int Experience { get; protected set; }
        public Coordinates Position { get; protected set; }
        public string[] MobPicture { get; set; }

        public int GiveExperience()
        {
            if (IsDead())
            {
               return this.Experience;
            }
            return 0;
        }

        public bool IsDead()
        {
            if (this.Health <= 0)
            {
                return true;
            }
            return false;
        }

        public void TakeDamage(int attackPower)
        {
            this.Health -= attackPower;
        }

        public void Draw()
        {
            Coordinates coords = this.Position;

            foreach (var line in this.MobPicture)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine("{0}", line);
                coords.y++;
            }
        }

        public void Delete()
        {
//            Coordinates coords = new Coordinates(this.position.x, this.position.y);
//            for (int i = 0; i < this.Height; i++)
//            {
//                Console.SetCursorPosition(coords.x, coords.y);
//                Console.WriteLine(new string(' ', this.Width));
//                coords.y++;
//            }
        }
    }
}