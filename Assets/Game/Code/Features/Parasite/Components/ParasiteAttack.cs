using DCFApixels.DragonECS;

namespace Features.Player
{
    public struct ParasiteAttack : IEcsComponent
    {
        public bool IsAttacking;
        public float time;
    }
}