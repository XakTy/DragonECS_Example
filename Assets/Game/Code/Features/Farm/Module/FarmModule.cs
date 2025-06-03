using DCFApixels.DragonECS;
using Features.Farm.Components;
using Features.Farm.Systems;

namespace Features.Farm.Module
{
    public class FarmModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {

            builder
                .AutoDel<HarvestEvent>()
                .Add(new HarvestSystem())
                .AutoDel<HarvestRequest>()

                .AutoDel<PlantSeedEvent>()
                .Add(new PlantSeedSystem())
                .AutoDel<PlantSeedRequest>()

                .AutoDel<PlantGrownEvent>()
                .Add(new PlantGrowthSystem())

                .AutoDel<SoilMoistureEvent>()
                .Add(new WaterSoilSystem())
                .AutoDel<SoilMoistureSelfRequest>();
        }
    }
}