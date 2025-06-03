using DCFApixels.DragonECS;
using Game.Scripts.Data;
using Game.Scripts.Features.GameElement.Components;
using Features.Farm.Components;
using UnityEngine;

namespace Features.Farm.Systems
{
    /// <summary>
    /// Система посадки семян.
    /// </summary>
    public sealed class PlantSeedSystem : IEcsRun
    {
        private readonly Inc<PlantSeedRequest> _plantSeed;
        
        private readonly EcsDefaultWorld _world;

        private readonly StaticData _staticData;

        public void Run()
        {
            foreach (var e in (_world, _plantSeed))
            {
                ref var request = ref e.Get<PlantSeedRequest>();
                if (request.PlotEntity.Get<FarmPlot>().IsOccupied) break;
                
                request.PlotEntity.Get<FarmPlot>().IsOccupied = true;
                request.PlotEntity.Get<Seed>().PlantId = _staticData.Plants[Random.Range(0, _staticData.Plants.Length)].ID;
                request.PlotEntity.Get<Growth>().GrowthRate = 0.1f; // Скорость роста
                
                request.PlotEntity.Get<PlantSeedEvent>();
                request.Sender.Get<PlantSeedEvent>();
                
                Debug.Log("Посажено семя");
            }
        }
    }
}