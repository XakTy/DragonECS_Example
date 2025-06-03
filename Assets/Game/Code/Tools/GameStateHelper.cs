using DCFApixels.DragonECS;
using Game.Scripts.Components;

namespace Game.Scripts.Tools
{
    public static class GameStateHelper
    {
        public static void ChangeStateEvent(this EcsDefaultWorld world, GameState gameState)
        {
            var entityEvent = world.NewEntity();
            var poolEvent = world.GetPool<ChangeStateEvent>();
            poolEvent.Add(entityEvent).NewGameState = gameState;    
        }
    }
}