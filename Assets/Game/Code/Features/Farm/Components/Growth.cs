using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент, отвечающий за рост растения.
    /// </summary>
    [Serializable]
    public struct Growth : IEcsComponent
    {
        public float CurrentGrowth; // Текущее состояние роста (0.0 - семя, 1.0 - полностью выросло)
        public float GrowthRate;    // Скорость роста в единицах за секунду
    }
}