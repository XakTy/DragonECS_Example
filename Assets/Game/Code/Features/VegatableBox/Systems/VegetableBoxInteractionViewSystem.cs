using DCFApixels.DragonECS;
using DG.Tweening;
using Features.Farm.Components;
using UnityEngine;

namespace Features.VegatableBox.Components
{
    public struct GlobalEvent : IEcsComponent
    {
        
    }
    public sealed class VegetableBoxInteractionViewSystem : IEcsRun
    {
        private readonly Inc<HarvestEvent, GlobalEvent> _boxHarvest;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _boxHarvest))
            {
                var harvestEvent = e.Get<HarvestEvent>();
                
                if(!harvestEvent.sender.IsAlive || !harvestEvent.receiver.IsAlive) continue;

                if (!harvestEvent.sender.Has<VegetableBox>()) continue;
                
                var box = harvestEvent.sender.Get<GameObjectConnect>().Connect;

                var transformVegatable = harvestEvent.receiver.Get<PlantViewRef>().value.transform;
                    
                transformVegatable.DOJump(box.transform.position, 1f, 1, 0.5f);
                transformVegatable.DOScale(Vector3.zero, 0.5f).SetDelay(0.5f).OnComplete(
                    () =>
                    {
                        transformVegatable.gameObject.SetActive(false);
                    });
            }
        }
    }
}