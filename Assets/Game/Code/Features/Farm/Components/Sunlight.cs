using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    [Serializable]
    public struct Sunlight : IEcsComponent
    {
        public float Intensity; // Интенсивность солнечного света (0 - нет солнца, 1 - полный свет)
    }
}