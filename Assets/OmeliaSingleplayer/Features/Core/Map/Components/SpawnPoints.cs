using ME.ECS;
using OmeliaSingleplayer.Features.Core.Map.Views;

namespace OmeliaSingleplayer.Features.Core.Map.Components {

    public struct SpawnPoints : IStructComponent
    {

        public MapView.SpawnPoint[] value;

    }
    
}