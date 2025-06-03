using DCFApixels.DragonECS;

namespace Features.Farm.Components
{
    /// <summary>
    /// Компонент попытки полива
    /// </summary>
    
    public struct SoilMoistureSelfRequest : IEcsComponent
    {
        public entlong Sender;
        public float Moisture;
    }
}