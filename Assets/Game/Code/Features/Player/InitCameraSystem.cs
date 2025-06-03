using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    public sealed class InitCameraSystem : IEcsInit
    {
        private readonly EcsDefaultWorld _world;

        public void Init()
        {
            var camera = _world.NewEntityLong();
            var componentInChildren = Camera.main.GetComponentInChildren<EcsEntityConnect>();
            componentInChildren.Connect(camera, true);
        }
    }
}