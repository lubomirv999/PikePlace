using Pike_Place.Interfaces.Creatures;
using Pike_Place.Models.Mobs;

namespace Pike_Place.Factories
{
    public class MobFactroy
    {
        public static Mob GenerateMob(int randomNumber)
        {
            Mob mob;

            switch (randomNumber)
            {
                case 0:
                    return mob = new Doom();
                case 1:
                    return mob = new SkullCrusher();
                case 2:
                    return mob = new TheViper();
                default:
                    return null;
            }
        }
    }
}