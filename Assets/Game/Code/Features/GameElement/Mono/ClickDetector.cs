using System;
using DCFApixels.DragonECS;
using Game.Scripts.Features.GameElement.Components;
using Game.Scripts.Tools;
using UnityEngine;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

namespace Game.Scripts.Features.GameElement.Mono
{
    public class ClickDetector : Provider, IPointerDownHandler
    {
        private entlong _entity;
        
        public override void Init(entlong entity)
        {
            _entity = entity;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("click");
            _entity.Get<ClickEvent>();
        }
    }
}