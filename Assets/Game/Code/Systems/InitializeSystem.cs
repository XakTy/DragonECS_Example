using DCFApixels.DragonECS;
using Game.Scripts.Components;
using Game.Scripts.Data;
using Features.Player;
using Features.Farm.Components;
using Game.Scripts.Tools;
using Game.Scripts.UI;
using UnityEngine;

namespace Game.Scripts.Systems
{
    public sealed class InitializeSystem : IEcsInit
    {
        private readonly UIService _uiService;
        private readonly RuntimeData _runtimeData;
        private readonly EcsDefaultWorld _world;
        private readonly StaticData _staticData;
        
        public void Init()
        {
            _uiService.HideAll();
      
            _world.ChangeStateEvent(GameState.Before);
            
            var gameScreen = _uiService.GetScreen<GameScreen>();
            
            Service<EcsDefaultWorld>.Set(_world);
            
            foreach (var connect in Object.FindObjectsByType<EcsEntityConnect>(FindObjectsSortMode.None))
            {
                if(connect.GetComponentInParent<PlayerView>() != null) continue;
                
                var entity = _world.NewEntityLong();
                connect.Connect(entity, true);
                
                if (entity.Has<FarmPlot>())
                {
                    connect.Entity.Get<PendingActionComponent>().ID = "Put";
                }
            }
        }
    }
}