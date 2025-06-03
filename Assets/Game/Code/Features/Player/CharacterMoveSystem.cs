using DCFApixels.DragonECS;
using Game.Scripts.Data;
using UnityEngine;

namespace Features.Player
{
    public sealed class CharacterMoveSystem : IEcsRun
    {
        private readonly Inc<UnityComponent<CharacterController>, InputPlayer, Speed> _player;

        private readonly EcsDefaultWorld _world;
        
        private readonly SceneData _sceneData;
        private readonly RuntimeData _runtimeData;
        private readonly StaticData _staticData;

        public void Run()
        {
            foreach (var player in (_world, _player))
            {
                var character = player.Get<UnityComponent<CharacterController>>().obj;
                var direction = player.Get<InputPlayer>().Dir;
                var speed = player.Get<Speed>().value;
                
                if (direction == Vector2.zero) continue;

                var rot =  (Quaternion.Euler(0f, -45f, 0) * new Vector3(direction.x, 0f, direction.y)).normalized;

                character.Move( rot * speed * _runtimeData.deltaTime);
                
                character.transform.rotation = Quaternion.Lerp(character.transform.rotation, Quaternion.LookRotation(rot), _runtimeData.deltaTime * _staticData.SpeedPlayerRotate);

            }
        }
    }
}