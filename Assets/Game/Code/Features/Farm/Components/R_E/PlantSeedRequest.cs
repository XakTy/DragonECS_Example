using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Реквест на посадку семени (отправляется при попытке посадить растение).
    /// </summary>
    public struct PlantSeedRequest : IEcsComponent
    {
        public entlong PlotEntity; // ID грядки, на которую сажаем
        public entlong Sender; // сущность посадившего растение
    }
}