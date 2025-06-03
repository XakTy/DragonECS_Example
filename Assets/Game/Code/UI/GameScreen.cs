using TMPro;
using UnityEngine;

namespace Game.Scripts.UI
{
    public class GameScreen : Screen
    {
        public TextMeshProUGUI Level;
        [field: SerializeField] public RectTransform ContainerCurrencies { get; private set; }

        public override void Init()
        {
        }
        public override void Enable()
        {
        }

        public override void Disable()
        {
        }
    }
}