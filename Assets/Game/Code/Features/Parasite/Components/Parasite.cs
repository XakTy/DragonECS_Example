using DCFApixels.DragonECS;

namespace Features.Player
{
    public struct Parasite : IEcsComponent
    {
        public ParasiteSO Config;
        public float timeSpawn;
        public entlong target;
    }
}