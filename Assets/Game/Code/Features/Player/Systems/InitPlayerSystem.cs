using DCFApixels.DragonECS;
using Features.Movable.Components;
using Game.Scripts.Data;
using Features.Farm.Systems;
using UnityEngine;

namespace Features.Player
{
    public sealed class InitPlayerSystem : IEcsInit
    {
        private readonly EcsDefaultWorld _world;
        
        private readonly Inc<Follow> _follow;

        private readonly StaticData _staticData;
        
        public void Init()
        {
            var playerView = Object.FindFirstObjectByType<PlayerView>();
            var player = _world.NewEntityLong();
            var componentInChildren = playerView.GetComponent<EcsEntityConnect>();
            
            componentInChildren.Connect(player, true);
            
            player.Get<Player>();
            player.Get<PlayerViewRef>().value = playerView;
            player.Get<InputPlayer>();
            player.Get<Direction>();
            player.Get<CanMovable>().count = 1;
            player.Get<ActionConfigRef>().value = _staticData.PlayerActionConfig;
            
            foreach (var e in (_world, _follow))
            {
                ref var follow = ref e.Get<Follow>();
                follow.target = player;
                follow.Offset = e.Get<UnityComponent<Transform>>().obj.position - playerView.transform.position;
            }
        }
    }
}