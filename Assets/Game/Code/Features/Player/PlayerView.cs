using UnityEngine;

namespace Features.Player
{
    public sealed class PlayerView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        private static readonly int IsWalk = Animator.StringToHash("IsWalk");
        private static readonly int Put = Animator.StringToHash("Put");
        private static readonly int Shower = Animator.StringToHash("Shower");

        public void Idle()
        {
            _animator.SetBool(IsWalk, false);
        }
        
        public void Walk()
        {
            _animator.SetBool(IsWalk, true);
        }

        public void PutSeed()
        {
            _animator.SetTrigger(Put);
        }

        public void ShowerFarm()
        {
            _animator.SetTrigger(Shower);
        }
        public void SetAnim(PendingActionComponent get)
        {
            _animator.SetTrigger(get.ID);
        }
    }
}