using System;
using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    [Serializable]
    public struct InputPlayer : IEcsComponent
    {
        public Vector2 Dir;
        public bool IsInteracting;
    }
}