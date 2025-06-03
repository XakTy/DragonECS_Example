using DCFApixels.DragonECS;
using Features.Interaction.Components;
using Features.Player;
using UnityEngine;

namespace Features.Farm.Systems
{
    public sealed class InteractionPlayerSystem : IEcsRun
    {
        private readonly Inc<InputPlayer> _input;
        private readonly EcsDefaultWorld _world;
        
        public void Run()
        {
            foreach (var e in (_world, _input))
            {
                if (e.Get<InputPlayer>().IsInteracting)
                {
                    Debug.Log("player request");
                    e.Get<InteractionRequest>();
                }
            }
        }
    }
}