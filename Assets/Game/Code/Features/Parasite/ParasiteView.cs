using DG.Tweening;
using TriInspector;
using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteView : MonoBehaviour
    {
        [SerializeField] private Transform _animOwner;
        [SerializeField] private Transform _fly;
        
        [SerializeField] private Animator _animator;
        [SerializeField] private string _animation;
        
        [SerializeField] private GameObject _target;
        
        public void Steal(GameObject target)
        {
            _target = target;
            _animator.Play(_animation);
            var currentAnimatorClipInfo = _animator.GetCurrentAnimatorClipInfo(0);
        }

        public void Connect()
        {
            if (_target != null)
            {
                _target.transform.SetParent(_fly);
            }
        }
    }
}