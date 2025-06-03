using DCFApixels.DragonECS;
using Features.Movable.Components;
using UnityEngine;

namespace Features.Movable.Systems
{
    public sealed class TimerBlockMovableSystem : IEcsRun
    {
        private readonly Inc<TimerBlockMovable> _timers;

        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _timers))
            {
                ref var timerBlockMovable = ref e.Get<TimerBlockMovable>();
                timerBlockMovable.Time -= Time.deltaTime;

                if (timerBlockMovable.Time <= 0f)
                {
                    timerBlockMovable.Receiver.Get<CanMovable>().count++;
                    _world.DelEntity(e);
                }
            }
        }
    }
}