using DCFApixels.DragonECS;
using Features.Interaction.Components;
using Features.Interaction.Systems;

namespace Features.Interaction.Module
{
    public class InteractionModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {

            builder
                .AutoDel<InteractionEvent>()
                .Add(new InteractionOverlapSystem())
                .AutoDel<InteractionRequest>();
        }
    }
}