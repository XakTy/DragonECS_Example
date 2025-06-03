using DCFApixels.DragonECS;
using Features.Interaction.Components;
using Features.Farm.Components;
using UnityEngine;

namespace Features.VegatableBox.Components
{
    public sealed class VegetableBoxInteractionSystem : IEcsRun
    {
        private readonly Inc<VegetableBox, InteractionEvent> _box;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _box))
            {
                var colliders = Physics.OverlapBox(e.Get<GameObjectConnect>().Connect.transform.position,
                    new Vector3(10f, 10f, 10f));
                ;
                
                foreach (var collider in colliders)
                {
                    Debug.Log(collider.name);
                    
                    var connect = collider.GetComponentInParent<EcsEntityConnect>();
                    
                    if(connect == null || connect.Entity.IsNull) continue;
                    
                    if (connect.Entity.Has<FarmPlot>() && connect.Entity.Has<Harvestable>())
                    {
                        Debug.Log("harvest begin");
                        ref var harvestRequest = ref _world.NewEntityLong().Get<HarvestRequest>();
                        harvestRequest.ReceiverEntity = connect.Entity;
                        harvestRequest.SenderEntity = e;
                    }
                }
            }
        }
    }
}