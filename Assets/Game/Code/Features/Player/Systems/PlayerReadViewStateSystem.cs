using DCFApixels.DragonECS;
using Features.Movable.Components;
using Features.Farm.Systems;

namespace Features.Player
{
    public sealed class PlayerReadViewStateSystem : IEcsRun
    {
        private readonly Inc<Player, PendingActionComponent> _player;
        
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _player))
            {
                var request = _world.NewEntityLong();
                ref var blockMovableRequest = ref request.Get<BlockMovableRequest>();
                blockMovableRequest.target = e;
                blockMovableRequest.Duration = e.Get<ActionConfigRef>().value.GetDuration(e.Get<PendingActionComponent>().ID);;
            }
        }
    }
}