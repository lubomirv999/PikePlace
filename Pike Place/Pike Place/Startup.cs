using System;
using Pike_Place.Core;
using Pike_Place.Factories;
using Pike_Place.Models;
using Pike_Place.Models.Mobs;

namespace Pike_Place
{
    public class Startup
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}