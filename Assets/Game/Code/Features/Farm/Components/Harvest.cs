using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент, который отвечает за возможность сбора урожая.
    /// </summary>
    [Serializable]
    public struct Harvest : IEcsComponent
    {
        public int Amount; // Количество урожая, которое дает растение
    }
}