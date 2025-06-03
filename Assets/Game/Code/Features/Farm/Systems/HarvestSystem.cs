using DCFApixels.DragonECS;
using Game.Scripts.Features.GameElement.Components;
using Features.Interaction.Components;
using Features.Farm.Components;
using Features.VegatableBox.Components;
using UnityEngine;

namespace Features.Farm.Systems
{
    /// <summary>
    /// Система сбора урожая.
    /// </summary>
    public sealed class HarvestSystem : IEcsRun
    {
        private readonly Inc<HarvestRequest> _harvestablePlots;
        private readonly EcsDefaultWorld _world;

        public void Run()
        {
            foreach (var e in (_world, _harvestablePlots))
            {
                ref var request = ref e.Get<HarvestRequest>();


                var global = _world.NewEntityLong();
                
                global.Get<GlobalEvent>();
                ref var harvestGlobalEvent = ref global.Get<HarvestEvent>();
                harvestGlobalEvent.sender = request.SenderEntity;
                harvestGlobalEvent.receiver = request.ReceiverEntity;

                if (!request.ReceiverEntity.Has<Harvestable>())
                {
                    break;
                }
                
                request.ReceiverEntity.Del<Seed>();
                request.ReceiverEntity.Del<Growth>();
                request.ReceiverEntity.Del<Harvestable>();
                
                request.ReceiverEntity.Get<HarvestEvent>().sender = request.SenderEntity;
                    
                ref var plot = ref request.ReceiverEntity.Get<FarmPlot>();
                plot.IsOccupied = false;
                harvestGlobalEvent.OperationSucceeded = true;

                Debug.Log("Урожай собран!");
            }
        }
    }
}