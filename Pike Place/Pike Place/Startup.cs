using System;
using Pike_Place.Core;
using Pike_Place.Factories;
using Pike_Place.Heroes;
using Pike_Place.Models;
using Pike_Place.Models.Mobs;

namespace Pike_Place
{
    public class Startup
    {
        public static void Main()
        {
            //Engine engine = new Engine();
            //engine.Run();

            Hero hero = new Mage("Pesho");
            Random rnd = new Random(2);
           
            Mob mob = MobFactroy.GenerateMob(rnd.Next(0 ,2));
            while (true)
            {
                Console.WriteLine($"You are facing the {mob.ToString()} Creature!!!");
                try
                {
                    Console.WriteLine(hero.AttackWithSpell(mob));
                    
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
                
            }
            
            
        }
    }
}