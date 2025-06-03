using DCFApixels.DragonECS;
using Features.VegatableBox.Components;

namespace Features.VegatableBox.Module
{
    public class VegetableBoxModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {
            builder
                .Add(new VegetableBoxInteractionSystem())
                .Add(new VegetableBoxInteractionViewSystem());
        }
    }
}