using System;
using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    [Serializable]
    public struct Direction : IEcsComponent
    {
        public Vector2 value;
    }
}