using DCFApixels.DragonECS;

namespace Features.Movable.Components
{
    public struct BlockMovableRequest : IEcsComponent
    {
        public entlong target;
        public float Duration;
    }
}