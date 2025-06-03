using DCFApixels.DragonECS;
using UnityEngine;

namespace Game.Scripts.Features.Inventory
{
    public class ItemSO : ScriptableObject
    {
        public int ID;
        public string Name;
        public string Description;
        public Sprite Icon;
        public bool IsStackable;
        public ItemType Type;
        public ScriptableEntityTemplate EntityTemplate;
    }
}