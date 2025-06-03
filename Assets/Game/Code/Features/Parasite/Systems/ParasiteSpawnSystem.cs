using DCFApixels.DragonECS;
using Game.Scripts.Data;
using Features.Farm.Components;
using Features.Farm.Systems;
using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteSpawnSystem : IEcsRun
    {
        private readonly Inc<FarmPlot, PlantGrownEvent> _plantGrown;
        
        private readonly EcsDefaultWorld _world;

        private readonly StaticData _staticData;

        public void Run()
        {
            foreach (var e in (_world, _plantGrown))
            {
                var entityParasite = _world.NewEntityLong();
                
                ref var parasite = ref entityParasite.Get<Parasite>();
                parasite.timeSpawn = Random.Range(15f, 20f);
                parasite.target = e;
                
                var randParasite = _staticData.Parasites[Random.Range(0, _staticData.Parasites.Length)];

                parasite.Config = randParasite;
                entityParasite.Get<ActionConfigRef>().value = randParasite.ActionConfig;
            }
        }
    }
}