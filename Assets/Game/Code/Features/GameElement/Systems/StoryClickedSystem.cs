using DCFApixels.DragonECS;
using Game.Scripts.Features.GameElement.Components;

namespace Game.Scripts.Features.GameElement.Systems
{
    public sealed class StoryClickedSystem : IEcsRun
    {
        private readonly Inc<StoryTag, ClickEvent> _events;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _events))
            {
                
            }
        }
    }
}