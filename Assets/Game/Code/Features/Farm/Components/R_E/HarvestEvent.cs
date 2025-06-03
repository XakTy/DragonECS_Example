using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Эвент, возникающий при сборе урожая.
    /// </summary>
    public struct HarvestEvent : IEcsComponent
    {
        public entlong sender; // сущность собирателя
        public entlong receiver; // сущность растения
        public bool OperationSucceeded; // Сбор урожая прошел успешно
    }
}