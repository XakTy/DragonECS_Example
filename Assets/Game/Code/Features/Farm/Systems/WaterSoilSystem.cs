using DCFApixels.DragonECS;
using Features.Interaction.Components;
using Features.Farm.Components;
using UnityEngine;

namespace Features.Farm.Systems
{
    /// <summary>
    /// Система увлажнения почвы (например, при поливе).
    /// </summary>
    public sealed class WaterSoilSystem : IEcsRun
    {
        private readonly Inc<FarmPlot, SoilMoisture, SoilMoistureSelfRequest> _soilPlots;
        private readonly EcsDefaultWorld _world;

        public void Run()
        {
            foreach (var e in (_world, _soilPlots))
            {
                ref var soil = ref e.Get<SoilMoisture>();
                soil.Moisture += e.Get<SoilMoistureSelfRequest>().Moisture;

                e.Get<SoilMoistureEvent>();
                e.Get<SoilMoistureSelfRequest>().Sender.Get<SoilMoistureEvent>();
                
                Debug.Log("Почва полита");
            }
        }
    }
}