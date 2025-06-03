using DCFApixels.DragonECS;

namespace Features.Player
{
    public class ParasiteModule : IEcsModule
    {
        public void Import(EcsPipeline.Builder builder)
        {
            builder
                .AutoDel<ParasiteAttackEvent>()
                .Add(new ParasiteHarvestSystem())
                .Add(new ParasiteSpawnSystem())
                .Add(new ParasiteViewSystem());
        }
    }
}