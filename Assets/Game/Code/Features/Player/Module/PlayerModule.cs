using DCFApixels.DragonECS;
using Features.Movable.Systems;
using Features.Farm.Systems;

namespace Features.Player
{
    public class PlayerModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {

            builder
                .Add(new InitPlayerSystem())
                .Add(new InputPlayerSystem())
                .Add(new InteractionPlayerSystem())
                .Add(new AnimationPlayerMoveSystem())
                .Add(new TimerBlockMovableSystem())
                .Add(new PlayerReadViewStateSystem())
                .Add(new BlockMovableSystem())
                .Add(new AnimationPlayerSystem())
                .Add(new CharacterMoveSystem());
        }
    }
}