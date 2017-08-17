using System;
using System.Diagnostics;
using System.Threading;
using Pike_Place.Core;
using Pike_Place.Factories;
using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models;
using Pike_Place.Models.Heroes;
using Pike_Place.Models.Mobs;

namespace Pike_Place.Levels
{
    class Level1
    {
        internal void Start(Hero hero, ref bool ended)
        {
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
                if (mob.IsDead())
                {
                    mob.Delete();
                    rnd = new Random();
                    mob = MobFactroy.GenerateMob(rnd.Next(0, 2));
                    Menu.DrawScores(hero, mob);
                    mob.Draw();
                }
                if (hero.IsDead())
                {
                    ended = true;
                }
                if (time.Elapsed.Milliseconds % 80 == 0)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo KeyInfo;

                        KeyInfo = Console.ReadKey(true);
                        if (KeyInfo.Key == ConsoleKey.A)
                        {
                            hero.Delete();
                            Thread.Sleep(250);
                            Console.SetCursorPosition(3, 4);
                            Console.WriteLine(new string(' ', Constants.Constants.PlayBoxWidth -3));
                            Console.SetCursorPosition(3, 4);
                            Console.WriteLine(hero.AutoAttack(mob));
                            hero.Draw();
                            Menu.DrawScores(hero, mob);
                        }
                        else if (KeyInfo.Key == ConsoleKey.S)
                        {
                            hero.Delete();
                            Thread.Sleep(250);
                            Console.SetCursorPosition(3, 4);
                            Console.WriteLine(new string(' ', Constants.Constants.PlayBoxWidth - 3));
                            Console.SetCursorPosition(3, 4);
                            Console.WriteLine(hero.AttackWithSpell(mob));
                            hero.Draw();
                            Menu.DrawScores(hero, mob);
                        }
                        else
                        {
                            Console.SetCursorPosition(3, 4);
                            Console.WriteLine(new string(' ', Constants.Constants.PlayBoxWidth - 3));
                            hero.Move(KeyInfo, ref hero.position);
                        }
                    }

                    continue;
                }
            } while (!ended);


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