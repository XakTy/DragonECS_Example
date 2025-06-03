using DCFApixels.DragonECS;
using Features.Farm.Components;
using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteViewSystem : IEcsRun
    {
        private readonly Inc<Parasite, ParasiteAttackEvent> _parasite;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _parasite))
            {
                ref var parasite = ref e.Get<Parasite>();
                var parasiteView = Object.Instantiate(parasite.Config.ParasiteView, 
                    parasite.target.Get<PlantViewRef>().value.transform.position, 
                    Quaternion.identity);
                parasiteView.Steal(parasite.target.Get<PlantViewRef>().value.AnimationObject);
            }
        }
    }
}