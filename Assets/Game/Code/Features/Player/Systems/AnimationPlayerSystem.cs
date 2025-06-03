using DCFApixels.DragonECS;
using Features.Farm.Components;

namespace Features.Player
{
    public sealed class AnimationPlayerSystem : IEcsRun
    {
        private readonly Inc<PendingActionComponent, PlayerViewRef> _current;
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _current))
            {
                e.Get<PlayerViewRef>().value.SetAnim(e.Get<PendingActionComponent>());
                e.Del<PendingActionComponent>();
            }
        }
    }
}