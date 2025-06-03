using DCFApixels.DragonECS;
using Features.Interaction.Components;
using UnityEngine;

namespace Features.Interaction.Systems
{
    public sealed class InteractionOverlapSystem : IEcsRun
    {
        private readonly Inc<UnityComponent<Transform>, InteractionRequest> _transform;
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _transform))
            {
                var transform = e.Get<UnityComponent<Transform>>().obj;
                
                var colliders = Physics.OverlapSphere(transform.position, 0.5f);
                
                foreach (var collider in colliders)
                {
                    var connect = collider.GetComponentInParent<EcsEntityConnect>();
                    
                    if (connect && connect.Entity.IsAlive && connect.Entity.Has<InteractionFlag>() && !connect.Entity.Has<InteractionEvent>())
                    {
                        Debug.Log("Interact Event");
                        connect.Entity.Get<InteractionEvent>().sender = e;
                    }
                }
            }
        }
    }
}