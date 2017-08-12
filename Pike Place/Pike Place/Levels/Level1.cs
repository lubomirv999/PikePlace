using System;
using System.Diagnostics;
using System.Threading;
using Pike_Place.Core;
using Pike_Place.Factories;
using Pike_Place.Models;
using Pike_Place.Models.Mobs;

namespace Pike_Place.Levels
{
    class Level1
    {
        internal void Start(Hero hero)
        {
            Console.SetWindowSize(Constants.ConsoleWindowWidth, Constants.ConsoleWindowHeight);
            Console.Clear();
            Menu.DrawFrame();
            hero.Draw();
            Random rnd = new Random();

            Mob mob = MobFactroy.GenerateMob(rnd.Next(0, 2));
            Menu.DrawScores(hero, mob);
            mob.Draw();
            Stopwatch time = new Stopwatch();
            time.Start();

            do
            {
                if (time.Elapsed.Milliseconds % 100 == 0)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo KeyInfo;

                        KeyInfo = Console.ReadKey(true);
                        hero.Move(KeyInfo, ref hero.position);
                    }

                    continue;
                }
            } while (true);


            //            while (true)
            //            {
            //                Console.WriteLine($"You are facing the {mob.ToString()} Creature!!!");
            //                try
            //                {
            //                    Console.WriteLine(hero.AttackWithSpell(mob));
            //
            //                }
            //                catch (ArgumentException argEx)
            //                {
            //                    Console.WriteLine(argEx.Message);
            //                }
            //
            //            }
        }
    }
}