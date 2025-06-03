using System;
using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    [Serializable]
    public struct PlantViewRef : IEcsComponent
    {
        public PlantView value;
    }
    
    
}