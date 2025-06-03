using DCFApixels.DragonECS;
using Game.Scripts.Data;
using Features.Farm.Components;
using UnityEngine;

namespace Features.Farm.Systems
{
    /// <summary>
    /// Система роста растений.
    /// </summary>
    public sealed class PlantGrowthSystem : IEcsRun
    {
        private readonly Inc<Seed, Growth, SoilMoisture, Sunlight>.Exc<Harvestable> _growingPlants;
    
        private readonly EcsDefaultWorld _world;

        private readonly RuntimeData _runtimeData;

        private readonly PlantService _plantService;
    
        public void Run()
        {
            foreach (var e in (_world, _growingPlants))
            {
                ref var growth = ref e.Get<Growth>();
                ref var soil = ref e.Get<SoilMoisture>();
                ref var sunlight = ref e.Get<Sunlight>();

                float growthFactor = (soil.Moisture + sunlight.Intensity) * 0.5f; // Среднее влияние факторов
                
                var plantConfig = _plantService.GetConfig(e.Get<Seed>().PlantId);
                
                growth.CurrentGrowth += growth.GrowthRate * growthFactor * _runtimeData.deltaTime;

                if (growth.CurrentGrowth / plantConfig.GrowTime >= 1.0f)
                {
                    growth.CurrentGrowth = 1;
                    e.Get<Harvestable>();
                    e.Get<PlantGrownEvent>();
                    Debug.Log("Растение выросло!");
                }
            }
        }
    }
}