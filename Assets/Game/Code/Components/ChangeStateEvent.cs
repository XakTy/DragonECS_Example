using DCFApixels.DragonECS;

namespace Game.Scripts.Components
{
    public struct ChangeStateEvent : IEcsComponent
    {
        public GameState NewGameState;
    }
}