using DCFApixels.DragonECS;
using Features.Farm.Components;

namespace Features.Farm.Systems
{
    public sealed class GrowthViewSystem : IEcsRun
    {
        private readonly Inc<PlantViewRef, Growth> _plantViewRef;
        private readonly EcsDefaultWorld _world;

        private readonly PlantService _plantService;
        
        public void Run()
        {
            foreach (var e in (_world, _plantViewRef))
            {
                e.Get<PlantViewRef>().value.SetProgress(e.Get<Growth>().CurrentGrowth / _plantService.GetConfig(e.Get<Seed>().PlantId).GrowTime);
            }
        }
    }
}