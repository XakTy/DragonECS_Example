using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Эвент, возникающий при посадке растения.
    /// </summary>
    public struct PlantSeedEvent : IEcsComponent
    {
        public int PlantId; // ID посаженного растения
    }
}