using DCFApixels.DragonECS;
using UnityEngine;

namespace Game.Scripts.Features.GameElement.Mono
{
    public abstract class Provider : MonoBehaviour
    {
        public abstract void Init(entlong entity);
    }
}