using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteViewChild : MonoBehaviour
    {
        public ParasiteView Parent;
        public void Connect()
        {
            Parent.Connect();
        }
    }
}