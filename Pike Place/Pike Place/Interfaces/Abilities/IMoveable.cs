
using System;
using Pike_Place.Models;
using Pike_Place.Models.Mobs;
using Pike_Place.Models.Others;

namespace Pike_Place.Interfaces.Abilities
{
    public interface IMoveable
    {
        void Move(ConsoleKeyInfo keyInfo, ref Coordinates coords);
        bool IsInRange(Mob other);
    }
}
