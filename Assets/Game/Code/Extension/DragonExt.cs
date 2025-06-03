using DCFApixels.DragonECS;
using Game.Scripts.Tools;

namespace Game.Scripts
{
    public static class DragonExt
    {
        public static EcsPipeline.Builder InjectService<T>(this EcsPipeline.Builder self, T d0)
        {
            self.Inject(d0);
            Service<T>.Set(d0);

            return self;
        }
    }
}