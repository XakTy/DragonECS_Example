using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Эвент, возникающий, когда растение полностью выросло.
    /// </summary>
    public struct PlantGrownEvent : IEcsComponent
    {
        public int PlantId; // ID растения
    }
}