using Features.Player;
using Features.Farm.Components;
using Features.Farm.Systems;
using Game.Scripts.UI;
using UnityEngine;

namespace Game.Scripts.Data
{
    [CreateAssetMenu]
    public class StaticData : ScriptableObject
    {
        [field: SerializeField] public UIService UIService { get; private set; }
        [field: SerializeField] public float SpeedPlayerRotate { get; private set; }
        [field: SerializeField] public PlantSO[] Plants { get; private set; }
        [field: SerializeField] public ActionConfig PlayerActionConfig { get; private set; }
        [field: SerializeField] public ParasiteSO[] Parasites { get; private set; }
    }
}