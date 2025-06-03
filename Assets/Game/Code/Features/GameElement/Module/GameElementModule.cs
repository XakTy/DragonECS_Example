using DCFApixels.DragonECS;
using Game.Scripts.Features.GameElement.Components;
using Game.Scripts.Features.GameElement.Systems;

namespace Game.Scripts.Features.GameElement.Module
{
    public class GameElementModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder b)
        {
            b.Add(new StoryClickedSystem())
                .Add(new ResourceClickedSystem())
                .AutoDel<ClickEvent>();
        }
    }
}