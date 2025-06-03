using DCFApixels.DragonECS;
using Features.Movable.Components;

namespace Features.Movable.Systems
{
    public sealed class BlockMovableSystem : IEcsRun
    {
        private readonly Inc<BlockMovableRequest> _blockMovable;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _blockMovable))
            {
                var block = e.Get<BlockMovableRequest>();

                if (block.target.Has<CanMovable>())
                {
                    block.target.Get<CanMovable>().count--;

                    ref var timerBlockMovable = ref _world.NewEntityLong().Get<TimerBlockMovable>();
                    timerBlockMovable.Receiver = block.target;
                    timerBlockMovable.Time = block.Duration;
                }
                
                _world.DelEntity(e);
            }
        }
    }
}