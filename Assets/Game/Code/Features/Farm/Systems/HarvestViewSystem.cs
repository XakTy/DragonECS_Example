using DCFApixels.DragonECS;
using Features.Player;
using Features.Farm.Components;
using UnityEngine;

namespace Features.Farm.Systems
{
    public sealed class HarvestViewSystem : IEcsRun
    {
        private readonly Inc<PlantViewRef, HarvestEvent> _harvest;
        
        private readonly Inc<PlantViewRef, PlantGrownEvent> _grown;
        
        private readonly Inc<FarmPlot, PlantSeedEvent> _plantSeed;
        
        private readonly EcsDefaultWorld _world;

        private readonly PlantService _plantService;
        
        public void Run()
        {
            foreach (var e in (_world, _harvest))
            {
                if (e.Get<HarvestEvent>().sender.Has<Player.Player>())
                {
                    e.Get<PlantViewRef>().value.Hide();
                }
                
                e.Get<PendingActionComponent>().ID = ActionConst.PUT;
            }
            
            foreach (var e in (_world, _grown))
            {
                e.Get<PlantViewRef>().value.Jump();
                e.Get<PendingActionComponent>().ID = ActionConst.PUT;
            }
            
            foreach (var e in (_world, _plantSeed))
            {
                e.Get<PendingActionComponent>().ID = ActionConst.SHOWER;

                var prefab = Object.Instantiate(_plantService.GetConfig(e.Get<Seed>().PlantId).Prefab,
                    e.Get<GameObjectConnect>().Connect.transform.position, Quaternion.identity);

                e.Get<PlantViewRef>().value = prefab.GetComponentInChildren<PlantView>();
                e.Get<PlantViewRef>().value.SetProgress(0);
                e.Get<PlantViewRef>().value.Show();
            }
        }
    }
}