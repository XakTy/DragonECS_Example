using DCFApixels.DragonECS;
using Game.Scripts.Data;
using Features.Farm.Components;
using Features.Farm.Systems;
using UnityEngine;

namespace Features.Player
{
    public sealed class ParasiteHarvestSystem : IEcsRun
    {
        private readonly Inc<Parasite>.Exc<ParasiteAttack> _parasite;
        private readonly Inc<Parasite, ParasiteAttack> _parasiteAttack;
        
        private readonly EcsDefaultWorld _world;

        private readonly StaticData _staticData;

        public void Run()
        {
            foreach (var e in (_world, _parasite))
            {
                ref var parasite = ref e.Get<Parasite>();

                parasite.timeSpawn -= Time.deltaTime;
                
                if (parasite.timeSpawn > 0f) continue;

                if (parasite.target.Has<Harvestable>())
                {
                    e.Get<ParasiteAttack>().time = e.Get<ActionConfigRef>().value.GetDuration(ActionConst.HARVEST);
                    e.Get<ParasiteAttackEvent>();
                }
                else
                {
                    _world.DelEntity(e);
                }
            }
            
            foreach (var e in (_world, _parasiteAttack))
            {
                ref var parasiteAttack = ref e.Get<ParasiteAttack>();

                parasiteAttack.time -= Time.deltaTime;
                
                ref var parasite = ref e.Get<Parasite>();
                
                if (!parasite.target.Has<Harvestable>())
                {
                    _world.DelEntity(e);
                    continue;
                }
                
                if (parasiteAttack.time <= 0f && parasiteAttack.IsAttacking == false)
                {
                    parasiteAttack.IsAttacking = true;
                    
                    ref var harvestRequest = ref _world.NewEntityLong().Get<HarvestRequest>();
                    
                    harvestRequest.SenderEntity = e;
                    harvestRequest.ReceiverEntity = parasite.target;
                }
            }
            
        }
    }
}