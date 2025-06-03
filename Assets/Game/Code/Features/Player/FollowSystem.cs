using DCFApixels.DragonECS;
using UnityEngine;

namespace Features.Player
{
    public sealed class FollowSystem : IEcsRun
    {
        private readonly Inc<Follow> _follow;
        private readonly EcsDefaultWorld _world;

        public void Run()
        {
            foreach (var e in (_world, _follow))
            {
                var follow = e.Get<Follow>();
                if(follow.target.IsNull) continue;
                
                var targetPosition = e.Get<Follow>().target.Get<UnityComponent<Transform>>().obj.position;
                e.Get<UnityComponent<Transform>>().obj.position = targetPosition + follow.Offset;
            }
        }
    }
}