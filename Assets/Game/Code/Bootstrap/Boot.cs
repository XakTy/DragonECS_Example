using System.Collections;
using Game.Scripts.Data;
using Game.Scripts.Tools;
using UnityEngine;

namespace Game.Scripts
{
    class Boot : MonoBehaviour
    {
        public StaticData StaticData;
        IEnumerator Start()
        {
            Service<StaticData>.Set(StaticData);
            yield return null;
        }
    }
}