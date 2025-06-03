using System;
using DCFApixels.DragonECS;

namespace Features.Movable.Components
{
    [Serializable]
    public struct TimerBlockMovable : IEcsComponent
    {
        public entlong Receiver;
        public float Time;
    }
}