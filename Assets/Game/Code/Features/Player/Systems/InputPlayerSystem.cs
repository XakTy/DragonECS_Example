using DCFApixels.DragonECS;
using Features.Movable.Components;
using Game.Scripts.Data;
using UnityEngine;

namespace Features.Player
{
    public sealed class InputPlayerSystem : IEcsRun
    {
        private readonly Inc<Player, Speed> _player;
        private readonly Inc<InputPlayer> _playerInput;

        private readonly EcsDefaultWorld _world;

        private readonly RuntimeData _runtimeData;

        private Vector3 _startMouseX;
        
        public void Run()
        {
            foreach (var player in (_world, _playerInput))
            {
                if (player.Get<CanMovable>().count <= 0 || player.Has<InputLockFlag>())
                {
                    player.Get<InputPlayer>().Dir = Vector2.zero;
                    player.Get<InputPlayer>().IsInteracting = false;
                    continue;
                }
                
                if (Input.GetMouseButtonDown(0))
                {
                    _startMouseX = Input.mousePosition;
                }

                if (Input.GetMouseButton(0))
                {
                    var dirNormalize = (Input.mousePosition - _startMouseX).normalized;
                    player.Get<Direction>().value.Set(dirNormalize.x, dirNormalize.y);
                    player.Get<InputPlayer>().Dir = dirNormalize;
                }
                else
                {
                    var dirNormalize = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
                    
                    player.Get<Direction>().value.Set(dirNormalize.x, dirNormalize.y);
                    player.Get<InputPlayer>().Dir = dirNormalize;
                }

                player.Get<InputPlayer>().IsInteracting = Input.GetKeyDown(KeyCode.Space);
            }

        }
    }
}