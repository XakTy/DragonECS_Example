using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Реквест на сбор урожая (отправляется при попытке собрать урожай).
    /// </summary>
    public struct HarvestRequest : IEcsComponent
    {
        public entlong ReceiverEntity; // сущность грядки, откуда собираем урожай
        public entlong SenderEntity; // сущность собирателя
    }
}