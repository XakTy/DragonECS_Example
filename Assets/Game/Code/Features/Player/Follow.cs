using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    public struct Follow : IEcsComponent
    {
        public Vector3 Offset;
        public entlong target;
        public float Speed;
    }
}