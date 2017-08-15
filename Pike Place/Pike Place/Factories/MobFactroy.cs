using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models.Mobs;

namespace Pike_Place.Factories
{
    public class MobFactroy
    {
        public static Mob GenerateMob(int randomNumber)
        {
           

            switch (randomNumber)
            {
                case 0:
                    return  new Doom();
                case 1:
                    return  new SkullCrusher();
                case 2:
                    return  new TheViper();
                default:
                    return null;
            }
        }
    }
}