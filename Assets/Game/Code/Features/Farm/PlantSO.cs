using UnityEngine;

namespace Features.Farm.Components
{
    [CreateAssetMenu(fileName = "PlantSO", menuName = "Game/PlantSO", order = 0)]
    public sealed class PlantSO : ScriptableObject
    {
        [field: SerializeField] public int ID { get; private set; }
        
        [field: SerializeField] public float GrowTime  { get; private set; }
        
        [field: SerializeField] public PlantView Prefab { get; private set; }
    }
}