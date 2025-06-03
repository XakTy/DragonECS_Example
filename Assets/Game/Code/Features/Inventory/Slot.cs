using DCFApixels.DragonECS;

namespace Game.Scripts.Features.Inventory
{
    public class Slot
    {
        public ItemType RequiredItemType;
        
        public entlong Item;

        public bool IsNull => Item.IsNull;
        
        public bool IsStackable => Item.Has<IsStackable>();
    }
}