
using System;
using Pike_Place.Models;

namespace Pike_Place.Interfaces.Abilities
{
    public interface IMoveable
    {
        void Move(ConsoleKeyInfo keyInfo, ref Coordinates coords);
    }
}
