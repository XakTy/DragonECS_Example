using System.Collections.Generic;
using System.Linq;
using Game.Scripts.Data;

namespace Features.Farm.Components
{
    public sealed class PlantService : IPlantService
    {
        private Dictionary<int, PlantSO> _plants;

        public PlantService(StaticData staticData)
        {
            _plants = staticData.Plants.ToDictionary(x => x.ID, x => x);
        }
        
        public PlantSO GetConfig(int id)
        {
            if (_plants.TryGetValue(id, out var plantSo))
            {
                return plantSo;
            }
            
            throw new System.Exception($"Plant with id {id} not found");
        }
    }
}