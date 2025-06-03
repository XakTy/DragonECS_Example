using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент, обозначающий, что сущность является семенем растения.
    /// </summary>
    [Serializable]
    public struct Seed : IEcsComponent
    {
        public int PlantId;       // ID растения (какой вид будет расти)
        public float GrowthTime;  // Время, необходимое для полного роста
    }
}