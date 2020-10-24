using ME.ECS;
using OmeliaSingleplayer.Features.Core.Map.Views;

namespace OmeliaSingleplayer.Features.Core {

    using Components; using Modules; using Systems; using Features; using Markers;
    using Map.Components; using Map.Modules; using Map.Systems; using Map.Markers;
    
    namespace Map.Components {}
    namespace Map.Modules {}
    namespace Map.Systems {}
    namespace Map.Markers {}
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    
    public sealed class MapFeature : Feature
    {
        public MapView MapView;
        public Entity map;
        
        protected override void OnConstruct()
        {

            var viewId = this.world.RegisterViewSource(this.MapView); // Registration prefab in scene

            var map = new Entity("Map");
            map.SetData(new IsMap());
            map.SetData(new SpawnPoints()
            {
                value = this.MapView.spawnPoints
            });
            map.SetData(new MapInitializer(), ComponentLifetime.NotifyAllSystems);
            
            map.InstantiateView(viewId);
            this.map = map;
            
            AddSystem<MapInitializerSystem>(); // 2
        }

        protected override void OnDeconstruct() {
            
        }

    }

}