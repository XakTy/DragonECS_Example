using System;
using DCFApixels.DragonECS;
using Game.Scripts.Components;
using Game.Scripts.Data;
using Game.Scripts.UI;
using UnityEngine;

namespace Game.Scripts.Systems
{
    public sealed class ChangeStateSystem : IEcsRun
    {
        private readonly UI.UIService _uiService;
        private readonly StaticData _staticData;
        private readonly RuntimeData _runtimeData;
        private readonly SceneData _sceneData;
        
        private readonly Inc<ChangeStateEvent> _events;
        private readonly EcsDefaultWorld _world;
        public void Run()
        {
            
            foreach (var e in (_world, _events))
            {
                var state = e.Get<ChangeStateEvent>().NewGameState;
                
                Debug.Log(state);
                
                _runtimeData.GameState = state;
                switch (state)
                {
                    case GameState.Before:
                        _uiService.GetScreen<MenuScreen>().Show(true);
						_uiService.GetScreen<MenuScreen>().Level.text = $"Level {_runtimeData.Level + 1}";

						_uiService.GetScreen<GameScreen>().Show(false);
                        break;
                    case GameState.Playing:
                        _runtimeData.LevelStartedTime = Time.realtimeSinceStartup;

                        _uiService.GetScreen<MenuScreen>().Show(false);
                        
                        _uiService.GetScreen<GameScreen>().Level.text = $"Level {_runtimeData.Level + 1}";
						_uiService.GetScreen<GameScreen>().Show(true);
                        break;
                    case GameState.Win:

                        _uiService.GetScreen<GameScreen>().Show(false);
                        _uiService.GetScreen<WinScreen>().Show(true);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
               
                e.Del<ChangeStateEvent>();
            }
        }
    }
}