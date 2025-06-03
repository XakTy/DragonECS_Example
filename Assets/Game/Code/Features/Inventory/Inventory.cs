using System.Collections.Generic;
using DCFApixels.DragonECS;

namespace Game.Scripts.Features.Inventory
{
    public struct Inventory : IEcsComponent
    {
        public Dictionary<int, Slot> Slots;
    }
}