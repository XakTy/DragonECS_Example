using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    public sealed class AnimationPlayerMoveSystem : IEcsRun
    {
        private readonly Inc<InputPlayer, PlayerViewRef> _player;
        private readonly EcsDefaultWorld _world;
        public void Run()
        {
            foreach (var e in (_world, _player))
            {
                var dir = e.Get<InputPlayer>().Dir;
                if (dir != Vector2.zero)
                {
                    e.Get<PlayerViewRef>().value.Walk();
                }
                else
                {
                    e.Get<PlayerViewRef>().value.Idle();
                }
            }
        }
    }
}