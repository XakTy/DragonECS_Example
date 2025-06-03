using System;
using DCFApixels.DragonECS;

namespace Features.Player
{
    [Serializable]
    public struct Speed : IEcsComponent
    {
        public float value;
    }
}