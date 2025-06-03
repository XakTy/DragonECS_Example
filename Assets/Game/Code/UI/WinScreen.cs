using Game.Scripts.Tools;
using UnityEngine.UI;

namespace Game.Scripts.UI
{
    public class WinScreen : Screen
    {
        public Button NextLevelButton;
        private void OnNextLevelClick()
        {
        }
        public override void Init()
        {
        }

        public override void Enable()
        {
			NextLevelButton.onClick.AddListener(OnNextLevelClick);
		}

        public override void Disable()
        {
			NextLevelButton.onClick.RemoveListener(OnNextLevelClick);
		}
    }
}