namespace Game.Scripts.Features.Inventory
{

    public static class InventoryExtension
    {
        public static Slot GetSlot(this ref Inventory inventory, int index)
        {
            return inventory.Slots[index];
        }
    }
}