using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент, обозначающий сущность как грядку.
    /// </summary>
    [Serializable]
    public struct FarmPlot : IEcsComponent
    {
        public bool IsOccupied; // Занята ли грядка растением
    }
    
}