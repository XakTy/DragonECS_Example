using DCFApixels.DragonECS;
using Features.Farm.Systems;

namespace Features.Farm.Module
{
    public class FarmViewModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {

            builder
                .Add(new HarvestViewSystem())
                .Add(new GrowthViewSystem());
        }
    }
}