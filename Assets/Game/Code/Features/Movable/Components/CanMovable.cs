using System;
using DCFApixels.DragonECS;

namespace Features.Movable.Components
{
    [Serializable]
    public struct CanMovable : IEcsComponent
    {
        public int count;
    }
}