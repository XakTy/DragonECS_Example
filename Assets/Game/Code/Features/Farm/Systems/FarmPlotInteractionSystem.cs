using DCFApixels.DragonECS;
using Features.Player;
using Features.Interaction.Components;
using Features.Farm.Components;

namespace Features.Farm.Systems
{
    public sealed class FarmPlotInteractionSystem : IEcsRun
    {
        private readonly Inc<FarmPlot, Harvestable, InteractionEvent> _harvest;
        private readonly Inc<FarmPlot, InteractionEvent>.Exc<Seed> _seed;
        private readonly Inc<FarmPlot, Growth, InteractionEvent>.Exc<Harvestable> _soil;
        private readonly Inc<FarmPlot, InteractionEvent> _interact;
        
        private readonly EcsDefaultWorld _world;

        public void Run()
        {
            foreach (var e in (_world, _seed))
            {
                ref var plantSeedRequest = ref _world.NewEntityLong().Get<PlantSeedRequest>();
                plantSeedRequest.PlotEntity = e;
                plantSeedRequest.Sender = e.Get<InteractionEvent>().sender;
            }

            foreach (var e in (_world, _harvest))
            {
                ref var harvestRequest = ref _world.NewEntityLong().Get<HarvestRequest>();
                harvestRequest.ReceiverEntity = e;
                harvestRequest.SenderEntity = e.Get<InteractionEvent>().sender;
            }
            
            foreach (var e in (_world, _soil))
            {
                ref var soilRequest = ref e.Get<SoilMoistureSelfRequest>();
                soilRequest.Moisture = 1;
                soilRequest.Sender = e.Get<InteractionEvent>().sender;
            }
            
            foreach (var e in (_world, _interact))
            {
                ref var action = ref e.Get<PendingActionComponent>();
                e.Get<InteractionEvent>().sender.Get<PendingActionComponent>() = action;
            }
        }
    }
}