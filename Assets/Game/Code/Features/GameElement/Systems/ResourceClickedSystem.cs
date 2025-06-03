using DCFApixels.DragonECS;
using Game.Scripts.Features.GameElement.Components;
using UnityEngine;

namespace Game.Scripts.Features.GameElement.Systems
{
    public sealed class ResourceClickedSystem : IEcsRun
    {
        private readonly Inc<ResourceTag, ClickEvent> _events;

        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _events))
            {
                Debug.Log("Resource clicked");
            }
        }
    }
}