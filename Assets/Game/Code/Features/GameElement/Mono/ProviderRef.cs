using System;
using DCFApixels.DragonECS;

namespace Game.Scripts.Features.GameElement.Mono
{
    [Serializable]
    public struct ProviderRef : IEcsComponent
    {
        public Provider[] Providers;
    }
}