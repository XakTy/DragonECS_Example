using Features.Farm.Systems;
using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteSO : ScriptableObject
    {
        [field: SerializeField] public ParasiteView ParasiteView { get; private set; }
        
        [field: SerializeField] public ActionConfig ActionConfig { get; private set; }
    }
}