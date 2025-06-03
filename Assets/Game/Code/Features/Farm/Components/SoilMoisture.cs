using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент ресурсов, необходимых для роста.
    /// </summary>
    [Serializable]
    public struct SoilMoisture : IEcsComponent
    {
        public float Moisture; // Уровень влаги (0 - сухая почва, 1 - полностью увлажненная)
    }
}