using DCFApixels.DragonECS;
using Game.Scripts.Components;
using Game.Scripts.Data;
using Game.Scripts.Tools;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.Scripts.Systems
{
    public sealed class StartGameSystem : IEcsRun
    {
        private readonly RuntimeData _runtimeData;
        private readonly EcsDefaultWorld _world;
        public void Run()
        {
            if (_runtimeData.GameState == GameState.Before)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    _world.ChangeStateEvent(GameState.Playing);
                }
            }
        }
    }
}