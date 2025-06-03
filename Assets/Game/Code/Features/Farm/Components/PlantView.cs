using System;
using DG.Tweening;
using TriInspector;
using UnityEngine;

namespace Features.Farm.Components
{
    public class PlantView : MonoBehaviour
    {
        [SerializeField] private GameObject _animObj;
        [SerializeField] private float _minScale;
        public GameObject AnimationObject => _animObj;
        public void SetProgress(float value)
        {
            value = Mathf.Lerp(_minScale, 1, value);
            _animObj.transform.localScale = new Vector3(value, value, value);
        }

        [Button("anim")]
        
        public void Jump()
        {
            var pos = _animObj.transform.position;
            pos.y += 1;
            _animObj.transform.DOJump(pos, 0.5f, 1, 0.5f).SetEase(Ease.InBack);
            pos.y -= 1;
            _animObj.transform.DOMoveY( pos.y, 0.5f).SetEase(Ease.OutBounce).SetDelay(0.5f);
        }
        public void Show()
        {
            _animObj.SetActive(true);
        }
        public void Hide()
        {
            _animObj.SetActive(false);
        }
    }
}